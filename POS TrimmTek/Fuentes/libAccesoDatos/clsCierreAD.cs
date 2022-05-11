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
    public class clsCierreAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        public DataSet CierreDia(string Accion, clsEntidadCierre entidadCierre)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                SqlParameter[] Parametros;

                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[11];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Fecha_Cierre", entidadCierre.Fecha_Cierre);
                        Parametros[2] = new SqlParameter("@Id_Factura ", entidadCierre.Id_Factura);
                        Parametros[3] = new SqlParameter("@Dinero_en_Caja ", entidadCierre.Dinero_en_Caja);
                        Parametros[4] = new SqlParameter("@Id_Estado ", entidadCierre.Id_Estado);
                        Parametros[5] = new SqlParameter("@Observacion ", entidadCierre.Observacion);
                        Parametros[6] = new SqlParameter("@Usu_Crea_Cierre ", entidadCierre.Usu_Crea_Cierre);
                        Parametros[7] = new SqlParameter("@Fech_Crea_Cierre ", entidadCierre.Fech_Crea_Cierre);
                        Parametros[8] = new SqlParameter("@UsuarioAutoriza ", entidadCierre.UsuarioAutoriza);
                        Parametros[9] = new SqlParameter("@PwdUsuarioAutoriza ", entidadCierre.PwdUsuarioAutoriza);
                        Parametros[10] = new SqlParameter("@Fecha_ModCierre ", entidadCierre.Fecha_ModCierre);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[11];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Fecha_Cierre", entidadCierre.Fecha_Cierre);
                        Parametros[2] = new SqlParameter("@Id_Factura ", entidadCierre.Id_Factura);
                        Parametros[3] = new SqlParameter("@Dinero_en_Caja ", entidadCierre.Dinero_en_Caja);
                        Parametros[4] = new SqlParameter("@Id_Estado ", entidadCierre.Id_Estado);
                        Parametros[5] = new SqlParameter("@Observacion ", entidadCierre.Observacion);
                        Parametros[6] = new SqlParameter("@Usu_Crea_Cierre ", entidadCierre.Usu_Crea_Cierre);
                        Parametros[7] = new SqlParameter("@Fech_Crea_Cierre ", entidadCierre.Fech_Crea_Cierre);
                        Parametros[8] = new SqlParameter("@UsuarioAutoriza ", entidadCierre.UsuarioAutoriza);
                        Parametros[9] = new SqlParameter("@PwdUsuarioAutoriza ", entidadCierre.PwdUsuarioAutoriza);
                        Parametros[10] = new SqlParameter("@Fecha_ModCierre ", entidadCierre.Fecha_ModCierre);

                        break;

                    case "ANULAR":

                        Parametros = new SqlParameter[11];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Fecha_Cierre", entidadCierre.Fecha_Cierre);
                        Parametros[2] = new SqlParameter("@Id_Factura ", entidadCierre.Id_Factura);
                        Parametros[3] = new SqlParameter("@Dinero_en_Caja ", entidadCierre.Dinero_en_Caja);
                        Parametros[4] = new SqlParameter("@Id_Estado ", entidadCierre.Id_Estado);
                        Parametros[5] = new SqlParameter("@Observacion ", entidadCierre.Observacion);
                        Parametros[6] = new SqlParameter("@Usu_Crea_Cierre ", entidadCierre.Usu_Crea_Cierre);
                        Parametros[7] = new SqlParameter("@Fech_Crea_Cierre ", entidadCierre.Fech_Crea_Cierre);
                        Parametros[8] = new SqlParameter("@UsuarioAutoriza ", entidadCierre.UsuarioAutoriza);
                        Parametros[9] = new SqlParameter("@PwdUsuarioAutoriza ", entidadCierre.PwdUsuarioAutoriza);
                        Parametros[10] = new SqlParameter("@Fecha_ModCierre ", entidadCierre.Fecha_ModCierre);

                        break;

                    case "LISTARCIERRES":
                        Parametros = new SqlParameter[1];

                        Parametros[0] = new SqlParameter("@Accion", Accion);

                        break;

                    case "CIERRE PARCIAL":

                        goto case "INSERTAR";
                        

                    default:
                        return null;
                        //break;
                }

                dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_FACT_CIERREDIA", Parametros);

                return dsDatos;

            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
