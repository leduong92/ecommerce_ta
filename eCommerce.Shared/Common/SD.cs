namespace eCommerce.Shared.Common
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public static string LocalizationAPIBase { get; set; }
        public static string RegionAPIBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        public const string SirvProductFolderUrl = "https://theodorealexander.sirv.com/ProductphotoCrop/";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE,
        }
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}
