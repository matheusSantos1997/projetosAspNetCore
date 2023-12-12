using MP.ApiDotnet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ResultService<ProductDto>> CreateAsync(ProductDto productDto);

        Task<ResultService<ICollection<ProductDto>>> GetAsync();

        Task<ResultService<ProductDto>> GetByIdAsync(int id);

        Task<ResultService> UpdateAsync(ProductDto productDto);

        Task<ResultService> RemoveAsync(int id);
    }
}
