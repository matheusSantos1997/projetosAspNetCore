using cursoDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDapper.Interfaces
{
    interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();

        public Usuario GetUsuario(int id);

        public void InsertUsuario(Usuario usuario);

        public void UpdateUsuario(Usuario usuario);

        public void DeleteUsuario(int id);
    }
}
