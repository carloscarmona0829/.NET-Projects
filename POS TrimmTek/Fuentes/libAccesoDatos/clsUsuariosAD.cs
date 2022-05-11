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
    public class clsUsuariosAD
    {
        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region [Metodos Públicos]

        public DataSet CargarCombosUsuarios()
        {
            try
            {
                return objDatos.TraerDataSet(objDatos.ObtenerConexion("dbPOSConexion"), "SP_CargaCombosUsuarios");
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public DataTable NavegacionUsuarios(string Accion)
        {
            try
            {
                SqlParameter[] ParametrosNavegacionUsuarios = new SqlParameter[1];
                ParametrosNavegacionUsuarios[0] = new SqlParameter("@Accion ", Accion);

                return objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_NavegacionUsuariosCRUD", ParametrosNavegacionUsuarios);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public DataTable UsuariosCrud(string Accion, clsEntidadUsuario entidadUsuario)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;
                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[17];
                        
                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Celular", entidadUsuario.celular);
                        Parametros[3] = new SqlParameter("@Tl_Fijo ", entidadUsuario.fijo);
                        Parametros[4] = new SqlParameter("@FechaNacimiento ", entidadUsuario.fechnto);
                        Parametros[5] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[6] = new SqlParameter("@Contraseña ", entidadUsuario.pwd);
                        Parametros[7] = new SqlParameter("@DirResidencia ", entidadUsuario.dir);
                        Parametros[8] = new SqlParameter("@Id_TipoUsuario ", entidadUsuario.tipouser);
                        Parametros[9] = new SqlParameter("@Id_Perfil ", entidadUsuario.perfil);
                        Parametros[10] = new SqlParameter("@Id_Estado ", entidadUsuario.estado);
                        Parametros[11] = new SqlParameter("@Usu_CreaUsuario ", entidadUsuario.usuAccion);
                        Parametros[12] = new SqlParameter("@Fecha_CreaUsuario ", entidadUsuario.fechAccion);
                        Parametros[13] = new SqlParameter("@Usu_ModUsuario ", entidadUsuario.UsuModifica);
                        Parametros[14] = new SqlParameter("@Fecha_ModUsuario ", entidadUsuario.FechaModifica);
                        Parametros[15] = new SqlParameter("@UsuarioAutorizador ", entidadUsuario.Autorizador);
                        Parametros[16] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[17];

                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Celular", entidadUsuario.celular);
                        Parametros[3] = new SqlParameter("@Tl_Fijo ", entidadUsuario.fijo);
                        Parametros[4] = new SqlParameter("@FechaNacimiento ", entidadUsuario.fechnto);
                        Parametros[5] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[6] = new SqlParameter("@Contraseña ", entidadUsuario.pwd);
                        Parametros[7] = new SqlParameter("@DirResidencia ", entidadUsuario.dir);
                        Parametros[8] = new SqlParameter("@Id_TipoUsuario ", entidadUsuario.tipouser);
                        Parametros[9] = new SqlParameter("@Id_Perfil ", entidadUsuario.perfil);
                        Parametros[10] = new SqlParameter("@Id_Estado ", entidadUsuario.estado);
                        Parametros[11] = new SqlParameter("@Usu_CreaUsuario ", entidadUsuario.usuAccion);
                        Parametros[12] = new SqlParameter("@Fecha_CreaUsuario ", entidadUsuario.fechAccion);
                        Parametros[13] = new SqlParameter("@Usu_ModUsuario ", entidadUsuario.UsuModifica);
                        Parametros[14] = new SqlParameter("@Fecha_ModUsuario ", entidadUsuario.FechaModifica);
                        Parametros[15] = new SqlParameter("@UsuarioAutorizador ", entidadUsuario.Autorizador);
                        Parametros[16] = new SqlParameter("@Accion", Accion);

                        break;

                    case "INHABILITAR":

                        Parametros = new SqlParameter[4];

                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[3] = new SqlParameter("@Accion", Accion);

                        break;

                    case "CONSULTAR":

                        Parametros = new SqlParameter[4];

                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[3] = new SqlParameter("@Accion", Accion);

                        break;

                    case "LISTAUSUARIOS":

                        Parametros = new SqlParameter[5];

                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[3] = new SqlParameter("@Id_TipoUsuario ", entidadUsuario.tipouser);
                        Parametros[4] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR CONTRASEÑA":

                        Parametros = new SqlParameter[8];

                        Parametros[0] = new SqlParameter("@Identificacion", entidadUsuario.IdUsuario);
                        Parametros[1] = new SqlParameter("@Nom_Usuario ", entidadUsuario.nombre);
                        Parametros[2] = new SqlParameter("@Usuario ", entidadUsuario.Usuario);
                        Parametros[3] = new SqlParameter("@Email_Usuario ", entidadUsuario.email);
                        Parametros[4] = new SqlParameter("@Id_TipoUsuario ", entidadUsuario.tipouser);
                        Parametros[5] = new SqlParameter("@Contraseña ", entidadUsuario.pwd);
                        Parametros[6] = new SqlParameter("@Accion", Accion);
                        Parametros[7] = new SqlParameter("@ContraseñaRecibieda ", entidadUsuario.pwdRecibida);

                        break;

                    default:
                        return null;
                        //break;
                }
                dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_MAE_UsuariosCRUD", Parametros);
                return dtDatos;

            }
            catch (Exception Error)
            {
                throw Error;
            }

        }

        public DataTable LoginUsuarios(clsEntidadUsuario entidadUsuario)
        {
            try
            {
                SqlParameter[] ParametrosLogin = new SqlParameter[2];
                ParametrosLogin[0] = new SqlParameter("@Usuario ", entidadUsuario.Usuario);
                ParametrosLogin[1] = new SqlParameter("@Contraseña ", entidadUsuario.pwd);

                return objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_SEG_AutenticarUsuario", ParametrosLogin);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public DataTable RecuperarContraseña(clsEntidadUsuario entidadUsuarios)
        {
            try
            {
                SqlParameter[] ParametrosRecuperarPWD = new SqlParameter[1];
                ParametrosRecuperarPWD[0] = new SqlParameter("@Email ", entidadUsuarios.email);

                return objDatos.TraerDataTable(objDatos.ObtenerConexion("dbPOSConexion"), "SP_SEG_RecuperaPWD", ParametrosRecuperarPWD);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

    }

}
