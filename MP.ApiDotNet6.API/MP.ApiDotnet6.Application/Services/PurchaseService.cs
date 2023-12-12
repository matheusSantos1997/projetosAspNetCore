using AutoMapper;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotnet6.Application.Dtos.Validations;
using MP.ApiDotnet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.Models;
using MP.ApiDotNet6.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IProductRepository _productRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PurchaseService(IProductRepository productRepository, 
                               IPersonRepository personRepository, 
                               IPurchaseRepository purchaseRepository, 
                               IMapper mapper, 
                               IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _personRepository = personRepository;
            _purchaseRepository = purchaseRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultService<PurchaseDto>> CreateAsync(PurchaseDto purchaseDto)
        {
            if (purchaseDto == null) return ResultService.Fail<PurchaseDto>("Objeto deve ser informado!");

            var validate = new PurchaseDTOValidator().Validate(purchaseDto);

            if(!validate.IsValid) 
            {
                return ResultService.RequestError<PurchaseDto>("Problemas de validação", validate);
            }

            try
            {
                await _unitOfWork.BeginTransaction();
                var productId = await _productRepository.GetIdByCodErpAsync(purchaseDto.CodErp);

                if (productId == 0)
                {
                    var product = new Product(purchaseDto.ProductName ?? "", purchaseDto.CodErp, purchaseDto.price ?? 0);
                    await _productRepository.CreateAsync(product);
                    productId = product.Id;
                }

                var personId = await _personRepository.GetIdByDocumentAsync(purchaseDto.Document);

                var purchase = new Purchase(productId, personId);

                var data = await _purchaseRepository.CreateAsync(purchase);
                purchaseDto.Id = data.Id;

                await _unitOfWork.Commit();

                return ResultService.Ok<PurchaseDto>(purchaseDto);
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollBack();
                return ResultService.Fail<PurchaseDto>($"Erro: {ex.Message}");
            }
            
        }

        public async Task<ResultService<ICollection<PurchaseDetailDto>>> GetAsync()
        {
            var purchases = await _purchaseRepository.GetAllAsync();
            return ResultService.Ok(_mapper.Map<ICollection<PurchaseDetailDto>>(purchases));
;        }

        public async Task<ResultService<PurchaseDetailDto>> GetByIdAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);

            if (purchase == null) return ResultService.Fail<PurchaseDetailDto>("Compra não encontrada!");

            return ResultService.Ok(_mapper.Map<PurchaseDetailDto>(purchase));
        }

        public async Task<ResultService> RemoveAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);

            if (purchase == null) return ResultService.Fail("Compra não encontrada!");

            await _purchaseRepository.DeleteAsync(purchase);

            return ResultService.Ok($"Compra: {id} deletada com sucesso!");
        }

        public async Task<ResultService<PurchaseDto>> UpdateAsync(PurchaseDto purchaseDto)
        {
            if (purchaseDto == null) return ResultService.Fail<PurchaseDto>("Objeto deve ser informado!");

            var result = new PurchaseDTOValidator().Validate(purchaseDto);

            if (!result.IsValid) return ResultService.RequestError<PurchaseDto>("Problemas de validação", result);

            var purchase = await _purchaseRepository.GetByIdAsync(purchaseDto.Id);

            if (purchase == null) return ResultService.Fail<PurchaseDto>("Compra não encontrada!");

            var produtoId = await _productRepository.GetIdByCodErpAsync(purchaseDto.CodErp);
            var personId = await _personRepository.GetIdByDocumentAsync(purchaseDto.Document);

            purchase.Edit(purchase.Id, personId, produtoId);

            await _purchaseRepository.EditAsync(purchase);

            return ResultService.Ok(purchaseDto);
        }
    }
}
