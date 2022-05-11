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
    public class clsNominaRN
    {
        public DataSet Nomina(string Accion, clsEntidadNomina entidadNomina)
        {
            try
            {
                clsNominaAD objRN= new clsNominaAD();
                return objRN.Nomina(Accion, entidadNomina);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
