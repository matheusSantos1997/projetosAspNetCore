using crudDapperEfCore.Models;
using FluentValidation;

namespace crudDapperEfCore.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.NomeCliente).NotNull().WithMessage("required client name")
                                       .NotEmpty().WithMessage("required client name")
                                       .MaximumLength(50).WithMessage("Use minimum 50 characters");

            RuleFor(x => x.Email).NotNull().WithMessage("required Email")
                                 .NotEmpty().WithMessage("required Email")
                                 .MaximumLength(50).WithMessage("Use minimum 50 characters")
                                 .EmailAddress().WithMessage("Invalid Email");

            RuleFor(x => x.Endereco).NotNull().WithMessage("required Address")
                                 .NotEmpty().WithMessage("required Address")
                                 .MaximumLength(40).WithMessage("Use minimum 40 characters");

            RuleFor(x => x.Produtos).NotNull().WithMessage("required Produtos")
                                    .NotEmpty().WithMessage("required Produtos");

        }
    }
}
