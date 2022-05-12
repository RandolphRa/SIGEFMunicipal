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
        public List<UsuarioEntity> Listarusuarios() { 
        
            UsuarioDAT obj = new UsuarioDAT();
            return obj.ListarUsuarios();
        }
    }
}
