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
    public class clsModulosSistemaAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Modulos Del Sistema]

        public DataTable ModulosSistemaCRUD(string Accion, clsEntidadModulosDelSistema entidadModulosDelSistema)
        {
            try
            {
                DataTable dtDatos = new DataTable();

                switch (Accion)
                {
                    case "INSERTAR":

                        SqlParameter[] ParametrosInsertar = new SqlParameter[3];
                        ParametrosInsertar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInsertar[1] = new SqlParameter("@Descripcion", entidadModulosDelSistema.Descripcion);
                        ParametrosInsertar[2] = new SqlParameter("@Id_Lista", entidadModulosDelSistema.Id_Lista);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_ModuSistemaCRUD", ParametrosInsertar);

                        break;

                    case "ACTUALIZAR":

                        SqlParameter[] ParametrosActualizar = new SqlParameter[3];
                        ParametrosActualizar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosActualizar[1] = new SqlParameter("@Descripcion", entidadModulosDelSistema.Descripcion);
                        ParametrosActualizar[2] = new SqlParameter("@Id_Lista", entidadModulosDelSistema.Id_Lista);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_ModuSistemaCRUD", ParametrosActualizar);

                        break;

                    case "INHABILITAR":

                        SqlParameter[] ParametrosInhabilitar = new SqlParameter[3];
                        ParametrosInhabilitar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosInhabilitar[1] = new SqlParameter("@Descripcion", entidadModulosDelSistema.Descripcion);
                        ParametrosInhabilitar[2] = new SqlParameter("@Id_Lista", entidadModulosDelSistema.Id_Lista);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_ModuSistemaCRUD", ParametrosInhabilitar);

                        break;

                    case "CONSULTAR":

                        SqlParameter[] ParametrosConsultar = new SqlParameter[3];
                        ParametrosConsultar[0] = new SqlParameter("@Accion", Accion);
                        ParametrosConsultar[1] = new SqlParameter("@Descripcion", entidadModulosDelSistema.Descripcion);
                        ParametrosConsultar[2] = new SqlParameter("@Id_Lista", entidadModulosDelSistema.Id_Lista);

                        dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_ModuSistemaCRUD", ParametrosConsultar);

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
