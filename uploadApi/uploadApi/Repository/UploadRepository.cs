using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using uploadApi.Context;
using uploadApi.Interfaces;
using uploadApi.Models;

namespace uploadApi.Repository
{
    public class UploadRepository : IUploadRepository
    {
        private readonly ArquivoContext _context;
        public UploadRepository(ArquivoContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public List<Arquivos> GetAllArquivos()
        {
            IQueryable<Arquivos> query = _context.Arquivos;

            return query.ToList();
        }

        public Arquivos GetByIdArquivo(int id)
        {
            IQueryable<Arquivos> query = _context.Arquivos;

            query = query.Where(a => a.Id == id);

            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            bool results = _context.SaveChanges() > 0;
            return results;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}