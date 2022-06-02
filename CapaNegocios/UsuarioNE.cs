using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class UsuarioNE
    {
        //Servicio que consume la capa datos
        public List<FinancieroClasificadores> Listarusuarios() { 
        
            UsuarioDAT obj = new UsuarioDAT();
            return obj.ListarUsuarios();
        }
    }
}
