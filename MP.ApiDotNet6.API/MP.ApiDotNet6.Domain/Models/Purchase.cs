using MP.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MP.ApiDotNet6.Domain.Models
{
    public class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }

        public Purchase(int productId, int personId)
        {
            Validation(productId, personId);
        }

        public Purchase(int id, int productId, int personId)
        {
            DomainValidationException.When(id <= 0, "Id deve ser informado!");
            Id = id;
            Validation(productId, personId);
        }

        public void Edit(int id, int productId, int personId)
        {
            DomainValidationException.When(id <= 0, "Id deve ser informado!");
            Id = id;
            Validation(productId, personId);
        }

        private void Validation(int productId, int personId)
        {
            DomainValidationException.When(productId <= 0, "Id produto deve ser informado!");

            DomainValidationException.When(personId <= 0, "Id pessoa deve ser informado!");

            // DomainValidationException.When(!date.HasValue, "data da compra deve ser informada!");

            PersonId = personId;
            ProductId = productId;
            Date = DateTime.Now;
        }
    }
}
