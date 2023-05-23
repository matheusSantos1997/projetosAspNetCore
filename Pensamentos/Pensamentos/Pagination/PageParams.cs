namespace Pensamentos.Pagination
{
    public class PageParams
    {
        public const int MaxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        public int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
            // qualquer valor que seja maior que o numero máximo de paginas retorna o numeroMaximo de paginas senao o valor
        }
    }
}
