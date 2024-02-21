using Microsoft.AspNetCore.Mvc;

namespace pato.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Reservation()
        {
            return View();
        }
    }
}
