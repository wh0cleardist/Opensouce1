using Microsoft.AspNetCore.Mvc;
using Parcial.Models;

namespace parcial.Controllers
{
    public class ProductoController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();
        public IActionResult Index()
        {
            var productos = _context.Producto.ToList();
            return View(productos);
        }
    }
}
