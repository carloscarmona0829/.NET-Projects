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
    public class clsCierreRN
    {
        public DataSet CierreDia(string Accion, clsEntidadCierre entidadCierre)
        {
            try
            {
                clsCierreAD objRN = new clsCierreAD();
                return objRN.CierreDia(Accion, entidadCierre);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
