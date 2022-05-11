using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libConexion;

namespace libAccesoDatos
{
   public class clsInventarioAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        public DataSet Inventario(string Accion, string actualizarProductos)
       {
           try
           {
               DataSet dsDatos = new DataSet();
               SqlParameter[] Parametros;

               switch (Accion)
               {
                   case "ACTUALIZAR INVENTARIO":

                       Parametros = new SqlParameter[2];

                       Parametros[0] = new SqlParameter("@Accion", Accion);
                       Parametros[1] = new SqlParameter("@Datos", actualizarProductos);

                       break;

                   case "LISTAR INVENTARIO":
                       Parametros = new SqlParameter[1];

                       Parametros[0] = new SqlParameter("@Accion", Accion);

                       break;

                  default:
                       return null;
               }

               dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_Inv_InventariosCRUD", Parametros);

               return dsDatos;
           }
           catch (Exception Error)
           {
               throw Error;
           }
       }
    }
}
