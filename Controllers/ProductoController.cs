using Microsoft.AspNetCore.Mvc;

namespace parcial.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
