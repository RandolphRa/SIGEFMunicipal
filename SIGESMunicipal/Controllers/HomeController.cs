using Microsoft.AspNetCore.Mvc;
using 
    Municipal.Models;
using System.Diagnostics;
using CapaNegocios;
using CapaEntidad;


namespace SIGEFMunicipal.Controllers
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
            return View();

        }

        public List<FinancieroClasificadoresCLS> ListarUsuario()
        {
            //Consume la capa negocios
            UsuarioNE obj = new UsuarioNE();
            return obj.Listarusuarios();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Administrativo()
        {
            return View();
        }

        public IActionResult Principal()
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