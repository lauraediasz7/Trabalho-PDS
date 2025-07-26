using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class ItemRequisicaoController : Controller
    {
        private DistribuidoraDBContext distribuidoraDBContext;

        public ItemRequisicaoController(DistribuidoraDBContext context)
        {
            distribuidoraDBContext = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Item da Requisição";
            ViewBag.LinkAcao = "/ItemRequisicao/CadastroItemRequisicao";
            return View();
        }
        public IActionResult CadastroItemRequisicao()
        {
            ViewBag.Titulo = "Cadastro de Itens da Requisição";
            return View();
        }
        [HttpPost]
        public IActionResult IncluirItemRequisicao(ItemRequisicao itemRequisicao)
        {
            return View("Index");
        }
    }
}
