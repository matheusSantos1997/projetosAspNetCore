using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Interfaces
{
    public interface IProEventosPalestranteRepository
    {
        //Palestrantes
        Task<List<Palestrante>> GetAllPelestrantesByNomeAsync(string nome, bool includeEventos);
        Task<List<Palestrante>> GetAllPalestrantesAsync(bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);
    }
}