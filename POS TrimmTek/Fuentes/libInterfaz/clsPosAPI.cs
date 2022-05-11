using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libEntidades;
using libReglasNegocio;
using libreglasnegocio.Reglasregvis;
using libEntidades.clsEntidadesregvis;
using libreglasnegocio;
using libEntidades.Entidadesregvis;

namespace libInterfaz
{
    public class clsPosAPI
    {
        #region [regvis persona]

        public string GuardarPersonasregvis(clsEntidadPersonas persona)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.GuardarPersona(persona);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string ActualizarPersonasregvis(clsEntidadPersonas persona, int personaid)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.ActualizarPersona(persona, personaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string EliminarPersonasregvis(string personaid)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.EliminarPersona(personaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarTodosPersonas()
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarPersonas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarPersonasCedula(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarPersonaCedula(cedula);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarPersonasVistaCedula(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarVistaPersonaCedula(cedula);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarPersonasVistaNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarVistaPersonaNombre(nombre);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        #endregion

        #region [regvis casa]

        public string GuardarCasasregvis(clsEntidadCasas casa)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.GuardarCasa(casa);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string ActualizarCasasregvis(clsEntidadCasas casa, int casaid)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.ActualizarCasa(casa, casaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string EliminarCasaregvis(string casaid)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.EliminarCasa(casaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarTodosCasa()
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarCasas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarCasaModificar(string casaid)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarCasaModificar(casaid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarCasaNumero(string numero)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarCasaNumero(numero);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarCasaNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarCasaNombre(nombre);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable CargarCasaComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.CargarCasaComboBox();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }


        #endregion

        #region  [regvis registro]
        public string GuardarRegistroregvis(clsEntidadRegistros registro)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN guardar = new clsRegvisRN();

                result = guardar.GuardarRegistro(registro);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarTodosRegistros()
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarTodosRegistros();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ContadorPersonasSinSalir()
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ContadorPersonasSinSalir();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }        

        public DataTable ConsultarRegistrosRangoFechas(string fechainicial, string fechafinal)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                dt = consultar.ConsultarRegistrosRangoFechas(fechainicial, fechafinal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable ConsultarPersonaIngreso(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();

                dt = consultar.ConsultarPersonaIngreso(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public string RegistrarSalida(int cedula)
        {
            string result = string.Empty;
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                result = consultar.RegistrarSalida(cedula);
            }
            catch (Exception ex)
            {

                result = ex.Message.ToString();
            }
            return result;
        }

        public int ValidarPersonas(string cedula)
        {
            int result = 0;
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                result = consultar.ValidarPersonas(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int ValidarPersonaSalio(string cedula)
        {
            int result = 0;
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();
                result = consultar.ValidarPersonasalio(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public DataTable ConsultarValidacionPersonasRegistro(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                clsRegvisRN consultar = new clsRegvisRN();

                dt = consultar.ConsultarValidacionPersonasRegistro(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


        #endregion

        #region[Usuarios]

        public DataSet CargarCombosUsuarios()
        {
            try
            {
                clsUsuariosRN objAPI = new clsUsuariosRN();
                return objAPI.CargarCombosUsuarios();

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
                clsUsuariosRN objAPI = new clsUsuariosRN();
                return objAPI.UsuariosCrud(Accion, entidadUsuario);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public DataTable LoginUsuarios(clsEntidadUsuario entidadUsuario)
        {
            try
            {
                clsUsuariosRN objApi = new clsUsuariosRN();
                return objApi.LoginUsuarios(entidadUsuario);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable RecuperarContraseña(clsEntidadUsuario entidadUsuario)
        {
            try
            {
                clsUsuariosRN objApi = new clsUsuariosRN();
                return objApi.RecuperarContraseña(entidadUsuario);
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        #endregion

        #region [Perfiles]
        public DataTable PerfilesCrud(string Accion, clsEntidadPerfil entidadPerfil)
        {
            try
            {
                clsPerfilesRN objAPI = new clsPerfilesRN();
                return objAPI.PerfilesCrud(Accion, entidadPerfil);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        #endregion

        #region [PermisosAPerfil]

        public DataSet CargarCombosPermisosAPerfiles()
        {
            try
            {
                clsPermisosAPerfilesRN objApi = new clsPermisosAPerfilesRN();
                return objApi.CargarCombosPermisosAPerfiles();
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }
        public DataTable PermisosAPerfilCRUD(string Accion, clsEntidadPermisosAPerfil entidadPermisosAPerfil)
        {
            try
            {
                clsPermisosAPerfilesRN objAPI = new clsPermisosAPerfilesRN();
                return objAPI.PermisosAPerfilCRUD(Accion, entidadPermisosAPerfil);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

        #region [ModulosDelSistema]

        public DataTable ModulosSistemaCRUD(string Accion, clsEntidadModulosDelSistema entidadModulosDelSistema)
        {
            try
            {
                clsModulosSistemaRN obAPI = new clsModulosSistemaRN();
                return obAPI.ModulosSistemaCRUD(Accion, entidadModulosDelSistema);
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        #endregion

        #region [Facturacion]

        public DataSet FacturacionCrud(string Accion, clsEntidadFacturacion entidadFacturacion)
        {
            clsFacturacionRN objAPI = new clsFacturacionRN();
            return objAPI.FacturacionCrud(Accion, entidadFacturacion);
        }

        #endregion

        #region[Productos]

        public DataSet CargarCombosProveedoryTipoProducto()
        {
            try
            {
                clsProductosRN objApi = new clsProductosRN();
                return objApi.CargarCombosProveedoryTipoProducto();
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
                clsProductosRN objAPI = new clsProductosRN();
                return objAPI.ProductosCrud(Accion, entidadProductos);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        #endregion

        #region [Cierre]

        public DataSet CierreDia(string Accion, clsEntidadCierre entidadCierre)
        {
            try
            {
                clsCierreRN objApi = new clsCierreRN();
                return objApi.CierreDia(Accion, entidadCierre);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

        #region [Nómina]

        public DataSet Nomina(string Accion, clsEntidadNomina entidadNomina)
        {
            try
            {
                clsNominaRN objApi = new clsNominaRN();
                return objApi.Nomina(Accion, entidadNomina);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

        #region [ParametrosFacturacion]

        public DataSet ParametrosFacturacion()
        {
            try
            {
                clsParametrosFacturacionRN objApi = new clsParametrosFacturacionRN();
                return objApi.ParametrosFacturacion();
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

        #region [Proveedores]

        public DataTable ProveedoresCrud(string Accion, clsEntidadProveedor entidadProveedor)
        {
            try
            {
                clsProveedoresRN objApi = new clsProveedoresRN();
                return objApi.ProveedoresCrud(Accion, entidadProveedor);
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        #endregion

        #region [Inventario]

        public DataSet Inventario(string Accion, string actualizarProductos)
        {
            try
            {
                clsInventarioRN objApi = new clsInventarioRN();
                return objApi.Inventario(Accion, actualizarProductos);
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        #endregion


    }
}
