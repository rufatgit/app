using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
