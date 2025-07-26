using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class ItemPedidoController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public ItemPedidoController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Item do Pedido";
            ViewBag.LinkAcao = "/ItemPedido/CadastroItemPedido";
            return View();
        }
        public IActionResult CadastroItemPedido()
        {
            ViewBag.Titulo = "Cadastro de Itens do Pedido";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirItemPedido(ItemPedido itemPedido)
        {
            return View("Index");
        }
    }
}
