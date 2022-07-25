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

        public IActionResult OrganismoFinanciador()
        {
            return View();
        }


        public IActionResult FuenteEspecifica()
        {
            return View();
        }
        public IActionResult ActivosFijos()
        {
            return View();
        }
        public IActionResult EjecucionPresuesto()
        {
            return View();
        }
        public IActionResult ConciliacionBancaria()
        {
            return View();
        }
        public IActionResult CuentasPagar()
        {
            return View();
        }
        public IActionResult FacturacionCobros()
        {
            return View();
        }

        public IActionResult Ingresos()
        {
            return View();
        }
        public IActionResult Gastos()
        {
            return View();
        }
        public IActionResult Proyecto()
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
        public List<FinancieroProgramaticaCLS> ListarProgramatico()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarProgramatico();

        }


        public List<FinancieroFuenteEspecificaCLS> ListarFuentesEsp()
        {
            FinancieroBL obj = new FinancieroBL();    
            return obj.ListarFuentesEsp();

        }
        public List<IngresosCLS> ListarIngresos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarIngresos();

        }
        public List<GastosCLS> ListarGastos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarGastos();

        }
        public List<ProyectoCLS> ListarProyecto()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarProyecto();

        }
        public ComboCLS listarCombosClasificadores()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.listarCombosClasificadores();
        }
        //ListarEntradaIngreso
        public List<AnoFiscalCLS> ListarAnoFiscal()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.listarAnoFiscal();

        }
        public List<EntradaIngresoCLS> ListarEntradaIngreso()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarEntradaIngreso();

        }
        //ListarTiposRetenciones
        public List<TiposRetencionesCLS> ListarTiposRetenciones()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarTiposRetenciones();

        }
        //ListarGruposPago
        public List<DestinoGastoCLS> ListarDestinoGasto()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarDestinoGasto();

        }
        public List<GruposPagoCLS> ListarGruposPago()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarGruposPago();

        }
        public List<BeneficiarioCLS> ListarBeneficiario()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarBeneficiario();

        }
        public List<BeneficiariosGruposCLS> ListarBeneficiariosGrupos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarBeneficiariosGrupos();

        }
        public List<ComprobantesIngresosCLS> ListarComprobantesIngresos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarComprobantesIngresos();

        }
        public List<ComprobantesGastosCLS> ListarComprobantesGastos()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarComprobantesGastos();

        }
        public List<CategoriaCLS> ListarCategoria()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarCategoria();

        }
        public List<AreasCLS> ListarAreas()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarAreas();

        }
        public List<MarcasCLS> ListarMarcas()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarMarcas();

        }
        public List<ClasificadorGastoCLS> ListarClasificadorGasto()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarClasificadorGasto();

        }
        public List<GrupoProgramasCLS> ListarGrupoProgramas()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarGrupoProgramas();

        }
        public List<ProgramasCLS> ListarProgramas()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarProgramas();
        }
        public List<DepartamentoCLS> ListarDepartamento()
        {
            FinancieroBL obj = new FinancieroBL();
            return obj.ListarDepartamento();
        }
    }
}
       