using Microsoft.AspNetCore.Mvc;

namespace SIGESMunicipal.Controllers
{
    public class FinancieroController : Controller
    {
        //get coneccion appsettings.json
        public string cadena()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(),"appsettings.json"));
            var root = builder.Build();
            var cn = root.GetConnectionString("cn");
            return cn;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
