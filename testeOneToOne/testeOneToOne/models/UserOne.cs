using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testeOneToOne.models
{
    public class UserOne
    {
        [Key]
        public int idUserOne { get; set; }

        [Column("name", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }

        public UserTwo UserTwo { get; set; }

       

        
    }
}
