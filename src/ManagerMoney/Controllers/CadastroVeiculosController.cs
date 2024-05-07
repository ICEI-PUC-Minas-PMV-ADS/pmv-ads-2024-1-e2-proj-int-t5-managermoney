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

          

            return View(Cadastroveiculo);

        }

        public async  task<IActionResult> Edit(int? id)
        {
            if(id == null)  
                return NotFound();

            var dados=await _context.CadastroVeiculos. FindAsync()    
            
            if(dados == null)

            return NotFound();

            return View();  
        }

            [HttpPost]
        public IActionResult Edit(int id, Cadastroveiculo cadatroveiculo) 
        {   

        if (id! = Cadastroveidulo.Id    )      


        return View();

        }
        

    }
}
