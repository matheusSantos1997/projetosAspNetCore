using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string NomeCliente { get; set; }

        [Column(TypeName = "varchar(90)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Endereco { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}
