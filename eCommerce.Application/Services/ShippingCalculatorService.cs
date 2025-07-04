using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Application.Services
{
    public class ShippingCalculatorService
    {
        private readonly AppDbContext _context;

        public ShippingCalculatorService(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Calculates shipping rates for a given order, considering inventory availability and nearest warehouse.
        /// </summary>
        /// <param name="destinationCountryCode">Destination country (e.g., "US").</param>
        /// <param name="destinationStateProvince">Optional: Destination state/province.</param>
        /// <param name="destinationZipCode">Optional: Destination zip code.</param>
        /// <param name="destinationLatitude">Latitude of destination for distance calculation.</param>
        /// <param name="destinationLongitude">Longitude of destination for distance calculation.</param>
        /// <param name="orderDetails">List of items in the order, with their details (including ProductId).</param>
        /// <param name="totalOrderValue">Total value of the order.</param>
        /// <param name="destinationFloorNumber">Optional: Floor number for delivery, for apartment surcharges (default 1).</param>
        /// <param name="isRuralArea">Optional: Flag if destination is considered rural (based on zip code mapping or external service, default false).</param>
        /// <returns>A list of available shipping options with their calculated costs.</returns>
        public async Task<List<ShippingRouteOption>> CalculateShippingRates(
            string destinationCountryCode,
            string? destinationStateProvince,
            string? destinationZipCode,
            double destinationLatitude,
            double destinationLongitude,
            List<OrderItemDetailsDto> orderDetails,
            decimal totalOrderValue,
            int destinationFloorNumber = 1,
            bool isRuralArea = false)
        {
            var finalShippingOptions = new List<ShippingRouteOption>();

            // 1. Aggregate product details and check inventory
            var productIds = orderDetails.Select(od => od.ProductId).Distinct().ToList();
            var productsInOrder = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.ProductShippingProfile)
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (productsInOrder.Count != productIds.Count)
            {
                // Handle case where some products are not found in DB
                Console.WriteLine("Error: One or more products in order details not found in database.");
                return finalShippingOptions;
            }

            // Calculate total weight, volume, and identify product shipping profiles/categories
            decimal totalActualWeightKg = 0;
            decimal totalDimensionalWeightKg = 0;
            decimal totalVolumeCbm = 0;
            var distinctProductShippingProfileIds = new HashSet<int>();
            var distinctProductCategoryIds = new HashSet<int>();
            int totalItemCount = 0;

            foreach (var item in orderDetails)
            {
                var product = productsInOrder.First(p => p.Id == item.ProductId);
                totalActualWeightKg += product.NetWeightKg * item.Quantity;
                distinctProductCategoryIds.Add(product.ProductCategoryId);

                int? productShippingProfileId = product.ProductShippingProfileId;
                ProductShippingProfile? productShippingProfile = product.ProductShippingProfile;

                // Fallback to Category's default if no specific profile linked or provided
                if (productShippingProfile == null)
                {
                    productShippingProfile = new ProductShippingProfile
                    {
                        DefaultDimensionalFactor = product.ProductCategory.DefaultDimensionalFactor
                    };
                }
                if (productShippingProfileId.HasValue)
                {
                    distinctProductShippingProfileIds.Add(productShippingProfileId.Value);
                }

                decimal itemVolumeCm3 = product.Depth * product.Width * product.Height;
                totalVolumeCbm += (itemVolumeCm3 / 1_000_000m) * item.Quantity;

                decimal dimensionalFactor = (decimal)productShippingProfile.DefaultDimensionalFactor;
                totalDimensionalWeightKg += (itemVolumeCm3 / dimensionalFactor) * item.Quantity;
                totalItemCount += item.Quantity;
            }

            decimal applicableWeightKg = Math.Max(totalActualWeightKg, totalDimensionalWeightKg);
            decimal applicableVolumeCbm = totalVolumeCbm;

            // 2. Find Destination Shipping Zone
            var destinationZone = await GetShippingZoneForLocation(destinationCountryCode, destinationStateProvince, destinationZipCode);
            if (destinationZone == null)
            {
                Console.WriteLine($"Error: Destination shipping zone not found for {destinationCountryCode}.");
                return finalShippingOptions;
            }

            // 3. Find candidate warehouses with sufficient inventory
            var availableWarehouses = await _context.Warehouses
                .Include(w => w.InventoryItems)
                .Include(w => w.ShippingZone)
                .Where(w => w.InventoryItems!.Any(ii => productIds.Contains(ii.ProductId))) // Quick filter: warehouse has at least one product
                .ToListAsync();

            var fulfillingWarehouses = new List<Warehouse>();
            foreach (var warehouse in availableWarehouses)
            {
                bool canFulfill = true;
                foreach (var item in orderDetails)
                {
                    var inventoryItem = warehouse.InventoryItems?.FirstOrDefault(ii => ii.ProductId == item.ProductId);
                    if (inventoryItem == null || inventoryItem.AvailableQuantity < item.Quantity)
                    {
                        canFulfill = false;
                        break;
                    }
                }
                if (canFulfill)
                {
                    fulfillingWarehouses.Add(warehouse);
                }
            }

            if (!fulfillingWarehouses.Any())
            {
                Console.WriteLine("No single warehouse found with sufficient inventory for all items in the order.");
                return finalShippingOptions;
            }

            // 4. Evaluate routes from each fulfilling warehouse
            foreach (var originWarehouse in fulfillingWarehouses)
            {
                double distanceToCustomer = HaversineDistance(
                    originWarehouse.Latitude,
                    originWarehouse.Longitude,
                    destinationLatitude,
                    destinationLongitude
                );

                Console.WriteLine($"Evaluating route from {originWarehouse.Name} (Distance to customer: {distanceToCustomer:F2} km)");

                // Determine the origin zone for the current warehouse
                var originZoneForRoute = originWarehouse.ShippingZone ?? await GetShippingZoneForLocation(originWarehouse.CountryCode, originWarehouse.StateProvince, originWarehouse.ZipCode);
                if (originZoneForRoute == null)
                {
                    Console.WriteLine($"Warning: Could not determine shipping zone for warehouse {originWarehouse.Name}. Skipping.");
                    continue;
                }

                // If Origin and Destination are in the same country, primarily look for domestic rules
                if (originWarehouse.CountryCode == destinationCountryCode)
                {
                    await EvaluateDomesticRoutes(
                        originWarehouse, originZoneForRoute, destinationZone,
                        applicableWeightKg, applicableVolumeCbm, totalItemCount, totalOrderValue,
                        destinationFloorNumber, isRuralArea, distinctProductShippingProfileIds, distinctProductCategoryIds,
                        finalShippingOptions);
                }
                else // International shipment
                {
                    // For international, prioritize rules that utilize GlobalShippingLanes (port-to-port)
                    // and then follow up with domestic rules for last-mile.

                    // Step 1: Find International Freight rules from Origin Warehouse's Zone to any potential destination port/hub zone
                    var internationalFreightRules = await _context.ShippingRateRules
                        .Include(r => r.ShippingServiceLevel)
                        .Include(r => r.GlobalShippingLane)
                            .ThenInclude(gsl => gsl!.DestinationShippingZone) // Load destination zone of the lane
                                .ThenInclude(sz => sz.Region) // Load region for country code check
                        .Include(r => r.ShippingRateTiers)
                        .Where(r => r.IsActive &&
                                    r.OriginShippingZoneId == originZoneForRoute.Id &&
                                    r.GlobalShippingLane != null && // Must be an international lane rule
                                    r.GlobalShippingLane.DestinationShippingZone.Region != null &&
                                    r.GlobalShippingLane.DestinationShippingZone.Region.Code == destinationCountryCode && // Ensure lane goes to the destination country
                                    totalOrderValue >= r.MinOrderValue && (r.MaxOrderValue == 0 || totalOrderValue <= r.MaxOrderValue) &&
                                    applicableWeightKg >= r.MinApplicableWeightKg && (r.MaxApplicableWeightKg == 0 || applicableWeightKg <= r.MaxApplicableWeightKg) &&
                                    applicableVolumeCbm >= r.MinApplicableCbm && (r.MaxApplicableCbm == 0 || applicableVolumeCbm <= r.MaxApplicableCbm) &&
                                    totalItemCount >= r.MinItemsInOrder && (r.MaxItemsInOrder == 0 || totalItemCount <= r.MaxItemsInOrder)
                        )
                        .Where(r => r.ProductShippingProfileId == null || distinctProductShippingProfileIds.Contains(r.ProductShippingProfileId.Value))
                        .Where(r => r.ProductCategoryId == null || distinctProductCategoryIds.Contains(r.ProductCategoryId.Value))
                        .ToListAsync();

                    foreach (var intlRule in internationalFreightRules)
                    {
                        var destinationPortZone = intlRule.GlobalShippingLane!.DestinationShippingZone;

                        // Step 2: Find Domestic Last-Mile rules from the International Lane's Destination Zone to the Customer's Destination Zone
                        var lastMileRules = await _context.ShippingRateRules
                            .Include(r => r.ShippingServiceLevel)
                            .Include(r => r.ShippingRateTiers)
                            .Where(r => r.IsActive &&
                                        r.OriginShippingZoneId == destinationPortZone.Id &&
                                        r.DestinationShippingZoneId == destinationZone.Id &&
                                        r.GlobalShippingLaneId == null && // Must be a domestic rule
                                        totalOrderValue >= r.MinOrderValue && (r.MaxOrderValue == 0 || totalOrderValue <= r.MaxOrderValue) &&
                                        applicableWeightKg >= r.MinApplicableWeightKg && (r.MaxApplicableWeightKg == 0 || applicableWeightKg <= r.MaxApplicableWeightKg) &&
                                        applicableVolumeCbm >= r.MinApplicableCbm && (r.MaxApplicableCbm == 0 || applicableVolumeCbm <= r.MaxApplicableCbm) &&
                                        totalItemCount >= r.MinItemsInOrder && (r.MaxItemsInOrder == 0 || totalItemCount <= r.MaxItemsInOrder)
                            )
                            .Where(r => r.ProductShippingProfileId == null || distinctProductShippingProfileIds.Contains(r.ProductShippingProfileId.Value))
                            .Where(r => r.ProductCategoryId == null || distinctProductCategoryIds.Contains(r.ProductCategoryId.Value))
                            .ToListAsync();

                        foreach (var lastMileRule in lastMileRules)
                        {
                            // Combine costs and times for the full international route
                            decimal intlCost = CalculateRuleCost(intlRule, applicableWeightKg, applicableVolumeCbm, totalItemCount, totalOrderValue, 1, false); // Floor/rural don't apply to port-to-port
                            decimal lastMileCost = CalculateRuleCost(lastMileRule, applicableWeightKg, applicableVolumeCbm, totalItemCount, totalOrderValue, destinationFloorNumber, isRuralArea);

                            // Check for free shipping on the whole route (if applicable to combined rules)
                            bool isFreeShipping = (intlRule.IsFreeShippingThreshold && totalOrderValue >= intlRule.FreeShippingMinOrderValue) ||
                                                  (lastMileRule.IsFreeShippingThreshold && totalOrderValue >= lastMileRule.FreeShippingMinOrderValue);

                            if (isFreeShipping)
                            {
                                intlCost = 0m;
                                lastMileCost = 0m;
                            }

                            finalShippingOptions.Add(new ShippingRouteOption
                            {
                                OriginWarehouse = originWarehouse,
                                ServiceLevelName = $"{intlRule.ShippingServiceLevel.Name} via {intlRule.GlobalShippingLane!.TransitMode} + {lastMileRule.ShippingServiceLevel.Name}",
                                DeliveryType = lastMileRule.ShippingServiceLevel.DeliveryType.ToString(),
                                IncludesAssembly = lastMileRule.ShippingServiceLevel.IncludesAssembly,
                                EstimatedDeliveryDaysMin = intlRule.ShippingServiceLevel.EstimatedDeliveryDaysMin + (intlRule.GlobalShippingLane?.EstimatedTransitDaysMin ?? 0) + lastMileRule.ShippingServiceLevel.EstimatedDeliveryDaysMin,
                                EstimatedDeliveryDaysMax = intlRule.ShippingServiceLevel.EstimatedDeliveryDaysMax + (intlRule.GlobalShippingLane?.EstimatedTransitDaysMax ?? 0) + lastMileRule.ShippingServiceLevel.EstimatedDeliveryDaysMax,
                                TotalCost = intlCost + lastMileCost,
                                RouteDescription = $"From {originWarehouse.Name} ({originWarehouse.CountryCode}) to {destinationPortZone.Name} ({intlRule.GlobalShippingLane!.TransitMode}) then to customer ({lastMileRule.ShippingServiceLevel.Name}).",
                                RouteLegs = new List<ShippingRouteLeg>
                                {
                                    new ShippingRouteLeg { AppliedRule = intlRule, LegCost = intlCost, LegEstimatedDaysMin = intlRule.ShippingServiceLevel.EstimatedDeliveryDaysMin + (intlRule.GlobalShippingLane?.EstimatedTransitDaysMin ?? 0), LegEstimatedDaysMax = intlRule.ShippingServiceLevel.EstimatedDeliveryDaysMax + (intlRule.GlobalShippingLane?.EstimatedTransitDaysMax ?? 0), LegDescription = intlRule.RuleName },
                                    new ShippingRouteLeg { AppliedRule = lastMileRule, LegCost = lastMileCost, LegEstimatedDaysMin = lastMileRule.ShippingServiceLevel.EstimatedDeliveryDaysMin, LegEstimatedDaysMax = lastMileRule.ShippingServiceLevel.EstimatedDeliveryDaysMax, LegDescription = lastMileRule.RuleName }
                                }
                            });
                        }
                    }
                }
            }

            // 5. Group and select the best option per unique Service Level/Route combination
            // This ensures we don't return duplicate "White Glove" options if multiple warehouses offer it,
            // but rather the one with the lowest overall cost.
            var bestOptions = finalShippingOptions
                .GroupBy(o => new { o.ServiceLevelName, o.DeliveryType, o.IncludesAssembly }) // Group by the distinct service offered
                .Select(g => g.OrderBy(o => o.TotalCost).ThenBy(o => o.EstimatedDeliveryDaysMin).First())
                .OrderBy(o => o.TotalCost)
                .ToList();

            return bestOptions;
        }

        // Helper to evaluate domestic routes
        private async Task EvaluateDomesticRoutes(
            Warehouse originWarehouse, ShippingZone originZone, ShippingZone destinationZone,
            decimal applicableWeightKg, decimal applicableVolumeCbm, int totalItemCount, decimal totalOrderValue,
            int destinationFloorNumber, bool isRuralArea,
            HashSet<int> distinctProductShippingProfileIds, HashSet<int> distinctProductCategoryIds,
            List<ShippingRouteOption> finalShippingOptions)
        {
            var domesticRules = await _context.ShippingRateRules
                .Include(r => r.ShippingServiceLevel)
                .Include(r => r.ShippingRateTiers)
                .Where(r => r.IsActive &&
                            r.OriginShippingZoneId == originZone.Id &&
                            r.DestinationShippingZoneId == destinationZone.Id &&
                            r.GlobalShippingLaneId == null && // Ensure it's a domestic rule
                            totalOrderValue >= r.MinOrderValue && (r.MaxOrderValue == 0 || totalOrderValue <= r.MaxOrderValue) &&
                            applicableWeightKg >= r.MinApplicableWeightKg && (r.MaxApplicableWeightKg == 0 || applicableWeightKg <= r.MaxApplicableWeightKg) &&
                            applicableVolumeCbm >= r.MinApplicableCbm && (r.MaxApplicableCbm == 0 || applicableVolumeCbm <= r.MaxApplicableCbm) &&
                            totalItemCount >= r.MinItemsInOrder && (r.MaxItemsInOrder == 0 || totalItemCount <= r.MaxItemsInOrder)
                )
                .Where(r => r.ProductShippingProfileId == null || distinctProductShippingProfileIds.Contains(r.ProductShippingProfileId.Value))
                .Where(r => r.ProductCategoryId == null || distinctProductCategoryIds.Contains(r.ProductCategoryId.Value))
                .ToListAsync();

            foreach (var rule in domesticRules)
            {
                decimal cost = CalculateRuleCost(rule, applicableWeightKg, applicableVolumeCbm, totalItemCount, totalOrderValue, destinationFloorNumber, isRuralArea);

                if (rule.IsFreeShippingThreshold && totalOrderValue >= rule.FreeShippingMinOrderValue)
                {
                    cost = 0m;
                }

                finalShippingOptions.Add(new ShippingRouteOption
                {
                    OriginWarehouse = originWarehouse,
                    ServiceLevelName = rule.ShippingServiceLevel.Name,
                    DeliveryType = rule.ShippingServiceLevel.DeliveryType.ToString(),
                    IncludesAssembly = rule.ShippingServiceLevel.IncludesAssembly,
                    EstimatedDeliveryDaysMin = rule.ShippingServiceLevel.EstimatedDeliveryDaysMin,
                    EstimatedDeliveryDaysMax = rule.ShippingServiceLevel.EstimatedDeliveryDaysMax,
                    TotalCost = cost,
                    RouteDescription = $"From {originWarehouse.Name} ({originWarehouse.CountryCode}) via {rule.ShippingServiceLevel.Name}.",
                    RouteLegs = new List<ShippingRouteLeg> {
                        new ShippingRouteLeg { AppliedRule = rule, LegCost = cost, LegEstimatedDaysMin = rule.ShippingServiceLevel.EstimatedDeliveryDaysMin, LegEstimatedDaysMax = rule.ShippingServiceLevel.EstimatedDeliveryDaysMax, LegDescription = rule.RuleName }
                    }
                });
            }
        }
        /// <summary>
        /// Helper to find a ShippingZone based on location details.
        /// Priority: ZipCodePrefix -> StateProvince -> Country -> Region
        /// </summary>
        private async Task<ShippingZone?> GetShippingZoneForLocation(string countryCode, string? stateProvince, string? zipCode)
        {
            // Try to find by most specific first (ZipCodePrefix)
            if (!string.IsNullOrEmpty(zipCode))
            {
                var zone = await _context.ShippingZoneDetails
                    .Include(d => d.ShippingZone)
                        .ThenInclude(sz => sz.Region)
                    .Where(d => d.DetailType == ZoneDetailType.ZipCodePrefix && zipCode.StartsWith(d.Value))
                    .Select(d => d.ShippingZone)
                    .FirstOrDefaultAsync();
                if (zone != null) return zone;
            }

            // Then by State/Province
            if (!string.IsNullOrEmpty(stateProvince))
            {
                var zone = await _context.ShippingZoneDetails
                    .Include(d => d.ShippingZone)
                        .ThenInclude(sz => sz.Region)
                    .Where(d => d.DetailType == ZoneDetailType.StateProvince && d.Value == stateProvince)
                    .Select(d => d.ShippingZone)
                    .FirstOrDefaultAsync();
                if (zone != null) return zone;
            }

            // Then by Country Code (as a detail)
            var countryZoneDetail = await _context.ShippingZoneDetails
                .Include(d => d.ShippingZone)
                    .ThenInclude(sz => sz.Region)
                .Where(d => d.DetailType == ZoneDetailType.Country && d.Value == countryCode)
                .Select(d => d.ShippingZone)
                .FirstOrDefaultAsync();
            if (countryZoneDetail != null) return countryZoneDetail;

            // Fallback: Find a ShippingZone that directly references the Region (country)
            return await _context.ShippingZones
                .Include(sz => sz.Region)
                .Where(sz => sz.Region != null && sz.Region.Code == countryCode)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Calculates the Haversine distance between two sets of coordinates in kilometers.
        /// </summary>
        private double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Radius of Earth in kilometers

            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);

            lat1 = ToRadians(lat1);
            lat2 = ToRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1) * Math.Cos(lat2) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Distance in km
        }

        private double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        /// <summary>
        /// Calculates the cost for a single shipping rate rule.
        /// </summary>
        private decimal CalculateRuleCost(ShippingRateRule rule, decimal applicableWeightKg, decimal applicableVolumeCbm, int totalItemCount, decimal totalOrderValue, int destinationFloorNumber, bool isRuralArea)
        {
            decimal calculatedCost = rule.BaseRate;

            if (rule.ShippingRateTiers != null && rule.ShippingRateTiers.Any())
            {
                var tierUnit = rule.ShippingRateTiers.First().TierUnit;
                decimal tierValue = GetTierValue(tierUnit, applicableWeightKg, applicableVolumeCbm, totalItemCount);

                var applicableTier = rule.ShippingRateTiers
                    .FirstOrDefault(t => tierValue >= t.MinValue && (t.MaxValue == 0 || tierValue <= t.MaxValue));

                if (applicableTier != null)
                {
                    calculatedCost += applicableTier.FixedTierCost;
                    calculatedCost += applicableTier.RatePerUnit * tierValue;
                }
            }
            else
            {
                if (rule.RatePerKg > 0) calculatedCost += rule.RatePerKg * applicableWeightKg;
                if (rule.RatePerCbm > 0) calculatedCost += rule.RatePerCbm * applicableVolumeCbm;
                if (rule.RatePerItem > 0) calculatedCost += rule.RatePerItem * totalItemCount;
            }

            calculatedCost += rule.FlatSurcharge;
            if (rule.PercentageSurcharge > 0)
            {
                calculatedCost += calculatedCost * (rule.PercentageSurcharge / 100m);
            }
            if (rule.ApplyFloorSurcharge && destinationFloorNumber >= rule.MinFloorForSurcharge)
            {
                calculatedCost += rule.SurchargePerFloor * (destinationFloorNumber - rule.MinFloorForSurcharge + 1);
            }
            if (rule.IsRuralAreaSurcharge && isRuralArea)
            {
                calculatedCost += rule.RuralAreaSurchargeAmount;
            }

            return calculatedCost;
        }

        private decimal GetTierValue(string tierUnit, decimal applicableWeightKg, decimal applicableVolumeCbm, int totalItemCount)
        {
            return tierUnit switch
            {
                "Kg" => applicableWeightKg,
                "Cbm" => applicableVolumeCbm,
                "Item" => totalItemCount,
                _ => 0m,
            };
        }
    }
}
