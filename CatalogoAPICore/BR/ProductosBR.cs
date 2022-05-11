using DA;
using Entities;
using System.Data;

namespace BR
{
    public class ProductosBR
    {
        public DataSet CargarDdl_Productos()
        {
            try
            {
                ProductosDA objRN = new ProductosDA();
                return objRN.CargarDdl_Productos();
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
        public DataTable ProductosCrud(string Accion, Productos entidadProductos)
        {
            try
            {
                ProductosDA objRN = new ProductosDA();
                return objRN.ProductosCrud(Accion, entidadProductos);
            }
            catch (Exception error)
            {
                throw error;
            }
        }        
    }
}
