using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProyectoCLS
    {
        public int id  { get; set; }   
        public string Proyecto { get; set; }
        public string CodigoObra { get; set; }
        public string Descripcion { get; set; }
        public string FechaIninio { get; set; }
        public string FechaFin { get; set; }
        public string Participacion { get; set; }

    }
}
