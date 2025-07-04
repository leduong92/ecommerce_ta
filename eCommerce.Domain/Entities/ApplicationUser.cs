
using Microsoft.AspNetCore.Identity;

namespace eCommerce.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public int RegionId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AccountNumber { get; set; }
        public DateTime Dob { get; set; }
    }
    public class ApplicationRole : IdentityRole<Guid> { }

    public class ApplicationUserClaim : IdentityUserClaim<Guid> { }

    public class ApplicationUserRole : IdentityUserRole<Guid> { }

    public class ApplicationUserLogin : IdentityUserLogin<Guid> { }

    public class ApplicationUserToken : IdentityUserToken<Guid> { }

    public class ApplicationRoleClaim : IdentityRoleClaim<Guid> { }
}
