using ControleFinanceiro.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Interfaces
{
    public interface IFuncaoRepositorio : IRepositorioGenerico<Funcao>
    {
        Task AdicionarFuncao(Funcao funcao);

        Task AtualizarFuncao(Funcao funcao);
    }
}
