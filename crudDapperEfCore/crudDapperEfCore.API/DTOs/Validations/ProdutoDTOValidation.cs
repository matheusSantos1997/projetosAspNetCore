using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudDapperEfCore.API.DTOs.Produto;
using FluentValidation;

namespace crudDapperEfCore.API.DTOs.Validations
{
    public class ProdutoDTOValidation : AbstractValidator<CreateNewProdutoDTO>
    {
        public ProdutoDTOValidation()
        {
            RuleFor(x => x.NomeProduto).NotNull().WithMessage("Nome do produto é obrigatório")
                                       .NotEmpty().WithMessage("Nome do produto é obrigatório")
                                       .MaximumLength(50).WithMessage("Nome do produto deve ter no minimo 50 caracteres");

            RuleFor(x => x.TipoProduto).NotNull().WithMessage("Tipo do produto é obrigatório")
                                       .NotEmpty().WithMessage("Tipo do produto é obrigatório")
                                       .MaximumLength(50).WithMessage("Nome do produto deve ter no minimo 50 caracteres");

            RuleFor(x => x.Preco).NotNull().WithMessage("Preco do produto e obrigatorio")
                                 .NotEmpty().WithMessage("Preco do produto e obrigatorio");
        }
    }
}