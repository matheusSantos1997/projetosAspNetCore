using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.interfaces
{
    public interface IPalestrantePersistence
    {
        //Palestrantes
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);

        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);

        Task<Palestrante> GetPalestrantesByIdAsync(int PalestranteId, bool includeEventos = false);
    }
}
