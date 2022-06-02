using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //Entidad
    public class FinancieroFuentesFinanciamientoCLS
    {
        public int ID { get; set; }
        public int CODIGO { get; set; }
        public string FUENTE { get; set; }
        public int FONDO { get; set; }
        public string ORIGEN { get; set; }
        public string DENOMINACION { get; set; }
        public string GRUPO { get; set; }
    }
}
