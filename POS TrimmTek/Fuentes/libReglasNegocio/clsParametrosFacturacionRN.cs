using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libAccesoDatos;

namespace libreglasnegocio
{
    public class clsParametrosFacturacionRN
    {
        public DataSet ParametrosFacturacion()
        {
            try
            {
                clsParametrosFacturacionAD objRN = new clsParametrosFacturacionAD();
                return objRN.ParametrosFacturacion();
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
