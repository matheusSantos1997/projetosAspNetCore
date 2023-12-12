using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Dtos.Validations
{
    public class PersonDTOValidator : AbstractValidator<PersonDto>
    {
        public PersonDTOValidator()
        {
            RuleFor(x => x.Document).NotEmpty()
                                    .NotNull()
                                    .WithMessage("Documento Deve Ser informado!");

            RuleFor(x => x.Name).NotEmpty()
                                .NotNull()
                                .WithMessage("Nome deve ser informado!");

            RuleFor(x => x.Phone).NotEmpty()
                                 .NotNull()
                                 .WithMessage("Telefone deve ser informado!");
        }
    }
}
