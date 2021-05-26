using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Identity
{
    // classe de papéis (adm, usuario, etc)
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}