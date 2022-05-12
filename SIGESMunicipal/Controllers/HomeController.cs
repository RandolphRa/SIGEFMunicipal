using Microsoft.AspNetCore.Mvc;
using SIGESMunicipal.Models;
using System.Diagnostics;
using CapaNegocios;
using CapaEntidad;


namespace SIGESMunicipal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UsuarioNE obj = new UsuarioNE();
            return View(obj.Listarusuarios());

        }

        public IActionResult Privacy()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}