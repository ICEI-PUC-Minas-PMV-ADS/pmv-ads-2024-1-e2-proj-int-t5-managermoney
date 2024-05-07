using ManagerMoney.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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


        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Cadastroveiculo Cadastroveiculo)
        {
            if (ModelState.IsValid)

            {
                _context.CadastroVeiculos.Add(Cadastroveiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");   

            }

            return View(Cadastroveiculo);

        }


        public async  Task<IActionResult> Edit(int? id)
        {
            if(id == null)  
                return NotFound();

            var dados = await _context.CadastroVeiculos.FindAsync(id);    
            
            if(dados == null)

                return NotFound();

            return View();  
        }

            [HttpPost]
        public async Task<IActionResult> Edit(int id, Cadastroveiculo cadatroveiculo) 
        {

            if (id != cadatroveiculo.Id)
                return NotFound();

            if (ModelState.IsValid)

            {
                _context.CadastroVeiculos.Update(cadatroveiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }


            return View();

        }
        

    }
}
