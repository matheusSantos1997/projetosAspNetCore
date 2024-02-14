using System.ComponentModel.DataAnnotations;

namespace ConsultaExemplo.Models
{
#nullable disable
    public class People
    {
       #nullable disable
        [Key]
        public int IdPeople { get; set; }

        [Required(ErrorMessage = "Name is resquired")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        public IList<Car> Cars { get; set; }
    }
   
}
