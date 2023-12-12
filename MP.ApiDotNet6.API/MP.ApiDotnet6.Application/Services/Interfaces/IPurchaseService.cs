using MP.ApiDotnet6.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Services.Interfaces
{
    public interface IPurchaseService
    {
        Task<ResultService<PurchaseDto>> CreateAsync(PurchaseDto purchaseDto);

        Task<ResultService<PurchaseDetailDto>> GetByIdAsync(int id);

        Task<ResultService<ICollection<PurchaseDetailDto>>> GetAsync();

        Task<ResultService<PurchaseDto>> UpdateAsync(PurchaseDto purchaseDto);

        Task<ResultService> RemoveAsync(int id);
    }
}
