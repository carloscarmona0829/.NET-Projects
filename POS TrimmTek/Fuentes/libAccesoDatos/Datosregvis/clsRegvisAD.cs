using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libEntidades.clsEntidadesregvis;
using libConexion;
using System.Configuration;
using libEntidades.Entidadesregvis;

namespace libAccesoDatos.Datosregvis
{
    public class clsRegvisAD
    {

        private libConexion.clsAccesoSQL objDatos = new clsAccesoSQL();

        #region Personas
        public string GuardarPersonas(clsEntidadPersonas personas)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand guardar = new SqlCommand("SP_GuardarPersonasIngresoregvis", con);
                guardar.CommandType = CommandType.StoredProcedure;
                guardar.Parameters.Add("@cedula", SqlDbType.Int).Value = personas.Cedula;
                guardar.Parameters.Add("@primernombre", SqlDbType.NVarChar, 50).Value = personas.PrimerNombre;
                guardar.Parameters.Add("@segundonombre", SqlDbType.NVarChar, 50).Value = personas.SegundoNombre;
                guardar.Parameters.Add("@primerapellido", SqlDbType.NVarChar, 50).Value = personas.PrimerApellido;
                guardar.Parameters.Add("@segundoapellido", SqlDbType.NVarChar, 50).Value = personas.SegundoApellido;
                guardar.Parameters.Add("@CasaId", SqlDbType.Int).Value = personas.CasaId;
                guardar.Parameters.Add("@TipoVisitante", SqlDbType.NVarChar, 25).Value = personas.TipoVisitante;
                guardar.Parameters.Add("@Nota", SqlDbType.NVarChar, 50).Value = personas.Nota;
                guardar.Parameters.Add("@RutaFoto", SqlDbType.NVarChar, 100).Value = personas.RutaFoto;

                SqlDataReader dr = guardar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string ActualizarPersonas(clsEntidadPersonas personas, int personaid)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand actualizar = new SqlCommand("SP_ActualizarPersonas", con);
                actualizar.CommandType = CommandType.StoredProcedure;
                actualizar.Parameters.Add("@personaid", SqlDbType.Int).Value = personaid;
                actualizar.Parameters.Add("@cedula", SqlDbType.Int).Value = personas.Cedula;
                actualizar.Parameters.Add("@primernombre", SqlDbType.NVarChar, 50).Value = personas.PrimerNombre;
                actualizar.Parameters.Add("@segundonombre", SqlDbType.NVarChar, 50).Value = personas.SegundoNombre;
                actualizar.Parameters.Add("@primerapellido", SqlDbType.NVarChar, 50).Value = personas.PrimerApellido;
                actualizar.Parameters.Add("@segundoapellido", SqlDbType.NVarChar, 50).Value = personas.SegundoApellido;
                actualizar.Parameters.Add("@casaid", SqlDbType.Int).Value = personas.CasaId;
                actualizar.Parameters.Add("@tipovisitante", SqlDbType.NVarChar, 25).Value = personas.TipoVisitante;
                actualizar.Parameters.Add("@nota", SqlDbType.NVarChar, 50).Value = personas.Nota;
                actualizar.Parameters.Add("@rutafoto", SqlDbType.NVarChar, 100).Value = personas.RutaFoto;

                SqlDataReader dr = actualizar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public string EliminarPersonas(string personaid)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand Eliminar = new SqlCommand("Delete from tblPersonasIngresoregvis where PersonaIngresoId=" + personaid, con);
                Eliminar.ExecuteNonQuery();

                result = "Registro eliminado correctamente";

                con.Close();

            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarTodasPersonas()
        {
            DataTable dt = new DataTable();
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select ps.Cedula, ps.PrimerNombre AS Primer_Nombre,ps.SegundoNombre as Segundo_Nombre,ps.PrimerApellido as Primer_Apellido,cs.NumeroCasa as Destino,ps.TipoVisitante as Tipo_Visitante,ps.Nota from tblPersonasIngresoregvis PS inner join tblCasaregvis CS ON ps.casaid = cs.CasaId", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select PersonaIngresoId,Cedula, PrimerNombre ,SegundoNombre,PrimerApellido,SegundoApellido ,CasaId,TipoVisitante,Nota, RutaFoto from tblPersonasIngresoregvis where cedula=" + cedula, con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ConsultarVistaPersonaPorCedula(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
     new SqlCommand("select ps.Cedula, ps.PrimerNombre AS Primer_Nombre,ps.SegundoNombre as Segundo_Nombre,ps.PrimerApellido as Primer_Apellido,cs.NumeroCasa as Destino,ps.TipoVisitante as Tipo_Visitante,ps.Nota from tblPersonasIngresoregvis PS inner join tblCasaregvis CS ON ps.casaid = cs.CasaId  where ps.Cedula like '%" + cedula + "%'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ConsultarVistaPersonaPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
     new SqlCommand("select ps.Cedula, ps.PrimerNombre AS Primer_Nombre,ps.SegundoNombre as Segundo_Nombre,ps.PrimerApellido as Primer_Apellido,cs.NumeroCasa as Destino,ps.TipoVisitante as Tipo_Visitante,ps.Nota from tblPersonasIngresoregvis PS inner join tblCasaregvis CS ON ps.casaid = cs.CasaId where ps.primernombre like '%" + nombre + "%'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


        #endregion

        #region Casas
        public string GuardarCasas(clsEntidadCasas Casas)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand guardar = new SqlCommand("SP_GuardarCasasregvis", con);
                guardar.CommandType = CommandType.StoredProcedure;
                guardar.Parameters.Add("@cedula", SqlDbType.Int).Value = Casas.Cedula;
                guardar.Parameters.Add("@numerocasa", SqlDbType.NVarChar, 50).Value = Casas.NumeroCasa;
                guardar.Parameters.Add("@nombrepropietario", SqlDbType.NVarChar, 50).Value = Casas.NombrePropietario;
                SqlDataReader dr = guardar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }

        public DataTable ConsultarTodasCasas()
        {
            DataTable dt = new DataTable();
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select CasaId,Cedula,NumeroCasa,NombrePropietario from tblCasaregvis", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select CasaId,Cedula,NumeroCasa,NombrePropietario from tblCasaregvis where CasaId like '%" + casaid + "%'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select Cedula,NumeroCasa,NombrePropietario from tblCasaregvis where NumeroCasa like '%" + numero + "%'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select Cedula,NumeroCasa,NombrePropietario from tblCasaregvis where NombrePropietario like '%" + nombre + "%'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable CargarCasasComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("SELECT null as CasaId, 'Seleccionar' as NumeroCasa UNION ALL select CasaId,NumeroCasa from tblCasaregvis", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }



        public string ActualizarCasas(clsEntidadCasas casa, int casaid)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand actualizar = new SqlCommand("SP_ActualizarCasasregvis", con);
                actualizar.CommandType = CommandType.StoredProcedure;
                actualizar.Parameters.Add("@casaid", SqlDbType.Int).Value = casaid;
                actualizar.Parameters.Add("@cedula", SqlDbType.Int).Value = casa.Cedula;
                actualizar.Parameters.Add("@numerocasa", SqlDbType.NVarChar, 50).Value = casa.NumeroCasa;
                actualizar.Parameters.Add("@nombrepropietario", SqlDbType.NVarChar, 50).Value = casa.NombrePropietario;

                SqlDataReader dr = actualizar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand Eliminar = new SqlCommand("Delete from tblCasaregvis where CasaId=" + casaid, con);
                Eliminar.ExecuteNonQuery();

                result = "Registro eliminado correctamente";

                con.Close();

            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;
        }
        #endregion

        #region Registro
        public string GuardarRegistro(clsEntidadRegistros registro)
        {
            string result = string.Empty;
            try
            {
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand guardar = new SqlCommand("SP_GuardarRegistroIngresoregvis", con);
                guardar.CommandType = CommandType.StoredProcedure;
                guardar.Parameters.Add("@cedula", SqlDbType.Int).Value = registro.Cedula;
                guardar.Parameters.Add("@nota", SqlDbType.NVarChar, 255).Value = registro.Nota;
                guardar.Parameters.Add("@casaid", SqlDbType.Int).Value = registro.CasaId;
                SqlDataReader dr = guardar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select rg.RegistroId, rg.Cedula, ps.PrimerNombre + ' ' + ps.SegundoNombre as 'Nombre', ps.PrimerApellido + ' ' + ps.SegundoApellido as 'Apellido', ps.RutaFoto ,RG.FechaIngreso,RG.FechaSalida,RG.Nota,CS.NumeroCasa from tblRegistroregvis RG left join tblCasaregvis CS on RG.CasaId = CS.CasaId left join tblPersonasIngresoregvis PS on rg.Cedula =ps.Cedula where CONVERT(date,rg.FechaIngreso)=CONVERT(date,getdate()) or rg.FechaSalida is Null order by rg.FechaIngreso desc", con);
                
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("Select count(*) from tblRegistroregvis where FechaSalida is null", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select TOP 10 rg.RegistroId, RG.Cedula,ps.PrimerNombre + ' ' + ps.SegundoNombre as 'Nombre', ps.PrimerApellido + ' ' + ps.SegundoApellido as 'Apellido' ,RG.FechaIngreso,RG.FechaSalida,RG.Nota,CS.NumeroCasa from tblRegistroregvis RG left join tblCasaregvis CS on RG.CasaId = CS.CasaId left join tblPersonasIngresoregvis PS on rg.Cedula =ps.Cedula where rg.Cedula=" + cedula + " order by FechaIngreso desc", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("set dateformat dmy; select RG.Cedula,ps.PrimerNombre + ' ' + ps.SegundoNombre as 'Nombre', ps.PrimerApellido + ' ' + ps.SegundoApellido as 'Apellido' ,RG.FechaIngreso,RG.FechaSalida,RG.Nota,CS.NumeroCasa from tblRegistroregvis RG left join tblCasaregvis CS on RG.CasaId = CS.CasaId left join tblPersonasIngresoregvis PS on rg.Cedula=ps.Cedula where convert(date, RG.FechaIngreso,103) between '" + fechainicial + "' and '" + fechafinal + "'", con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand guardar = new SqlCommand("SP_RegistrarSalidaregvis", con);
                guardar.CommandType = CommandType.StoredProcedure;
                guardar.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
                SqlDataReader dr = guardar.ExecuteReader();

                while (dr.Read())
                {
                    result = dr["Mensaje"].ToString();
                }

                con.Close();

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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand Validar = new SqlCommand("select count(Cedula) as 'Persona' from tblPersonasIngresoregvis where Cedula=" + cedula, con);

                SqlDataReader dr = Validar.ExecuteReader();

                while (dr.Read())
                {
                    result = Convert.ToInt32(dr["Persona"].ToString());
                }

                con.Close();

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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand Validar = new SqlCommand("select count(Cedula) as 'Persona' from tblRegistroregvis where FechaSalida is null and Cedula=" + cedula, con);

                SqlDataReader dr = Validar.ExecuteReader();

                while (dr.Read())
                {
                    result = Convert.ToInt32(dr["Persona"].ToString());
                }

                con.Close();

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
                string conex = System.Configuration.ConfigurationManager.ConnectionStrings["dbposconexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conex);
                con.Open();
                SqlCommand cmd =
                new SqlCommand("select cs.CasaId,cs.NumeroCasa,ps.TipoVisitante,ps.Nota,ps.PrimerNombre,ps.SegundoNombre,ps.PrimerApellido,ps.SegundoApellido,ps.TipoVisitante,ps.Nota,ps.Cedula, ps.RutaFoto from tblPersonasIngresoregvis ps inner join tblCasaregvis cs on CS.CasaId = ps.CasaId where ps.Cedula=" + cedula, con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }

                con.Close();
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
