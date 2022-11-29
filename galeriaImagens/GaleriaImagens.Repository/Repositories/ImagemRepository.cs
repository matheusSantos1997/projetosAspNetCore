using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Context;
using GaleriaImagens.Repository.Interfaces;
using GaleriaImagens.Repository.Pagination;
using Microsoft.EntityFrameworkCore;

namespace GaleriaImagens.Repository.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        private readonly DataContext _context;

        public ImagemRepository(DataContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<PageList<Imagem>> GetAllImagens(PageParams pageParams)
        {
            IQueryable<Imagem> query = _context.Imagens.AsNoTracking();


            query = query.Include(i => i.Usuario).OrderBy(i => i.Id);

            return await PageList<Imagem>.CreateAsync(query, pageParams.PageNumber, pageParams.pageSize);
        }

        public async Task<Imagem> GetImagemById(long id)
        {
            IQueryable<Imagem> query = _context.Imagens.AsNoTracking();

            query = query.Include(i => i.Usuario).Where(i => i.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<PageList<Imagem>> GetImagensUsuarioId(long usuarioId, PageParams pageParams)
        {
            IQueryable<Imagem> query = _context.Imagens.AsNoTracking();
            
            query = query.Include(i => i.Usuario).Where(i => i.UsuarioId == usuarioId).OrderBy(i => i.Id);

            return await PageList<Imagem>.CreateAsync(query, pageParams.PageNumber, pageParams.pageSize);
        }
    }
}