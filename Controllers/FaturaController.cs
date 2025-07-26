using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class FaturaController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public FaturaController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Fatura";
            ViewBag.LinkAcao = "/Fatura/CadastroFatura";
            return View();
        }
        public IActionResult CadastroFatura()
        {
            ViewBag.Titulo = "Cadastro de Faturas";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirFatura(Fatura fatura)
        {
            return View("Index");
        }
    }
}
