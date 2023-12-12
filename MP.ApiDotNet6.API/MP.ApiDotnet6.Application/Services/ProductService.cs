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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<ProductDto>> CreateAsync(ProductDto productDto)
        {
            if (productDto == null) return ResultService.Fail<ProductDto>("Objeto deve ser informado!");

            var result = new ProductDTOValidator().Validate(productDto);

            if (!result.IsValid)
            {
                return ResultService.RequestError<ProductDto>("problemas na validação!", result);
            }

            var product = _mapper.Map<Product>(productDto);
            var data = await _productRepository.CreateAsync(product);

            return ResultService.Ok<ProductDto>(_mapper.Map<ProductDto>(data));
        }

        public async Task<ResultService<ICollection<ProductDto>>> GetAsync()
        {
            var products = await _productRepository.GetProductsAsync();

            return ResultService.Ok<ICollection<ProductDto>>(_mapper.Map<ICollection<ProductDto>>(products));
        }

        public async Task<ResultService<ProductDto>> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null) return ResultService.Fail<ProductDto>("Produto não encontrado!");

            return ResultService.Ok<ProductDto>(_mapper.Map<ProductDto>(product));

        }

        public async Task<ResultService> RemoveAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null) return ResultService.Fail("Produto não encontrado!");

            await _productRepository.DeleteAsync(product);

            return ResultService.Ok($"o Produto do id {id} foi deletado com sucesso!");
        }

        public async Task<ResultService> UpdateAsync(ProductDto productDto)
        {
            if(productDto == null) return ResultService.Fail("Objeto deve ser informado!");

            var validation = new ProductDTOValidator().Validate(productDto);

            if (!validation.IsValid) return ResultService.RequestError("Problemas com a validação dos campos", validation);

            var product = await _productRepository.GetByIdAsync(productDto.Id);

            if (product == null) return ResultService.Fail("Produto não encontrado!");

            product = _mapper.Map<ProductDto, Product>(productDto, product);

            await _productRepository.EditAsync(product);

            return ResultService.Ok("Produto editado com sucesso!");
        }
    }
}
