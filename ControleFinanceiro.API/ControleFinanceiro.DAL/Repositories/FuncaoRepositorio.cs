using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Repositories
{
    public class FuncaoRepositorio : RepositorioGenerico<Funcao>, IFuncaoRepositorio
    {
        private readonly Contexto _contexto;
        private readonly RoleManager<Funcao> _gerenciadorFuncoes; // RoleManager = vai gerenciar os papeis de cada usuario no Identity

        public FuncaoRepositorio(Contexto contexto, RoleManager<Funcao> gerenciadorFuncoes) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorFuncoes = gerenciadorFuncoes;
        }

        public async Task AdicionarFuncao(Funcao funcao)
        {
            try
            {
                await _gerenciadorFuncoes.CreateAsync(funcao);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtualizarFuncao(Funcao funcao)
        {
            try
            {
                // pegar a funcao pelo id
                Funcao f = await PegarPeloId(funcao.Id);

                f.Name = funcao.Name;
                f.NormalizedName = funcao.NormalizedName;
                f.Descricao = funcao.Descricao;

                await _gerenciadorFuncoes.UpdateAsync(f);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Funcao> FiltrarFuncoes(string nomeFuncao)
        {
            try
            {
                var entity = _contexto.Funcoes.Where(f => f.Name.ToLower().Contains(nomeFuncao.ToLower()));

                return entity;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
