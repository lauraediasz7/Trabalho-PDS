using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public ProdutoController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Produto";
            ViewBag.LinkAcao = "/Produto/CadastroProduto";
            return View();
        }
        public IActionResult CadastroProduto()
        {
            ViewBag.Titulo = "Cadastro de Produtos";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirProduto(Produto produto)
        {
            return View("Index");
        }
    }
}
