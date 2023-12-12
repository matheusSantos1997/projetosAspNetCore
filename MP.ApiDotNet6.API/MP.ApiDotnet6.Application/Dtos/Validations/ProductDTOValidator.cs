using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Dtos.Validations
{
    public class ProductDTOValidator : AbstractValidator<ProductDto>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.CodErp).NotEmpty()
                                  .NotNull()
                                  .WithMessage("CodErp deve ser informado!");

            RuleFor(x => x.Name).NotEmpty()
                                .NotNull()
                                .WithMessage("Name deve ser informado!");

            RuleFor(x => x.Price).GreaterThan(0)
                                 .WithMessage("Price deve ser maior que zero!");
        }
    }
}
