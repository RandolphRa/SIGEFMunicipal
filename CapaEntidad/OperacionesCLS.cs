using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OperacionesCLS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperacionesCLS()
        {
            this.rol_operacion = new HashSet<USUARIOCLS>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idModulo { get; set; }

        public virtual ModuloCLS modulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOCLS> rol_operacion { get; set; }
    }
}
