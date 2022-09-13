using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProceduresStorage.API.Context;
using ProceduresStorage.API.Models;

namespace ProceduresStorage.API.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;

        public ProdutoRepository(DataContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add(Produto produto)
        {
            _context.Add(produto);
        }

        public void Delete(Produto produto)
        { 
            _context.Remove(produto);
        }

        public async Task<Produto> ListarPorId(int id)
        {
            SqlParameter param = new SqlParameter("@id", id);

            var status = await _context.Set<Produto>()
                    .FromSqlRaw("exec consultar @id", param).AsNoTracking()
                    .AsAsyncEnumerable()
                    .FirstOrDefaultAsync();
            return status;
        }

        public async Task<List<Produto>> ListarTodos()
        {
            var sql = await _context.Produtos.FromSqlRaw("exec consultarTodos").AsNoTracking().ToListAsync();

            return sql;
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool results = await _context.SaveChangesAsync() > 0;
            return results;
        }

        public void Update(Produto produto)
        {
            _context.Update(produto);
        }
    }
}