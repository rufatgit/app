using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
    }
}
