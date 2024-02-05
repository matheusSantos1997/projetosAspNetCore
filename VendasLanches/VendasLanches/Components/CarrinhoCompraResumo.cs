using Microsoft.AspNetCore.Mvc;
using VendasLanches.Models;
using VendasLanches.ViewModels;

namespace VendasLanches.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
           var items = _carrinhoCompra.GetCarrinhoCompraItens();
           /*var items = new List<Models.CarrinhoCompraItem>()
           {
               new Models.CarrinhoCompraItem(),
               new Models.CarrinhoCompraItem(),
           }; */
            _carrinhoCompra.CarrinhoCompraItems = items;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            }!;

            return View("~/Views/Shared/Components/Default.cshtml", carrinhoCompraVM);
        }
    }
}