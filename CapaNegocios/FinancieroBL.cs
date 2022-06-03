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

    }
}
