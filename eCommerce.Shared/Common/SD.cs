namespace eCommerce.Shared.Common
{
    public class SD
    {
        public static string ApiBaseUrl { get; set; }
        public const string AnonymousId = "AnonymousId";

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
