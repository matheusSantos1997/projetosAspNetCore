using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace AuthenticationUsers.Business.models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Column("name", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column("phone", TypeName = "varchar(10)")]
        public string Phone { get; set; }

        [Column("role", TypeName = "varchar(50)")]
        public string Role { get; set; }

        [Column("password", TypeName = "varchar(255)")]
        public string Password { get; set; }

        [Column("createdAt")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

       // public IEnumerable<Post> Posts { get; set; }
    }
}
