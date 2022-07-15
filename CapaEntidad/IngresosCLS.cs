using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class IngresosCLS
    {
        public int id { get; set; }
        public int Clasificador { get; set; }
        public string Denominacion { get; set; }
        public string FuenteFinanciamiento { get; set; }
        public string FuenteEspecifica { get; set; }
        public string OrganismoFinancamiento { get; set; }
        public string InstitucionOtorgante { get; set; }
        public string Tipo { get; set; }
        public string AnoAnterior { get; set; }
        public string Fecha { get; set; }
        public string Estimado { get; set; }
        public string Formulado { get; set; }

    }
}
