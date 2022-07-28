using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol_OperacionCLS
    {
        public int id { get; set; }
        public Nullable<int> idRol { get; set; }
        public Nullable<int> idOperacion { get; set; }

        public virtual OperacionesCLS operaciones { get; set; }
        public virtual RolCLS rol { get; set; }
    }
}
