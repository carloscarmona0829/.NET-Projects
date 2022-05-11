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
    public class clsNominaAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        public DataSet Nomina(string Accion,clsEntidadNomina entidadNomina)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                SqlParameter[] Parametros;

                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[8];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Id_Barbero", entidadNomina.Id_Barbero);
                        Parametros[2] = new SqlParameter("@Fecha_Inicio ", entidadNomina.Fecha_Inicio);
                        Parametros[3] = new SqlParameter("@Fecha_Fin ", entidadNomina.Fecha_Fin);
                        Parametros[4] = new SqlParameter("@CalVtasPtos ", entidadNomina.CalcularVentas);
                        Parametros[5] = new SqlParameter("@Usu_CreaNomina ", entidadNomina.Usu_CreaNomina);
                        Parametros[6] = new SqlParameter("@Fecha_CreaNomina ", entidadNomina.Fecha_CreaNomina);
                        Parametros[7] = new SqlParameter("@Id_Estado ", entidadNomina.Id_Estado);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[13];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Id_Barbero", entidadNomina.Id_Barbero);
                        Parametros[2] = new SqlParameter("@Fecha_Inicio ", entidadNomina.Fecha_Inicio);
                        Parametros[3] = new SqlParameter("@Fecha_Fin ", entidadNomina.Fecha_Fin);
                        Parametros[4] = new SqlParameter("@CalVtasPtos ", entidadNomina.CalcularVentas);
                        Parametros[5] = new SqlParameter("@Usu_CreaNomina ", entidadNomina.Usu_CreaNomina);
                        Parametros[6] = new SqlParameter("@Fecha_CreaNomina ", entidadNomina.Fecha_CreaNomina);
                        Parametros[7] = new SqlParameter("@Id_Estado ", entidadNomina.Id_Estado);
                        Parametros[8] = new SqlParameter("@Cant_ServPto ", entidadNomina.Cant_ServPto);
                        Parametros[9] = new SqlParameter("@Vlr_Nomina ", entidadNomina.Vlr_Nomina);
                        Parametros[10] = new SqlParameter("@Id_Nomina ", entidadNomina.Id_Nomina);
                        Parametros[11] = new SqlParameter("@Usu_ModNomina ", entidadNomina.Usu_ModNomina);
                        Parametros[12] = new SqlParameter("@Fecha_ModNomina ", entidadNomina.Fecha_ModNomina);

                        break;

                    case "ELIMINAR":

                        Parametros = new SqlParameter[2];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Id_Nomina ", entidadNomina.Id_Nomina);

                        break;

                    case "LISTAR NOMINAS":
                        Parametros = new SqlParameter[3];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        //Parametros[1] = new SqlParameter("@Id_Barbero", entidadNomina.Id_Barbero);
                        Parametros[1] = new SqlParameter("@Fecha_Inicio ", entidadNomina.Fecha_Inicio);
                        Parametros[2] = new SqlParameter("@Fecha_Fin ", entidadNomina.Fecha_Fin);

                        break;

                    case "IMPRIMIR":

                        Parametros = new SqlParameter[4];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Fecha_Inicio ", entidadNomina.Fecha_Inicio);
                        Parametros[2] = new SqlParameter("@Fecha_Fin ", entidadNomina.Fecha_Fin);
                        Parametros[3] = new SqlParameter("@Id_Estado ", entidadNomina.Id_Estado);

                        break;

                    default:
                        return null;
                }

                dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_NOM_NominaCRUD", Parametros);

                return dsDatos;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
    }
}
