using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadFacturacion
    {
        public int Numero_Factura { get; set; }
        public string Identificacion_Cliente { get; set; }
        public int Id_Barbero { get; set; }
        public string Usu_CreaFact { get; set; }
        public string Fecha_Fact { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Vlr_Unitario { get; set; }
        public int Id_Factura { get; set; }
        public int Id_Factura_Det { get; set; }
        public string Usu_ModFact { get; set; }
        public string Fecha_ModFact { get; set; }
        public bool CreaEncabezado { get; set; }
        public string UsuarioAutoriza { get; set; }
        public string PwdUsuarioAutoriza { get; set; }
        public bool CrearTruno { get; set; }
    }
}
