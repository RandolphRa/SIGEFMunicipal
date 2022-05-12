using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class UsuarioDAT
    {
        public List<UsuarioEntity> ListarUsuarios() { 
            List<UsuarioEntity> listaUsuarios = new List<UsuarioEntity>(); 
            listaUsuarios.Add(new UsuarioEntity { 
                ID = 1,
                Name ="Randolph"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });

            return listaUsuarios;
        
        }
    }
}
