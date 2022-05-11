using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public bool Estado { get; set; }
    }
}
