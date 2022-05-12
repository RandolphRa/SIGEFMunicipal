using Microsoft.AspNetCore.Mvc;

namespace SIGESMunicipal.Controllers
{
    public class FinancieroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
