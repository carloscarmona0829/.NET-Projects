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
    public class clsProductosAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Metodos Públicos]

        public DataSet CargarCombosProveedoryTipoProducto()
        {
            try
            {
                return objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_CargarCombosProductos");
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public DataTable ProductosCrud(string Accion, clsEntidadProductos entidadProductos)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;

                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[11];

                        Parametros[0] = new SqlParameter("@Nom_Producto", entidadProductos.Producto);
                        Parametros[1] = new SqlParameter("@Costo", entidadProductos.Costo);
                        Parametros[2] = new SqlParameter("@PVP", entidadProductos.PVP);
                        Parametros[3] = new SqlParameter("@Id_Proveedor", entidadProductos.Id_Proveedor);
                        Parametros[4] = new SqlParameter("@Codigo_Barras", entidadProductos.Codigo_Barras);
                        Parametros[5] = new SqlParameter("@Id_TipoProducto", entidadProductos.Id_TipoProducto);
                        Parametros[6] = new SqlParameter("@Cant_Minima", entidadProductos.Cant_Minima);
                        Parametros[7] = new SqlParameter("@Cant_Stock", entidadProductos.Cant_Stock);
                        Parametros[8] = new SqlParameter("@Usu_CreaProducto", entidadProductos.Usu_CreaProducto);
                        Parametros[9] = new SqlParameter("@Fecha_CreaProducto", entidadProductos.Fecha_CreaProducto);
                        Parametros[10] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[14];

                        Parametros[0] = new SqlParameter("@Nom_Producto", entidadProductos.Producto);
                        Parametros[1] = new SqlParameter("@Costo", entidadProductos.Costo);
                        Parametros[2] = new SqlParameter("@PVP", entidadProductos.PVP);
                        Parametros[3] = new SqlParameter("@Id_Proveedor", entidadProductos.Id_Proveedor);
                        Parametros[4] = new SqlParameter("@Codigo_Barras", entidadProductos.Codigo_Barras);
                        Parametros[5] = new SqlParameter("@Id_TipoProducto", entidadProductos.Id_TipoProducto);
                        Parametros[6] = new SqlParameter("@Cant_Minima", entidadProductos.Cant_Minima);
                        Parametros[7] = new SqlParameter("@Cant_Stock", entidadProductos.Cant_Stock);
                        Parametros[8] = new SqlParameter("@Usu_CreaProducto", entidadProductos.Usu_CreaProducto);
                        Parametros[9] = new SqlParameter("@Fecha_CreaProducto", entidadProductos.Fecha_CreaProducto);
                        Parametros[10] = new SqlParameter("@Id_Producto", entidadProductos.Id_Producto);
                        Parametros[11] = new SqlParameter("@Usu_ModProducto", entidadProductos.Usu_ModProducto);
                        Parametros[12] = new SqlParameter("@Fecha_ModProducto", entidadProductos.Fecha_ModProducto);
                        Parametros[13] = new SqlParameter("@Accion", Accion);

                        break;

                    case "INHABILITAR":

                    Parametros = new SqlParameter[14];

                        Parametros[0] = new SqlParameter("@Nom_Producto", entidadProductos.Producto);
                        Parametros[1] = new SqlParameter("@Costo", entidadProductos.Costo);
                        Parametros[2] = new SqlParameter("@PVP", entidadProductos.PVP);
                        Parametros[3] = new SqlParameter("@Id_Proveedor", entidadProductos.Id_Proveedor);
                        Parametros[4] = new SqlParameter("@Codigo_Barras", entidadProductos.Codigo_Barras);
                        Parametros[5] = new SqlParameter("@Id_TipoProducto", entidadProductos.Id_TipoProducto);
                        Parametros[6] = new SqlParameter("@Cant_Minima", entidadProductos.Cant_Minima);
                        Parametros[7] = new SqlParameter("@Cant_Stock", entidadProductos.Cant_Stock);
                        Parametros[8] = new SqlParameter("@Usu_CreaProducto", entidadProductos.Usu_CreaProducto);
                        Parametros[9] = new SqlParameter("@Fecha_CreaProducto", entidadProductos.Fecha_CreaProducto);
                        Parametros[10] = new SqlParameter("@Id_Producto", entidadProductos.Id_Producto);
                        Parametros[11] = new SqlParameter("@Usu_ModProducto", entidadProductos.Usu_ModProducto);
                        Parametros[12] = new SqlParameter("@Fecha_ModProducto", entidadProductos.Fecha_ModProducto);
                        Parametros[13] = new SqlParameter("@Accion", Accion);

                        break;

                    case "LISTAR":

                        Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Nom_Producto", String.Empty);
                        Parametros[1] = new SqlParameter("@Costo", "0");
                        Parametros[2] = new SqlParameter("@PVP", "0");
                        Parametros[3] = new SqlParameter("@Id_Proveedor", "0");
                        Parametros[4] = new SqlParameter("@Codigo_Barras", String.Empty);
                        Parametros[5] = new SqlParameter("@Id_TipoProducto", "0");
                        Parametros[6] = new SqlParameter("@Cant_Minima", "0");
                        Parametros[7] = new SqlParameter("@Cant_Stock", "0");
                        Parametros[8] = new SqlParameter("@Id_Estado", "0");
                        Parametros[9] = new SqlParameter("@Usu_CreaProducto", String.Empty);
                        Parametros[10] = new SqlParameter("@Fecha_CreaProducto", String.Empty);
                        Parametros[11] = new SqlParameter("@Id_Producto", "0");
                        Parametros[12] = new SqlParameter("@Usu_ModProducto", String.Empty);
                        Parametros[13] = new SqlParameter("@Fecha_ModProducto", String.Empty);
                        Parametros[14] = new SqlParameter("@Accion", Accion);

                        break;

                    default:
                        return null;
                        //break;
                }

                dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "[SP_MAE_ProductosCRUD]", Parametros);
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
