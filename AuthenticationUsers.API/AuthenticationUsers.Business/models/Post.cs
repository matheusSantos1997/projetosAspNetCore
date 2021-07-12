using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AuthenticationUsers.Business.models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }

        [Column("title", TypeName = "varchar(20)")]
        public string Title { get; set; }

        [Column("contents", TypeName = "varchar(100)")]
        public string Contents { get; set; }

        [Column("createdAt")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

     /*   [ForeignKey("UserAdminId")]
        public long? UserRefId { get; set; }

        public User User { get; set; } */
      
    }
}
