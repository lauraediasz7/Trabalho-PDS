using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class ProdutoFornecedorController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public ProdutoFornecedorController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Produto Fornecedor";
            ViewBag.LinkAcao = "/ProdutoFornecedor/CadastroProdutoFornecedor";
            return View();
        }
        public IActionResult CadastroProdutoFornecedor()
        {
            ViewBag.Titulo = "Cadastro de Produtos Fornecedores";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirProdutoFornecedor(ProdutoFornecedor produtoFornecedor)
        {
            return View("Index");
        }
    }
}
