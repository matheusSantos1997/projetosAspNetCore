using AuthenticationUsers.Data.Context;
using AuthenticationUsers.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUsers.Data.Repository
{
    public class GenericRepository : IGenericRepository
    {
        private readonly AuthenticationDbContext _context;

        public GenericRepository(AuthenticationDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool results = await _context.SaveChangesAsync() > 0;
            return results;
        }
    }
}
