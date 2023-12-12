using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.Models;
using MP.ApiDotNet6.Domain.Repositories;
using MP.ApiDotNet6.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _db.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(Product product)
        {
            _db.Remove(product);
            await _db!.SaveChangesAsync();
        }

        public async Task EditAsync(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var query = await _db.Product.FirstOrDefaultAsync(p => p.Id == id);
            return query!;
        }

        public async Task<int> GetIdByCodErpAsync(string codErp)
        {
            return (await _db.Product.FirstOrDefaultAsync(x => x.CodErp == codErp))?.Id ?? 0;
        }

        public async Task<ICollection<Product>> GetProductsAsync()
        {
            var query = await _db.Product.OrderBy(x => x.Id).ToListAsync();
            return query;
        }
    }
}
