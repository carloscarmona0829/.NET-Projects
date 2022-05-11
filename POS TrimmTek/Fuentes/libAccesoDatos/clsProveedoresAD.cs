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
    public class clsProveedoresAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Metodos Públicos]

        public DataTable ProveedoresCrud(string Accion, clsEntidadProveedor entidadProveedor)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;
                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[14];

                        Parametros[0] = new SqlParameter("@NIT", entidadProveedor.NIT);
                        Parametros[1] = new SqlParameter("@Razon_Social ", entidadProveedor.Razon_Social);
                        Parametros[2] = new SqlParameter("@Email_Proveedor", entidadProveedor.Email_Proveedor);
                        Parametros[3] = new SqlParameter("@Celular ", entidadProveedor.Celular);
                        Parametros[4] = new SqlParameter("@Tl_Fijo ", entidadProveedor.Tl_Fijo);
                        Parametros[5] = new SqlParameter("@DirProveedor ", entidadProveedor.DirProveedor);
                        Parametros[6] = new SqlParameter("@Id_Estado ", entidadProveedor.Id_Estado);
                        Parametros[7] = new SqlParameter("@Nombre_Contacto ", entidadProveedor.Nombre_Contacto);
                        Parametros[8] = new SqlParameter("@Id_Proveedor ", entidadProveedor.Id_Proveedor);
                        Parametros[9] = new SqlParameter("@Usu_CreaProveedor ", entidadProveedor.Usu_CreaProveedor);
                        Parametros[10] = new SqlParameter("@Fecha_CreaProveedor ", entidadProveedor.Fecha_CreaProveedor);
                        Parametros[11] = new SqlParameter("@Usu_ModProveedor ", entidadProveedor.Usu_ModProveedor);
                        Parametros[12] = new SqlParameter("@Fecha_ModProveedor ", entidadProveedor.Fecha_ModProveedor);
                        Parametros[13] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[14];

                        Parametros[0] = new SqlParameter("@NIT", entidadProveedor.NIT);
                        Parametros[1] = new SqlParameter("@Razon_Social ", entidadProveedor.Razon_Social);
                        Parametros[2] = new SqlParameter("@Email_Proveedor", entidadProveedor.Email_Proveedor);
                        Parametros[3] = new SqlParameter("@Celular ", entidadProveedor.Celular);
                        Parametros[4] = new SqlParameter("@Tl_Fijo ", entidadProveedor.Tl_Fijo);
                        Parametros[5] = new SqlParameter("@DirProveedor ", entidadProveedor.DirProveedor);
                        Parametros[6] = new SqlParameter("@Id_Estado ", entidadProveedor.Id_Estado);
                        Parametros[7] = new SqlParameter("@Nombre_Contacto ", entidadProveedor.Nombre_Contacto);
                        Parametros[8] = new SqlParameter("@Id_Proveedor ", entidadProveedor.Id_Proveedor);
                        Parametros[9] = new SqlParameter("@Usu_CreaProveedor ", entidadProveedor.Usu_CreaProveedor);
                        Parametros[10] = new SqlParameter("@Fecha_CreaProveedor ", entidadProveedor.Fecha_CreaProveedor);
                        Parametros[11] = new SqlParameter("@Usu_ModProveedor ", entidadProveedor.Usu_ModProveedor);
                        Parametros[12] = new SqlParameter("@Fecha_ModProveedor ", entidadProveedor.Fecha_ModProveedor);
                        Parametros[13] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ELIMINAR":

                        Parametros = new SqlParameter[3];

                        Parametros[0] = new SqlParameter("@NIT", entidadProveedor.NIT);
                        Parametros[1] = new SqlParameter("@Id_Proveedor ", entidadProveedor.Id_Proveedor);
                        Parametros[2] = new SqlParameter("@Accion", Accion);

                        break;


                    case "LISTAR PROVEEDORES":

                        Parametros = new SqlParameter[10];

                        Parametros[0] = new SqlParameter("@NIT", entidadProveedor.NIT);
                        Parametros[1] = new SqlParameter("@Razon_Social ", entidadProveedor.Razon_Social);
                        Parametros[2] = new SqlParameter("@Email_Proveedor", entidadProveedor.Email_Proveedor);
                        Parametros[3] = new SqlParameter("@Celular ", entidadProveedor.Celular);
                        Parametros[4] = new SqlParameter("@Tl_Fijo ", entidadProveedor.Tl_Fijo);
                        Parametros[5] = new SqlParameter("@DirProveedor ", entidadProveedor.DirProveedor);
                        Parametros[6] = new SqlParameter("@Id_Estado ", entidadProveedor.Id_Estado);
                        Parametros[7] = new SqlParameter("@Nombre_Contacto ", entidadProveedor.Nombre_Contacto);
                        Parametros[8] = new SqlParameter("@Id_Proveedor ", entidadProveedor.Id_Proveedor);
                        Parametros[9] = new SqlParameter("@Accion", Accion);

                        break;

                    default:
                        return null;
                        break;
                }
                dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_ProveedoresCRUD", Parametros);
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
