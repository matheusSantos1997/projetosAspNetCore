using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        [Column(TypeName = "nvarchar(150)")] // data notation
        public string FullName { get; set; } // coluna opcional que nao existe no Identity
        public List<UserRole> UserRoles { get; set; }
    }
}