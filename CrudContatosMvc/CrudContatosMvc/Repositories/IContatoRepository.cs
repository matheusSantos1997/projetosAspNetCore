using CrudContatosMvc.Models;

namespace CrudContatosMvc.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos(int usuarioId);

        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool Excluir(int id);
    }
}
