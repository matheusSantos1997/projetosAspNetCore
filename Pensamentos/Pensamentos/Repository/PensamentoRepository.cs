using Microsoft.EntityFrameworkCore;
using Pensamentos.Data;
using Pensamentos.Models;
using Pensamentos.Pagination;

namespace Pensamentos.Repository
{
    public class PensamentoRepository : IPensamentoRepository
    {
        private readonly DataContext _context;

        public PensamentoRepository(DataContext context)
        {
            _context= context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void AdicionarNovoPensamento(Pensamento pensamento)
        {
            try
            {
                _context.Add(pensamento);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarPensamento(int id, Pensamento pensamento)
        {
            try
            {
                var item = _context.Pensamentos.Where(p => p.Id == id).FirstOrDefault();
                pensamento.Id = item.Id;
           
                _context.Update(pensamento);
                _context.SaveChanges();              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirPensamento(Pensamento pensamento)
        {
            try
            {
                _context.Remove(pensamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pensamento PegarPensamentoPorId(int id)
        {
            try
            {
                IQueryable<Pensamento> query = _context.Pensamentos.Where(p => p.Id == id).AsNoTracking();

                return query.FirstOrDefault();

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PageList<Pensamento> PegarTodosPensamentos(PageParams pageParams)
        {
            try
            {
                IQueryable<Pensamento> query = _context.Pensamentos.AsNoTracking();

                return PageList<Pensamento>.Create(query, pageParams.PageNumber, pageParams.PageSize);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PageList<Pensamento> PegarTodosPensamentosFavoritos(PageParams pageParams)
        {
            try
            {
                IQueryable<Pensamento> query = _context.Pensamentos.AsNoTracking();

                query = query.Where(p => p.Favorito == true);

                return PageList<Pensamento>.Create(query, pageParams.PageNumber, pageParams.PageSize);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PageList<Pensamento> PegarTodosPensamentosPorAutoria(string conteudo, PageParams pageParams)
        {
            try
            {
                IQueryable<Pensamento> query = _context.Pensamentos.AsNoTracking();

                query = query.Where(p => p.Conteudo.ToLower().Contains(conteudo.ToLower()));

                return PageList<Pensamento>.Create(query, pageParams.PageNumber, pageParams.PageSize);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
