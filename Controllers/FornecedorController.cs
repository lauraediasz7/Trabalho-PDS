using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class FornecedorController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public FornecedorController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Fornecedor";
            ViewBag.LinkAcao = "/Fornecedor/CadastroFornecedor";
            return View();
        }
        public IActionResult CadastroFornecedor()
        {
            ViewBag.Titulo = "Cadastro de Fornecedores";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirFornecedor(Fornecedor fornecedor)
        {
            return View("Index");
        }
    }
}
