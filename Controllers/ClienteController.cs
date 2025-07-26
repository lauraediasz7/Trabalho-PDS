using DistribuidoraProdutos.Data;
using DistribuidoraProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraProdutos.Controllers
{
    public class ClienteController : Controller
    {
        private readonly DistribuidoraDBContext _context;

        public ClienteController(DistribuidoraDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Titulo = "Clientes";
            ViewBag.LinkAcao = "/Cliente/CadastroCliente";

            var clientes = _context.Cliente.ToList();
            return View(clientes);
        }

        public IActionResult CadastroCliente()
        {
            ViewBag.Titulo = "Cadastro de Clientes";
            return View();
        }

        [HttpPost]
        public IActionResult IncluirCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("CadastroCliente", cliente);
        }
    }
}
