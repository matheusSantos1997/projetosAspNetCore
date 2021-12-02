using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Repositories
{
    public class MesRepositorio : RepositorioGenerico<Mes>, IMesRepositorio
    {
        public MesRepositorio(Contexto contexto) : base(contexto) { }
    }
}
