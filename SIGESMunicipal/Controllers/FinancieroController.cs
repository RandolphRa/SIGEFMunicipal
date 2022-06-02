﻿using CapaEntidad;
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
<<<<<<< HEAD

        public List<FinancieroCatalogoFuncionesCLS> ListarCatalogoFunciones()
        {
            //Consume la capa negocios
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarCatalogoFunciones();

=======
        public List<FinancieroProgramaticaCLS> ListarProgramatico()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarProgramatico();
>>>>>>> c4bdf1e5d53d1984e1fb6bb09a6caad996503262
        }
    }
}
