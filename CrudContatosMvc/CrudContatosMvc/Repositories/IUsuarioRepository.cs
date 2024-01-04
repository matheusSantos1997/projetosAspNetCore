using CrudContatosMvc.Models;

namespace CrudContatosMvc.Repositories
{
    public interface IUsuarioRepository
    {
        UsuarioModel BuscarPorLogin(string login);

        UsuarioModel BuscarPorEmailLogin(string email, string login);

        UsuarioModel ListarPorId(int id);

        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);

        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);

        bool Excluir(int id);
    }
}
