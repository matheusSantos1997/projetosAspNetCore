using crudDapperEfCore.API.DTOs.Cliente;
using FluentValidation;

namespace crudDapperEfCore.API.DTOs.Validations
{
    public class ClienteDTOValidation : AbstractValidator<CreateNewClienteDTO>
    {
        public ClienteDTOValidation()
        {
            RuleFor(x => x.NomeCliente)
            .NotNull().WithMessage("Nome do cliente é obrigatório")
            .NotEmpty().WithMessage("Nome do cliente é obrigatório")
            .MaximumLength(50).WithMessage("Nome do cliente deve ter no máximo 50 caracteres");

        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email é obrigatório")
            .NotEmpty().WithMessage("Email é obrigatório")
            .EmailAddress().WithMessage("Email inválido")
            .MaximumLength(50).WithMessage("Email deve ter no máximo 50 caracteres");

        RuleFor(x => x.Endereco)
            .NotNull().WithMessage("Endereço é obrigatório")
            .NotEmpty().WithMessage("Endereço é obrigatório")
            .MaximumLength(40).WithMessage("Endereço deve ter no máximo 40 caracteres");

        RuleFor(x => x.Produtos)
            .NotNull().WithMessage("Produtos sao obrigatórios")
            .NotEmpty().WithMessage("A lista de produtos não pode estar vazia")
            .Must(produtos => produtos.Count > 0).WithMessage("A lista de produtos não pode estar vazia")
            .ForEach(produto => produto.SetValidator(new ProdutoDTOValidation())); // Valida cada item na lista
        }
    }
}