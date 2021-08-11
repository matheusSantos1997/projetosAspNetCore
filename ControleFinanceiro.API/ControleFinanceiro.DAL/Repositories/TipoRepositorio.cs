using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Repositories
{
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        public TipoRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
