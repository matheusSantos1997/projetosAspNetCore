using ControleFinanceiro.API.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class FuncoesValidator : AbstractValidator<FuncoesViewModel>
    {
        public FuncoesValidator()
        {
            RuleFor(f => f.Name)
                   .NotNull().WithMessage("Preencha a função")
                   .NotEmpty().WithMessage("Preencha a função")
                   .MinimumLength(1).WithMessage("Use mais caracteres")
                   .MaximumLength(50).WithMessage("Use menos caracteres");

            RuleFor(f => f.Descricao)
                   .NotNull().WithMessage("Preencha a descrição")
                   .NotEmpty().WithMessage("Preencha a descrição")
                   .MinimumLength(1).WithMessage("Use mais caractere")
                   .MaximumLength(50).WithMessage("Use menos caracteres");
        }
    }
}
