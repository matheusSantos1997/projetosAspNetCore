using VendasLanches.Models;

namespace VendasLanches.ViewModels
{
    #nullable disable
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}