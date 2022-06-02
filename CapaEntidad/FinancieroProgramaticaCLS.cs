using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class FinancieroProgramaticaCLS
    {
        public int id { get; set; }
        public int PNAP { get; set; }   
        public int Programa { get; set; }   
        public int Actividad { get; set; }  
        public string EstProgControl { get; set; }
        public string Denominacion { get; set; }
        public string UnidadResponsable { get; set; }
        public string Tipo { get; set; }
        public string Funcion { get; set; }
        public string Participacion { get; set; }
        public string Contrato { get; set; }
    }
}
