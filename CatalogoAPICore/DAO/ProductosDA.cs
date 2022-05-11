using DbAccess;
using Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class ProductosDA
    {
        // Instancia del archivo de configuración que tiene el String de conexión 
        //private SqlConnection DbProductos = new SqlConnection("cnn");
        
        // Instancia con el archivo que tiene los métodos que interactúan con la bd (DataSets, Data Tables...)
        private AccesoSQL objDatos = new AccesoSQL();
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS; initial catalog=Universal; user id=sa; password=123456; MultipleActiveResultSets=true");

        public DataSet CargarDdl_Productos()
        {
            try
            {
                return objDatos.TraerDataSet(con, "sp_CargaDdl_Categoria");
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
        public DataTable ProductosCrud(string Accion, Productos entidadProductos)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;
                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[7];
                      
                        Parametros[0] = new SqlParameter("@Nombre", entidadProductos.Nombre);
                        Parametros[1] = new SqlParameter("@Descripcion", entidadProductos.Descripcion);
                        Parametros[2] = new SqlParameter("@Id_Categoria", entidadProductos.Id_Categoria);                        
                        Parametros[3] = new SqlParameter("@Imagen", entidadProductos.Imagen);
                        Parametros[4] = new SqlParameter("@Stock", entidadProductos.Stock);
                        Parametros[5] = new SqlParameter("@Precio", entidadProductos.Precio);
                        Parametros[6] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[7];

                        Parametros[0] = new SqlParameter("@Nombre", entidadProductos.Nombre);
                        Parametros[1] = new SqlParameter("@Descripcion", entidadProductos.Descripcion);
                        Parametros[2] = new SqlParameter("@Id_Categoria", entidadProductos.Id_Categoria);
                        Parametros[3] = new SqlParameter("@Imagen", entidadProductos.Imagen);
                        Parametros[4] = new SqlParameter("@Stock", entidadProductos.Stock);
                        Parametros[5] = new SqlParameter("@Precio", entidadProductos.Precio);
                        Parametros[6] = new SqlParameter("@Accion", Accion);

                        break;


                    case "ELIMINAR":

                        Parametros = new SqlParameter[2];

                        Parametros[0] = new SqlParameter("@Id", entidadProductos.Id);
                        Parametros[1] = new SqlParameter("@Accion", Accion);

                        break;

                    case "BUSCAR":

                        Parametros = new SqlParameter[5];

                        //Parametros[0] = new SqlParameter("@Id", entidadProductos.Id);
                        Parametros[0] = new SqlParameter("@Nombre", entidadProductos.Nombre);
                        Parametros[1] = new SqlParameter("@Descripcion", entidadProductos.Descripcion);
                        Parametros[2] = new SqlParameter("@Categoria", entidadProductos.Categoria);
                        Parametros[3] = new SqlParameter("@Id_Categoria", entidadProductos.Id_Categoria);
                        Parametros[4] = new SqlParameter("@Accion", Accion);

                        break;

                    case "LISTAR":
                        Parametros = new SqlParameter[1];

                        Parametros[0] = new SqlParameter("@Accion", Accion);

                        break;


                    default:
                        return null;
                }
                dtDatos = objDatos.TraerDataTable(con, "sp_Productos_CRUD", Parametros);
                return dtDatos;

            }
            catch (Exception error)
            {
                throw error;
            }
        }        

    }
}
