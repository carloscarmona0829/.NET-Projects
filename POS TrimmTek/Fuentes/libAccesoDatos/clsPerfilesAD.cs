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
    public class clsPerfilesAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Perfiles]

        public DataTable PerfilesCrud(string Accion, clsEntidadPerfil entidadPerfil)
        {
            try
            {
                DataTable dtDatos = new DataTable();

                switch (Accion)
                {
                    case "INSERTAR":

                        SqlParameter[] ParametrosInsertar = new SqlParameter[2];
                        ParametrosInsertar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInsertar[1] = new SqlParameter("@Descripcion", entidadPerfil.Perfil);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_PerfilesCRUD", ParametrosInsertar);

                        break;

                    case "ACTUALIZAR":

                        SqlParameter[] ParametrosActualizar = new SqlParameter[3];
                        ParametrosActualizar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosActualizar[1] = new SqlParameter("@Descripcion", entidadPerfil.Perfil);
                        ParametrosActualizar[2] = new SqlParameter("@Id_Lista", entidadPerfil.IdPerfil);
                       
                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_PerfilesCRUD", ParametrosActualizar);

                        break;

                    case "INHABILITAR":

                        SqlParameter[] ParametrosInhabilitar = new SqlParameter[3];
                        ParametrosInhabilitar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInhabilitar[1] = new SqlParameter("@Descripcion", entidadPerfil.Perfil);
                        ParametrosInhabilitar[2] = new SqlParameter("@Id_Lista", entidadPerfil.IdPerfil);
                       
                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_PerfilesCRUD", ParametrosInhabilitar);

                        break;

                    case "CONSULTAR":

                        SqlParameter[] ParametrosConsultar = new SqlParameter[3];
                        ParametrosConsultar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosConsultar[1] = new SqlParameter("@Descripcion", entidadPerfil.Perfil);
                        ParametrosConsultar[2] = new SqlParameter("@Id_Lista", entidadPerfil.IdPerfil);
                       
                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_PerfilesCRUD", ParametrosConsultar);

                        break;

                    default:
                        return null;
                        //break;
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
