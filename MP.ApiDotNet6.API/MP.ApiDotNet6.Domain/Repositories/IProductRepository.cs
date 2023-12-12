using MP.ApiDotNet6.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);

        Task<ICollection<Product>> GetProductsAsync();

        Task<Product> CreateAsync(Product product);

        Task EditAsync(Product product);

        Task DeleteAsync(Product product);

        Task<int> GetIdByCodErpAsync(string codErp);
    }
}
