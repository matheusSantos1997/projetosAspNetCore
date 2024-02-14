using ConsultaExemplo.PaginationItems;

namespace ConsultaExemplo.Repositories
{
    public interface IPeopleRepository
    {
        PeoplePaginationResult AllPeoples(Pagination pagination);
    }
}
