using ControleFinanceiro.BLL.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class DespesaValidator : AbstractValidator<Despesa>
    {
        public DespesaValidator()
        {
            RuleFor(d => d.CartaoId)
                  .NotEmpty().WithMessage("Escolha o cartão")
                  .NotNull().WithMessage("Escolha o cartão");

            RuleFor(d => d.Descricao)
                  .NotEmpty().WithMessage("Preencha a descrição")
                  .NotNull().WithMessage("Preencha a descrição")
                  .MinimumLength(1).WithMessage("Use mais caracteres")
                  .MaximumLength(50).WithMessage("Use menos caracteres");

            RuleFor(d => d.valor)
                  .NotNull().WithMessage("Escolha o valor")
                  .NotEmpty().WithMessage("Escolha o valor")
                  .InclusiveBetween(0, double.MaxValue).WithMessage("valor inválido"); // impede que o usuário digite valores negativos

            RuleFor(d => d.MesId)
                  .NotEmpty().WithMessage("Escolha o mês")
                  .NotNull().WithMessage("Escolha o mês");

            RuleFor(d => d.Ano)
                  .NotNull().WithMessage("Escolha o valor")
                  .NotEmpty().WithMessage("Escolha o valor")
                  .InclusiveBetween(2016, int.MaxValue).WithMessage("valor inválido"); // impede que o usuário digite valores negativos

        }
    }
}
