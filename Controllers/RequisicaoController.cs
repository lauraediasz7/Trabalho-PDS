using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class RequisicaoController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public RequisicaoController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Requisição";
            ViewBag.LinkAcao = "/Requisicao/CadastroRequisicao";
            return View();
        }
        public IActionResult CadastroRequisicao()
        {
            ViewBag.Titulo = "Cadastro de Requisições";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirRequisicao(Requisicao requisicao)
        {
            return View("Index");
        }
    }
}
