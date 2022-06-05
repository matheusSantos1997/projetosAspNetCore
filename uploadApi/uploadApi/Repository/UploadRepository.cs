using Microsoft.EntityFrameworkCore;
using uploadApi.Context;
using uploadApi.Interfaces;

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

        public bool SaveChanges()
        {
            bool results = _context.SaveChanges() > 0;
            return results;
        }
    }
}