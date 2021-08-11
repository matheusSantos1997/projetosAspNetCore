using ControleFinanceiro.BLL.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                   .NotNull().WithMessage("Preencha o nome") // nao pode ser nulo
                   .NotEmpty().WithMessage("Preencha o nome") // nao pode ser vazio
                   .MinimumLength(4).WithMessage("Use mais caracteres") // no minimo 6 caracteres
                   .MaximumLength(50).WithMessage("Use menos que 50 caracteres"); // no maximo 50 caracteres

            RuleFor(c => c.Icone)
                   .NotNull().WithMessage("Preencha o icone")
                   .NotEmpty().WithMessage("Preencha o icone")
                   .MinimumLength(1).WithMessage("Use mais caracteres")
                   .MaximumLength(30).WithMessage("Use menos que 50 caracteres");

            RuleFor(c => c.TipoId)
                   .NotNull().WithMessage("Escolha o tipo da categoria")
                   .NotEmpty().WithMessage("Escolha o tipo da categoria");
        }
    }
}
