namespace eCommerce.Shared.Common
{
    public class JwtDto
    {
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public string? AccountNumber { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserType { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? CountryFullName { get; set; }
        public bool IsShowInStock { get; set; }
        public string? ExclusivityGroupId { get; set; }
        public string? RequestIpAddress { get; set; }
        public string? ResponseIpAddress { get; set; }
    }
}