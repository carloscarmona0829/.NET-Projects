using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libEntidades.clsEntidadesregvis;
using libEntidades.Entidadesregvis;
using System.Data;

namespace libreglasnegocio.Reglasregvis
{
    public class clsRegvisRN
    {
        #region personas
        public string GuardarPersona(clsEntidadPersonas persona)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.GuardarPersonas(persona);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string ActualizarPersona(clsEntidadPersonas persona, int personaid)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.ActualizarPersonas(persona, personaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string EliminarPersona(string personaid)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.EliminarPersonas(personaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarPersonas()
        {
            DataTable dt = new DataTable();
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarTodasPersonas();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ConsultarPersonaCedula(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarPersonaCedula(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ConsultarVistaPersonaCedula(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarVistaPersonaPorCedula(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ConsultarVistaPersonaNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarVistaPersonaPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        #endregion

        #region Casas
        public string GuardarCasa(clsEntidadCasas casa)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.GuardarCasas(casa);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string ActualizarCasa(clsEntidadCasas casa, int casaid)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.ActualizarCasas(casa, casaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string EliminarCasa(string casaid)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.EliminarCasa(casaid);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarCasas()
        {
            DataTable dt = new DataTable();
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarTodasCasas();
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarCasaModificar(casaid);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarCasaNumero(numero);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarCasaNombre(nombre);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.CargarCasasComboBox();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


        #endregion

        #region Registros
        public string GuardarRegistro(clsEntidadRegistros registro)
        {
            string result = string.Empty;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.GuardarRegistro(registro);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarTodosRegistros();
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ContadorPersonasSinSalir();
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarRegistrosRangoFechas(fechainicial, fechafinal);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarPersonaIngreso(cedula);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.RegistrarSalida(cedula);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.ValidarPersonas(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int ValidarPersonasalio(string cedula)
        {
            int result = 0;
            try
            {
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                result = datos.ValidarPersonaSalio(cedula);
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
                libAccesoDatos.Datosregvis.clsRegvisAD datos = new libAccesoDatos.Datosregvis.clsRegvisAD();
                dt = datos.ConsultarValidacionPersonasRegistro(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        #endregion

    }
}
