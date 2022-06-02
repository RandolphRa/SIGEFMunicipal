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
        
            UsuarioDAT obj = new UsuarioDAT();
            return obj.ListarUsuarios();
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
    }
}
