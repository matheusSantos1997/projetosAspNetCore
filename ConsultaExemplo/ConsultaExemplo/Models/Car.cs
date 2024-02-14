using System.ComponentModel.DataAnnotations;

namespace ConsultaExemplo.Models
{
#nullable disable
    public class Car
    {
        [Key]
        public int IdCar { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Mark is required")]
        public string Mark { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        public int? PeopleId { get; set; }

        public People People { get; set; }
    }
}
