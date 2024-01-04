using CrudContatosMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrudContatosMvc.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult?> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado")!;
           
            if (string.IsNullOrWhiteSpace(sessaoUsuario)) return null;

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario)!;

            return View(usuario);
        }
    }
}
