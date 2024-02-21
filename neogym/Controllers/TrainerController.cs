using Microsoft.AspNetCore.Mvc;

namespace neogym.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Trainer()
        {
            return View();
        }
    }
}
