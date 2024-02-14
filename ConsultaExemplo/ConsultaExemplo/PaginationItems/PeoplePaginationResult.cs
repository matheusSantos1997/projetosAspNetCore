using ConsultaExemplo.Models;

namespace ConsultaExemplo.PaginationItems
{
    #nullable disable
    public class PeoplePaginationResult
    {
        public List<People> Peoples { get; set; }
        public int? TotalCount { get; set; }
    }
}
