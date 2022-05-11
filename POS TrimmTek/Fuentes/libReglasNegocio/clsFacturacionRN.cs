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
    public class clsFacturacionRN
    {
        public DataSet FacturacionCrud(string Accion, clsEntidadFacturacion entidadFacturacion)
        {
            try
            {
                clsFacturacionAD objRN = new clsFacturacionAD();
                return objRN.FacturacionCrud(Accion, entidadFacturacion);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
