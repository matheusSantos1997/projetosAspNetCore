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
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly ApplicationDbContext _db;

        public PurchaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Purchase> CreateAsync(Purchase purchase)
        {
            _db.Add(purchase);
            await _db.SaveChangesAsync();
            return purchase;
        }

        public async Task DeleteAsync(Purchase purchase)
        {
            _db.Remove(purchase);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Purchase purchase)
        {
            _db.Update(purchase);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Purchase>> GetAllAsync()
        {
            return await _db.Purchase.Include(x => x.Product)
                                     .Include(x => x.Person)
                                     .ToListAsync();
        }

        public async Task<Purchase> GetByIdAsync(int id)
        {
            var purchase = await _db.Purchase
                            .Include(x => x.Product)
                            .Include(x => x.Person)
                            .FirstOrDefaultAsync(x => x.Id == id);

            return purchase!;
        }

        public async Task<ICollection<Purchase>> GetByPersonIdAsync(int personId)
        {
            return await _db.Purchase
                            .Include(x => x.Product)
                            .Include(x => x.Person)
                            .Where(x => x.PersonId == personId).ToListAsync();
        }

        public async Task<ICollection<Purchase>> GetByProductIdAsync(int productId)
        {
            return await _db.Purchase
                            .Include(x => x.Product)
                            .Include(x => x.Person)
                            .Where(x => x.ProductId == productId).ToListAsync();
        }
    }
}
