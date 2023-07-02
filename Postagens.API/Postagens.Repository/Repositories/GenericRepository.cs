using Postagens.Repository.Data;
using Postagens.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly DataAccess _context;

        public GenericRepository(DataAccess context)
        {
            _context = context;
        }

        public void Adicionar<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Atualizar<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Excluir<T>(T entity) where T : class
        {
            _context.Remove(entity);   
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
    }
}
