using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
