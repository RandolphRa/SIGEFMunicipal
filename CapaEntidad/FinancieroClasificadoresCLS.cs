using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //Entidad
    public class FinancieroClasificadoresCLS
    {
        public int ID { get; set; }
        public int CLASIFICADOR { get; set; }
        public string DESCRIPCION { get; set; }
        public int CUENTA_CONTROL { get; set; }
        public string TIPO { get; set; }
        public string CLASIFICACION { get; set; }
        public int CTA_CONTABLE { get; set; }
    }
}
