using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Dtos.Validations
{
    public class PurchaseDTOValidator : AbstractValidator<PurchaseDto>
    {
        public PurchaseDTOValidator()
        {
            RuleFor(x => x.CodErp).NotEmpty()
                                  .NotNull()
                                  .WithMessage("CodErp deve ser informado!");

            RuleFor(x => x.Document).NotEmpty()
                                    .NotNull()
                                    .WithMessage("Document deve ser informado!");


        }
    }
}
