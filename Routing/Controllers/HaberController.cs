using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class HaberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Guncel")]
        public IActionResult Guncel()
        {
            return View();
        }
        [Route("HavaDurumu")]
        [Route("HavaDurumu/{sehir?}")]
        public IActionResult HavaDurumu(int? sehir)
        {
            ViewBag.Sehir = sehir;
            return View();
        }
        [Route("SporHaberleri")]
        public IActionResult Spor()
        {
            return View();
        }
    }
}
