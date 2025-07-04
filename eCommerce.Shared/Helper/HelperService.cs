using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace ECommerce.Shared
{
    public static class HelperService
    {
        public static string EncryptPassword(string password)
        {
            string strEncodePwd;
            using (SHA256 ahash = SHA256.Create())
            {
                ahash.Initialize();
                byte[] rawBytes = ASCIIEncoding.ASCII.GetBytes(password);
                byte[] hash = ahash.ComputeHash(rawBytes);

                StringBuilder sb = new StringBuilder(hash.Length * 2 + (hash.Length / 8));

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(BitConverter.ToString(hash, i, 1));
                }

                strEncodePwd = sb.ToString().TrimEnd(new char[] { ' ' });
                return strEncodePwd;
            }
        }
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static bool ValidateIPv4(string ipString)
        {
            if (ipString.Count(c => c == '.') != 3) return false;
            IPAddress address;
            return IPAddress.TryParse(ipString, out address);
        }
        public static List<string> ConvertStringToList(string strList)
        {
            List<string> rtn = new List<string>();
            try
            {
                if (!String.IsNullOrEmpty(strList))
                {
                    var splirStr = strList.Split(',').ToList();
                    foreach (var item in splirStr)
                    {
                        var cleanStr = CleanString(item.Trim());
                        rtn.Add(item.Trim());
                    }
                    var removedList = rtn.GroupBy(g => g)
                            .Select(g => g.FirstOrDefault()).ToList();
                    return removedList;
                }
                return rtn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string CleanString(string str)
        {
            return str.Replace(".", "").Replace("%20", "_").Replace("&", "and").Replace("'", "").Replace(" ", " ").Replace(",", "").Replace("é", "e").ToLower();
        }
     
        public static string CmToInch(double cm)
        {
            double dblInch = cm / 2.54;
            return FormatInches(dblInch.ToString());
        }
        public static string CmToInch(decimal? cm)
        {
            double dblInch = Convert.ToDouble(cm) / 2.54;
            return FormatInches2(dblInch);
        }
        public static string FormatInteger(decimal? val)
        {
            if (val.HasValue)
            {
                return val.Value.ToString("N0");
            }
            return "";
        }
        public static string FormatInches2(double value)
        {
            string strReturn = string.Empty;
            if (value > 0)
            {
                string valueStr = value.ToString();
                if (valueStr.IndexOf('.') > 0)
                {
                    strReturn = valueStr.Substring(0, valueStr.IndexOf('.'));
                    double dblCheck = double.Parse(valueStr.Substring(valueStr.IndexOf('.'), valueStr.Length - valueStr.IndexOf('.')));
                    if (dblCheck >= 0.125 && dblCheck < 0.375)
                        strReturn += "&frac14;";
                    else if (dblCheck >= 0.375 && dblCheck < 0.625)
                        strReturn += "&frac12;";
                    else if (dblCheck >= 0.625 && dblCheck < 0.875)
                        strReturn += "&frac34;";
                    else if (dblCheck >= 0.875)
                        strReturn = (int.Parse(strReturn) + 1).ToString();
                }
                else
                {
                    strReturn = valueStr;
                }
            }
            return strReturn;
        }
        public static string GetClientIp(HttpContext context)
        {
            if (context == null)
            {
                return null;
            }
            string ip = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(ip))
            {
                ip = context.Connection.RemoteIpAddress?.ToString();
            }
            return ip;
        }
        public static string FormatInches(string strIn)
        {
            string strReturn;
            if (strIn.IndexOf('.') > 0)
            {
                strReturn = strIn.Substring(0, strIn.IndexOf('.'));
                double dblCheck = double.Parse(strIn.Substring(strIn.IndexOf('.'), strIn.Length - strIn.IndexOf('.')));
                if (dblCheck >= 0.125 && dblCheck < 0.375)
                    strReturn += "&frac14;";
                else if (dblCheck >= 0.375 && dblCheck < 0.625)
                    strReturn += "&frac12;";
                else if (dblCheck >= 0.625 && dblCheck < 0.875)
                    strReturn += "&frac34;";
                else if (dblCheck >= 0.875)
                    strReturn = (int.Parse(strReturn) + 1).ToString();
            }
            else
                strReturn = strIn;

            return strReturn;
        }
        public static async Task<bool> CheckFilesExistsAsync(string url)
        {
            bool rtn = false;
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 5000; //set the timeout to 1 seconds to keep the user from waiting too long for the page to load
                request.Method = "HEAD"; //Get only the header information -- no need to download any content
                System.Net.HttpWebResponse res = (System.Net.HttpWebResponse)await request.GetResponseAsync();
                rtn = res.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception )
            {
                rtn = false;
            }
            return rtn;
        }
        public static string ReturnSirvLinkBySku(string sku)
        {
            string rtn = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(sku))
                {
                    rtn = SD.SirvProductFolderUrl + sku.Substring(0, 3) + "/" + sku + "_main_1.jpg";
                }
            }
            catch (Exception ex)
            {
                rtn = string.Empty;
            }
            return rtn;
        }
        public static int ParseYear(string introductionDate)
        {
            if (string.IsNullOrEmpty(introductionDate)) return 0;
            var parts = introductionDate.Split('-');
            if (parts.Length < 2) return 0;

            if (int.TryParse(parts[1], out int yy))
            {
                return yy;
            }

            return 0;
        }
        public static string GetDimensionsInch(double width, double depth, double height)
		{
			return $"W {HelperService.CmToInch(width)} x D {HelperService.CmToInch(depth)}" + (!string.IsNullOrEmpty(HelperService.CmToInch(height)) ? $" x H {HelperService.CmToInch(height)}" : "");
		}

		public static string GetDimensionsCM(double? width, double? depth, double? height)
		{
			return $"W {Convert.ToDouble(width)} x D {Convert.ToDouble(depth)}" + (Convert.ToDouble(height) > 0 ? $" x H {Convert.ToDouble(height)}" : "");
		}
        //public Region? GetNearestRegion(double userLat, double userLng)
        //{
        //    var regions = _context.Regions.ToList();

        //    Region? closestRegion = null;
        //    double minDistance = double.MaxValue;

        //    foreach (var region in regions)
        //    {
        //        double distance = GetDistance(userLat, userLng, region.Latitude, region.Longitude);
        //        if (distance < minDistance)
        //        {
        //            minDistance = distance;
        //            closestRegion = region;
        //        }
        //    }

        //    return closestRegion;
        //}
        public static double GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // km
            double dLat = (lat2 - lat1) * Math.PI / 180;
            double dLon = (lon2 - lon1) * Math.PI / 180;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

    }
}
