using ManagerMoney.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagerMoney.Controllers
{

    public class CadastroVeiculosController : Controller
    {
        private readonly AppDbContext _context;
        public CadastroVeiculosController(AppDbContext context)
        {

            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.CadastroVeiculos.ToListAsync();

            return View(dados);
        }
        public IActionResult  Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Cadastroveiculo cadastroveiculo)
        {

            if(ModelState.IsValid)
            {
                _context.CadastroVeiculos.Add(Cadastroveiculo)
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Cadastroveiculo);

        }
    }
}
