using System.Linq;
using System.Threading.Tasks;
using ControleFinanceiro.BLL.Models;

namespace ControleFinanceiro.DAL.Interfaces
{
    public interface IGanhosRepositorio : IRepositorioGenerico<Ganho>
    {
        IQueryable<Ganho> PegarGanhosPeloUsuarioId(string usuarioId);

        IQueryable<Ganho> FiltrarGanhos(string nomeCategoria);

        Task<double> PegarGanhoTotalPeloUsuarioId(string usuarioId);
    }
}