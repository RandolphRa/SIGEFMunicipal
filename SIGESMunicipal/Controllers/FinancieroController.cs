using CapaEntidad;
using CapaNegocios;
using Microsoft.AspNetCore.Mvc;

namespace 
    Municipal.Controllers
{
    public class FinancieroController : Controller
    {
        //get coneccion appsettings.json
        public string cadena()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            var cn = root.GetConnectionString("cn");
            return cn;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clasificadores()
        {
            return View();
        }

        public IActionResult FuentesFinanciamiento()
        {
            return View();
        }
        public IActionResult Programatico()
        {
            return View();
        }

        public IActionResult Catalogo()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult OrganismoFinanciador()
        {
            return View();
        }

=======
        public IActionResult FuenteEspecifica()
        {
            return View();
        }
>>>>>>> c67a5e1c177c59281f7b297b24788c2e13bc0ae7

        public List<FinancieroClasificadoresCLS> ListarClasificadores()
        {
            //Consume la capa negocios
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarClasificadores();

        }

        public List<FinancieroFuentesFinanciamientoCLS> ListarFuentes()
        {
            //Consume la capa negocios
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarFuentes();

        }


        public List<FinancieroCatalogoFuncionesCLS> ListarCatalogoFunciones()
        {
            //Consume la capa negocios
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarCatalogoFunciones();
        }

        
        public List<FinancieroCatalogoOrganismosFinanciadoresCLS> ListarFinancieroCatalogoOrganismos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarFinancieroCatalogoOrganismos();

        }
        public List<FinancieroFuenteEspecificaCLS> ListarFuentesEsp()
        {
            FinancieroBL obj = new FinancieroBL();    
            return obj.ListarFuentesEsp();

        }
    }
}
