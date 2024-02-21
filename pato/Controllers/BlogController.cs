using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
