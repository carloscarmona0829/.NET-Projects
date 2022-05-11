using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libAccesoDatos;
using libEntidades;

namespace libReglasNegocio
{
    public class clsProductosRN
    {
        public DataSet CargarCombosProveedoryTipoProducto()
        {
            try
            {
                clsProductosAD objRN = new clsProductosAD();
                return objRN.CargarCombosProveedoryTipoProducto();
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
        public DataTable ProductosCrud(string Accion, clsEntidadProductos entidadProductos)
        {
            try
            {
                clsProductosAD objRN = new clsProductosAD();
                return objRN.ProductosCrud(Accion, entidadProductos);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
