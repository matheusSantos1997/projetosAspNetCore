using Pensamentos.Models;
using Pensamentos.Pagination;

namespace Pensamentos.Repository
{
    public interface IPensamentoRepository
    {
        PageList<Pensamento> PegarTodosPensamentos(PageParams pageParams);

        PageList<Pensamento> PegarTodosPensamentosPorAutoria(string conteudo, PageParams pageParams);

        PageList<Pensamento> PegarTodosPensamentosFavoritos(PageParams pageParams);

        Pensamento PegarPensamentoPorId(int id);

        void AdicionarNovoPensamento(Pensamento pensamento);

        void AtualizarPensamento(int id, Pensamento pensamento);

        void ExcluirPensamento(Pensamento pensamento);


    }
}
