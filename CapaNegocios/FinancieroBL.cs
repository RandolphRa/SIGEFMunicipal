using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class FinancieroBL
    {
        //Servicio que consume la capa datos
        public List<FinancieroClasificadoresCLS> ListarClasificadores() {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarClasificadores();
        }

        public List<FinancieroFuentesFinanciamientoCLS> ListarFuentes()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarFuentesFinanciamiento();
        }


        public List<FinancieroCatalogoFuncionesCLS> ListarCatalogoFunciones()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarFinancieroCatalogo();
        }

        public List<FinancieroProgramaticaCLS> ListarProgramatico()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarEtsProgramatico();

        }

        public List<FinancieroCatalogoOrganismosFinanciadoresCLS> ListarFinancieroCatalogoOrganismos()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarFinancieroCatalogoOrganismos();
        }

        public List<FinancieroFuenteEspecificaCLS>ListarFuentesEsp()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarFuentesEspecificas();
        }

        public List<IngresosCLS> ListarIngresos()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarIngresos();
        }

        public List<GastosCLS> ListarGastos()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarGastos();
        }
        public List<ProyectoCLS> ListarProyecto()
        {

            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarProyecto();
        }
        public ComboCLS listarCombosClasificadores()
        {
           FinancieroDAL obj = new FinancieroDAL();
            return obj.listarCombosClasificadores();
            
            //return obj  
        }


        public List<AnoFiscalCLS> listarAnoFiscal()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarAnoFiscal();

            //return obj  
        }
        public List<EntradaIngresoCLS> ListarEntradaIngreso()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarEntradaIngreso();

            //return obj  
        }
        public List<TiposRetencionesCLS> ListarTiposRetenciones()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarTiposRetenciones();

            //return obj  
        }
        public List<DestinoGastoCLS> ListarDestinoGasto()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarDestinoGasto();

            //return obj  
        }
        public List<GruposPagoCLS> ListarGruposPago()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarGruposPago();

            //return obj  
        }
        public List<BeneficiarioCLS> ListarBeneficiario()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarBeneficiario();

            //return obj  
        }
        public List<BeneficiariosGruposCLS> ListarBeneficiariosGrupos()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarBeneficiariosGrupos();

            //return obj  
        }
        public List<ComprobantesIngresosCLS> ListarComprobantesIngresos()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarComprobantesIngresos();

            //return obj  
        }
        public List<ComprobantesGastosCLS> ListarComprobantesGastos()
        {
            FinancieroDAL obj = new FinancieroDAL();
            return obj.ListarComprobantesGastos();

            //return obj  
        }
        //ListarGruposPago
    }

}
