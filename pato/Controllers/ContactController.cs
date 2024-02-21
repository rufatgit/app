using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
