using Microsoft.AspNetCore.Mvc;

namespace neogym.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
