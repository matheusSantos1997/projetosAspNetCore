using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string NomeProduto { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string TipoProduto { get; set; }

        public decimal Preco { get; set; }

        public long? ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
