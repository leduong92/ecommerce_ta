using System.Security.Cryptography;
using System.Text;

namespace eCommerce.Shared.Common
{
    public static class ApiKeyGenerator
    {
        private const string SecretKey = "MySuperSecretKey*123";

        public static string GenerateApiKey(DateTime date)
        {
            string dateString = date.ToUniversalTime().ToString("ddMMyyyy");
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(SecretKey)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dateString));
                return Convert.ToBase64String(hash);
            }
        }

        public static bool ValidateApiKey(DateTime date, string providedApiKey)
        {
            string expectedApiKey = GenerateApiKey(date);
            var result = expectedApiKey == providedApiKey;
            return result;
        }
    }
}
