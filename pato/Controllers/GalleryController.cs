using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
