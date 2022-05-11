using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libAccesoDatos;

namespace libreglasnegocio
{
    public class clsInventarioRN
    {
        public DataSet Inventario(string Accion, string actualizarProductos)
        {
            try
            {
                clsInventarioAD objRN = new clsInventarioAD();
                return objRN.Inventario(Accion, actualizarProductos);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
