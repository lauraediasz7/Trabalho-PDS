using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class PedidoController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public PedidoController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Pedido";
            ViewBag.LinkAcao = "/Pedido/CadastroPedido";
            return View();
        }
        public IActionResult CadastroPedido()
        {
            ViewBag.Titulo = "Cadastro de Pedidos";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirPedido(Pedido pedido)
        {
            return View("Index");
        }
    }
}
