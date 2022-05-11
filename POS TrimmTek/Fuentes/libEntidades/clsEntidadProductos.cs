using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadProductos
    {
        public int Id_Producto { get; set; }
        public string Producto { get; set; }
        public int Costo { get; set; }
        public int PVP { get; set; }
        public int Id_Proveedor { get; set; }
        public string Codigo_Barras { get; set; }
        public int Id_TipoProducto { get; set; }
        public int Cant_Minima { get; set; }
        public int Cant_Stock { get; set; }
        public int Id_Estado { get; set; }
        public string Usu_CreaProducto { get; set; }
        public string Fecha_CreaProducto { get; set; }
        public string Usu_ModProducto { get; set; }
        public string Fecha_ModProducto { get; set; }
    }
}
