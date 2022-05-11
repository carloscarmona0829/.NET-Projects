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
    public class clsPermisosAPerfilesAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Métodos Públicos]

        public DataSet CargarCombosPermisosAPerfiles()
        {
            try
            {
                return objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_CargaCombosPermiPerfiles");
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public DataTable PermisosAPerfilCRUD(string Accion, clsEntidadPermisosAPerfil entidadPermisosPorPerfil)
        {
            try
            {
                DataTable dtDatos = new DataTable();

                switch (Accion)
                {
                    case "INSERTAR":

                        SqlParameter[] ParametrosInsertar = new SqlParameter[8];
                        ParametrosInsertar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInsertar[1] = new SqlParameter("@Id_Modulo", entidadPermisosPorPerfil.Id_Modulo);
                        ParametrosInsertar[2] = new SqlParameter("@Id_Perfil", entidadPermisosPorPerfil.Id_Perfil);
                        ParametrosInsertar[3] = new SqlParameter("@Usu_CreaUsuario", entidadPermisosPorPerfil.Usu_CreaUsuario);
                        ParametrosInsertar[4] = new SqlParameter("@Fecha_CreaUsuario", entidadPermisosPorPerfil.Fecha_CreaUsuario);
                        ParametrosInsertar[5] = new SqlParameter("@Usu_ModUsuario", entidadPermisosPorPerfil.Usu_ModUsuario);
                        ParametrosInsertar[6] = new SqlParameter("@Fecha_ModUsuario", entidadPermisosPorPerfil.Fecha_ModUsuario);
                        ParametrosInsertar[7] = new SqlParameter("@Id_PermiPerfil", entidadPermisosPorPerfil.Id_PermiPerfil);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "[SP_MAE_PermiPerfiCRUD]", ParametrosInsertar);

                        break;

                    case "ACTUALIZAR":

                        SqlParameter[] ParametrosActualizar = new SqlParameter[8];
                        ParametrosActualizar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosActualizar[1] = new SqlParameter("@Id_Modulo", entidadPermisosPorPerfil.Id_Modulo);
                        ParametrosActualizar[2] = new SqlParameter("@Id_Perfil", entidadPermisosPorPerfil.Id_Perfil);
                        ParametrosActualizar[3] = new SqlParameter("@Usu_CreaUsuario", entidadPermisosPorPerfil.Usu_CreaUsuario);
                        ParametrosActualizar[4] = new SqlParameter("@Fecha_CreaUsuario", entidadPermisosPorPerfil.Fecha_CreaUsuario);
                        ParametrosActualizar[5] = new SqlParameter("@Usu_ModUsuario", entidadPermisosPorPerfil.Usu_ModUsuario);
                        ParametrosActualizar[6] = new SqlParameter("@Fecha_ModUsuario", entidadPermisosPorPerfil.Fecha_ModUsuario);
                        ParametrosActualizar[7] = new SqlParameter("@Id_PermiPerfil", entidadPermisosPorPerfil.Id_PermiPerfil);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "[SP_MAE_PermiPerfiCRUD]", ParametrosActualizar);

                        break;

                    case "ELIMINAR":

                        SqlParameter[] ParametrosInhabilitar = new SqlParameter[8];
                        ParametrosInhabilitar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInhabilitar[1] = new SqlParameter("@Id_Modulo", entidadPermisosPorPerfil.Id_Modulo);
                        ParametrosInhabilitar[2] = new SqlParameter("@Id_Perfil", entidadPermisosPorPerfil.Id_Perfil);
                        ParametrosInhabilitar[3] = new SqlParameter("@Usu_CreaUsuario", entidadPermisosPorPerfil.Usu_CreaUsuario);
                        ParametrosInhabilitar[4] = new SqlParameter("@Fecha_CreaUsuario", entidadPermisosPorPerfil.Fecha_CreaUsuario);
                        ParametrosInhabilitar[5] = new SqlParameter("@Usu_ModUsuario", entidadPermisosPorPerfil.Usu_ModUsuario);
                        ParametrosInhabilitar[6] = new SqlParameter("@Fecha_ModUsuario", entidadPermisosPorPerfil.Fecha_ModUsuario);
                        ParametrosInhabilitar[7] = new SqlParameter("@Id_PermiPerfil", entidadPermisosPorPerfil.Id_PermiPerfil);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "[SP_MAE_PermiPerfiCRUD]", ParametrosInhabilitar);

                        break;

                    case "CONSULTAR":

                        SqlParameter[] ParametrosConsultar = new SqlParameter[8];
                        ParametrosConsultar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosConsultar[1] = new SqlParameter("@Id_Modulo", entidadPermisosPorPerfil.Id_Modulo);
                        ParametrosConsultar[2] = new SqlParameter("@Id_Perfil", entidadPermisosPorPerfil.Id_Perfil);
                        ParametrosConsultar[3] = new SqlParameter("@Usu_CreaUsuario", entidadPermisosPorPerfil.Usu_CreaUsuario);
                        ParametrosConsultar[4] = new SqlParameter("@Fecha_CreaUsuario", entidadPermisosPorPerfil.Fecha_CreaUsuario);
                        ParametrosConsultar[5] = new SqlParameter("@Usu_ModUsuario", entidadPermisosPorPerfil.Usu_ModUsuario);
                        ParametrosConsultar[6] = new SqlParameter("@Fecha_ModUsuario", entidadPermisosPorPerfil.Fecha_ModUsuario);
                        ParametrosConsultar[7] = new SqlParameter("@Id_PermiPerfil", entidadPermisosPorPerfil.Id_PermiPerfil);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "[SP_MAE_PermiPerfiCRUD]", ParametrosConsultar);

                        break;

                    default:
                        return null;
                        break;
                }
                return dtDatos;

            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion
    }
}
