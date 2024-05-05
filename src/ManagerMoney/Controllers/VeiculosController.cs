using ManagerMoney.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagerMoney.Controllers
{
    public class VeiculosController: Controller
    {
        private readonly AppDbContext _context;
        public VeiculosController(AppDbContext contex)
        {
                _context = contex;  
        }


        public IActionResult Index()
        { return View(); 
        
        }  

    }
}
