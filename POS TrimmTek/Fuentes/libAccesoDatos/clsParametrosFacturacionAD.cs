using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libConexion;
using libEntidades;

namespace libAccesoDatos
{
    public class clsParametrosFacturacionAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        public DataSet ParametrosFacturacion()
        {
            try
            {
                DataSet dsDatos = new DataSet();

                dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_FACT_ConsParamformFacturacion");

                return dsDatos;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }

}
