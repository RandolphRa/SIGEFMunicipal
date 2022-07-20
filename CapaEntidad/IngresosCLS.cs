using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class IngresosCLS
    {
        //public int id { get; set; }
        public string Clasificador { get; set; }
        public string Denominacion { get; set; }
        public string FuenteFinanciamiento { get; set; }
        public string FuenteEspecifica { get; set; }
        public string OrganismoFinancamiento { get; set; }
        public string InstitucionOtorgante { get; set; }
        public string Tipo { get; set; }
        //[PRESUP_ANTERIOR] [decimal](18, 2) NOT NULL
        public decimal AnoAnterior { get; set; }
       // public string Fecha { get; set; }
        //[ESTIMADO_ACTUAL] [decimal](18, 2) NOT NULL
        public decimal Estimado { get; set; }
        //[VALOR_PRESUPUESTO] [decimal](18, 2) NOT NULL,
        public decimal Formulado { get; set; }

    }
}
