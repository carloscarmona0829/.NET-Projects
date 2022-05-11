using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libAccesoDatos;
using libEntidades;

namespace libreglasnegocio
{
    public class clsProveedoresRN
    {
        public DataTable ProveedoresCrud(string Accion, clsEntidadProveedor entidadProveedor)
        {
            try
            {
                clsProveedoresAD objRN = new clsProveedoresAD();
                return objRN.ProveedoresCrud(Accion, entidadProveedor);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
