using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Repositories
{
    public class CartaoRepositorio : RepositorioGenerico<Cartao>, ICartaoRepositorio
    {
        private readonly Contexto _contexto;

        public CartaoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<Cartao> FiltrarCartoes(string numeroCartao)
        {
            try
            {
                return _contexto.Cartoes.Where(c => c.Numero.ToLower().Contains(numeroCartao.ToLower()));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Cartao> PegarCartoesPeloUsuarioId(string usuarioId)
        {
            try
            {
                return _contexto.Cartoes.Where(c => c.usuarioId == usuarioId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> PegarQuantidadeCartoesPeloUsuarioId(string usuarioId)
        {
            try
            {
                return await _contexto.Cartoes.CountAsync(c => c.usuarioId == usuarioId);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
