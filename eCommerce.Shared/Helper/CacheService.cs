using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace eCommerce.Shared
{
    public interface ICacheService
    {
        Task<T> GetOrSetAsync<T>(string cacheKeyPrefix, TimeSpan? duration, Func<Task<T>> factory);
        Task<T> GetOrCreateAsync<T>(string key, Func<MemoryCacheEntryOptions, Task<T>> factory);
        Task RemoveAsync(string cacheKey);
    }
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<CacheService> _logger;

        public CacheService(IMemoryCache cache
            , ILogger<CacheService> logger)
        {
            _cache = cache;
            _logger = logger;
        }
        public async Task<T> GetOrCreateAsync<T>(string key, Func<MemoryCacheEntryOptions, Task<T>> factory)
        {
            if (_cache.TryGetValue(key, out T cachedValue))
            {
                return cachedValue;
            }

            var options = new MemoryCacheEntryOptions();
            var value = await factory(options);
            _cache.Set(key, value, options);
            return value;
        }
        public async Task<T> GetOrSetAsync<T>(string cacheKeyPrefix, TimeSpan? duration, Func<Task<T>> factory)
        {
            try
            {
                var fullKey = $"{cacheKeyPrefix}";
                if (_cache.TryGetValue(fullKey, out T cached))
                {
                    _logger.LogInformation("Cache [HIT] for key: {FullKey}", fullKey);
                    return cached;
                }
                var result = await factory();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = duration ?? TimeSpan.FromHours(2)
                };
                _cache.Set(fullKey, result, cacheOptions);
                _logger.LogInformation("Cached [SUCCESS] for key: {FullKey}", fullKey);
                return result;
            }
            catch (JsonException ex)
            {
                _logger.LogInformation(ex, "Failed to serialize keyParams for cache key: {CacheKeyPrefix}", cacheKeyPrefix);
                throw new InvalidOperationException("Failed to serialize cache key parameters", ex);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error in GetOrSetAsync for cache key: {CacheKeyPrefix}", cacheKeyPrefix);
                throw;
            }
        }

        public Task RemoveAsync(string cacheKey)
        {
            _cache.Remove(cacheKey);
            return Task.CompletedTask;
        }
    }
}
