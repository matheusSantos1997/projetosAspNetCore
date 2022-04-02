using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using registerUsers.Data;
using registerUsers.Interfaces;
using registerUsers.Models;

namespace registerUsers.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;


        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<List<Usuario>> GetAll()
        {
            try
            {
                string sql = @"SELECT * FROM usuarios as u 
                               INNER JOIN contas as 
                               c ON u.IdUsuario = c.UsuarioId";
                   IQueryable<Usuario> query = _context.Usuarios
                     .FromSqlRaw(sql)
                     .Include(u => u.Contas)
                     .AsNoTracking();
            

            return await query.ToListAsync();             

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetById(int id)
        {
            try
            {
                string sql = @"SELECT * FROM usuarios as u 
                             INNER JOIN contas as c ON u.IdUsuario = c.UsuarioId 
                             WHERE IdUsuario = " + id;
                IQueryable<Usuario> query = _context.Usuarios
                                 .FromSqlRaw(sql)
                                 .Include(u => u.Contas)
                                 .AsNoTracking();

                return await query.FirstOrDefaultAsync(); 
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

        public async Task<List<Usuario>> GetByName(string name)
        {
            try
            {
                // string n = "'%" + name + "%'";
                // WHERE LOWER(Name) LIKE {n}
                string n = "'%" + name + "%'";
                string sql = @"SELECT * FROM usuarios as u INNER JOIN contas as c ON u.IdUsuario = c.UsuarioId WHERE LOWER(Name) LIKE " + n;
                IQueryable<Usuario> query = _context.Usuarios
                           .FromSqlRaw(sql)
                           .Include(u => u.Contas)
                           .AsNoTracking();

                return await query.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

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