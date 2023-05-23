

namespace Pensamentos.Pagination
{
    public class PageList<T> : List<T>
    {
        public int CurrentPage { get; set; } // pagina atual

        public int TotalPages { get; set; } // total de paginas

        public int PageSize { get; set; } // quantidade de itens por pagina

        public int TotalCount { get; set; }

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize); // vai ser convertido para int
            AddRange(items);
        }

        public static PageList<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize) // calculo responsável por pular para a próxima página
                                    .Take(pageSize)
                                    .ToList();

            return new PageList<T>(items, count, pageNumber, pageSize);

        }
    }
}
