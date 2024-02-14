namespace ConsultaExemplo.PaginationItems
{
    public class Pagination
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public Pagination()
        {

        }

        public Pagination(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
