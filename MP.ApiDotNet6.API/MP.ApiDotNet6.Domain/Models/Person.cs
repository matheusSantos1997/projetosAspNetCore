using MP.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Models
{
    public sealed class Person // sealed onde nao permitirá que a classe seja herdada
    {
        public int Id { get; private set; } // private set faz com que nao seja acessivel os atributos fora da classe
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Person(string document, string name, string phone)
        {
              Validation(document, name, phone);
              Purchases = new List<Purchase>();
        }

        public Person(int id, string document, string name, string phone) 
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero");
            Id = id;
            Validation(document, name, phone);
            Purchases = new List<Purchase>();
        }

        private void Validation(string document, string name, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");

            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento dever ser informado!");

            DomainValidationException.When(string.IsNullOrEmpty(phone), "Celular deve ser informado!");

            Name = name;
            Document = document;
            Phone = phone;
        }
    }
}
