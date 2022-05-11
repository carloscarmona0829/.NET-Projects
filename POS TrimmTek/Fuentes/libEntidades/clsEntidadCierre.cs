using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadCierre
    {
        public string Fecha_Cierre { get; set; }
        public int Id_Factura { get; set; }
        public int Dinero_en_Caja { get; set; }
        public int Id_Estado { get; set; }
        public string Observacion { get; set; }
        public string Usu_Crea_Cierre { get; set; }
        public string Fech_Crea_Cierre { get; set; }
        public string UsuarioAutoriza { get; set; }
        public string PwdUsuarioAutoriza { get; set; }
        public string Fecha_ModCierre { get; set; }
    }
}
