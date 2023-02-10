using crudDapperEfCore.Models;
using FluentValidation;

namespace crudDapperEfCore.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.NomeProduto).NotNull().WithMessage("Product Name is Required")
                                       .NotEmpty().WithMessage("Product Name is Required")
                                       .MaximumLength(50).WithMessage("Use minimum 50 characters");

            RuleFor(x => x.TipoProduto).NotNull().WithMessage("Product Type is Required")
                                       .NotEmpty().WithMessage("Product Type is Required")
                                       .MaximumLength(50).WithMessage("Use minimum 50 characters");

            RuleFor(x => x.Preco).NotNull().WithMessage("Product Price is Required")
                                 .NotEmpty().WithMessage("Product Price is Required");
        }
    }
}
