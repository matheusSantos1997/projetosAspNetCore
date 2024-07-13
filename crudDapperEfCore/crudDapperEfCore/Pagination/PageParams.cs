namespace crudDapperEfCore.Pagination
{
    public class PageParams
    {
        public const int MaxPageSize = int.MaxValue;

        public int PageNumber { get; set; } = 1;

        public int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
    }
}
