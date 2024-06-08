using ManagerMoney.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        public async Task<IActionResult> Create(Cadastroveiculo cadastroveiculo)
        {
            if (ModelState.IsValid)

            {
                _context.CadastroVeiculos.Add(cadastroveiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View(cadastroveiculo);

        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.CadastroVeiculos.FindAsync(id);

            if (dados == null)

                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cadastroveiculo cadastroveiculo)
        {

            if (id != cadastroveiculo.Id)
                return NotFound();

            if (ModelState.IsValid)

            {
                _context.CadastroVeiculos.Update(cadastroveiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }


            return View();

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.CadastroVeiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.CadastroVeiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.CadastroVeiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.CadastroVeiculos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
       
    }

}