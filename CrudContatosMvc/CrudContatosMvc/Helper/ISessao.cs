using CrudContatosMvc.Models;

namespace CrudContatosMvc.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuario);

        void RemoverSessaoUsuario();

        UsuarioModel? BuscarSessaoUsuario();
    }
}
