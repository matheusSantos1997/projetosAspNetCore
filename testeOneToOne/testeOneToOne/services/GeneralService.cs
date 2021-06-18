using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.context;
using testeOneToOne.interfaces;

namespace testeOneToOne.services
{
    public class GeneralService : IGeneralUsers
    {
        private readonly UserContext _context;

        public GeneralService(UserContext context)
        {
            _context = context;
        }

        public void AddUser<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void DeleteUser<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveUser()
        {
            bool result = await _context.SaveChangesAsync() > 0;
            return (result);
        }

        public void UpdateUser<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
