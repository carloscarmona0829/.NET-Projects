using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libEntidades;
using libConexion;

namespace libAccesoDatos
{
    public class clsFacturacionAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        public DataSet FacturacionCrud(string Accion, clsEntidadFacturacion entidadFacturacion)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                SqlParameter[] Parametros;

                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[14] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);

                        break;

                    case "ACTUALIZAR":

                       Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[14] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);

                        break;

                    case "ANULAR":

                        Parametros = new SqlParameter[17];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@UsuarioAutoriza ", entidadFacturacion.UsuarioAutoriza);
                        Parametros[14] = new SqlParameter("@PwdUsuarioAutoriza ", entidadFacturacion.PwdUsuarioAutoriza);
                        Parametros[15] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[16] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);

                        break;

                    case "CONSULTAR":

                        Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[14] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);

                        break;

                    case "LISTAR FACTURAS":
                        Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[14] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);

                        break;

                    case "LISTAR TURNOS":
                        Parametros = new SqlParameter[1];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_FACT_TurnosCRUD", Parametros);
                        return dsDatos;
                       

                    case "IMPRIMIR":
                       Parametros = new SqlParameter[15];

                        Parametros[0] = new SqlParameter("@Accion", Accion);
                        Parametros[1] = new SqlParameter("@Numero_Factura", entidadFacturacion.Numero_Factura);
                        Parametros[2] = new SqlParameter("@Identificacion_Cliente", entidadFacturacion.Identificacion_Cliente);
                        Parametros[3] = new SqlParameter("@Id_Barbero ", entidadFacturacion.Id_Barbero);
                        Parametros[4] = new SqlParameter("@Usu_CreaFact ", entidadFacturacion.Usu_CreaFact);
                        Parametros[5] = new SqlParameter("@Fecha_Fact ", entidadFacturacion.Fecha_Fact);
                        Parametros[6] = new SqlParameter("@Id_Producto ", entidadFacturacion.Id_Producto);
                        Parametros[7] = new SqlParameter("@Cantidad ", entidadFacturacion.Cantidad);
                        Parametros[8] = new SqlParameter("@Vlr_Unitario ", entidadFacturacion.Vlr_Unitario);
                        Parametros[9] = new SqlParameter("@Id_Factura ", entidadFacturacion.Id_Factura);
                        Parametros[10] = new SqlParameter("@Id_Factura_Det ", entidadFacturacion.Id_Factura_Det);
                        Parametros[11] = new SqlParameter("@Usu_ModFact ", entidadFacturacion.Usu_ModFact);
                        Parametros[12] = new SqlParameter("@Fecha_ModFact ", entidadFacturacion.Fecha_ModFact);
                        Parametros[13] = new SqlParameter("@InsertarEncabezado ", entidadFacturacion.CreaEncabezado);
                        Parametros[14] = new SqlParameter("@CreaTurno ", entidadFacturacion.CrearTruno);


                        break;

                    case "LISTARBARBEROS":
                        dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_CargaCombosFacturacion");
                        return dsDatos;

                    case "LISTAR VENTAS PRODUCTOS":
                        
                        Parametros = new SqlParameter[2];
                        Parametros[0] = new SqlParameter("@FechaInicio", entidadFacturacion.Fecha_Fact);
                        Parametros[1] = new SqlParameter("@FechaFin", entidadFacturacion.Fecha_ModFact);

                        dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_CONS_VENTASPTOS", Parametros);

                    return dsDatos;

                    default:
                        return null;
                        //break;
                }

                dsDatos = objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_FACT_FacturacionCRUD",Parametros);

                return dsDatos;

            }
            catch (Exception Error)
            {
                throw Error;
            }

        }
    }
}
