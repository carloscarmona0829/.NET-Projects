using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadNomina
    {
        public int? Id_Barbero { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public bool CalcularVentas { get; set; }
        public string Usu_CreaNomina { get; set; }
        public string Fecha_CreaNomina { get; set; }
        public int Id_Estado { get; set; }
        public int Cant_ServPto { get; set; }
        public int Vlr_Nomina { get; set; }
        public int Id_Nomina { get; set; }
        public string Usu_ModNomina { get; set; }
        public string Fecha_ModNomina { get; set; }
    }
}
