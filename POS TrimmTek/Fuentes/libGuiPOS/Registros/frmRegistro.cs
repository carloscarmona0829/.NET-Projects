using libInterfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libGuiPOS.Registros
{
    public partial class frmRegistro : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        //Variable global que almacena la ruta de la foto
        string RutaFoto;

        public frmRegistro()
        {
            InitializeComponent();
        }

        #region [Métodos]

        public void MostrarRegistros()
        {
            try
            {
                dtgregistros.DataSource = objApi.ConsultarTodosRegistros();
                int contador = Convert.ToInt32(objApi.ContadorPersonasSinSalir().Rows[0][0].ToString());
                dtgregistros.Refresh();
                lblcontador.Text = Convert.ToString(contador);
                dtgregistros.Columns["RutaFoto"].Visible = false;
                dtgregistros.Columns["RegistroId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }

        }

        public void LimpiarCampos()
        {
            lblregistroid.Text = "";
            lblcontador.Text = "";
            txtcedula.Text = "";
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            txtnota.Text = "";
            cmbtipovisitante.Text = "";
            txtdestino.Clear();
            pbFoto.Image= libGuiPOS.Properties.Resources.user_128;
            dtfechainicial.Value = DateTime.Now.AddDays(0);
            dtfechafinal.Value = DateTime.Now.AddDays(0);
            MostrarRegistros();
            txtcedula.Focus();
            lblcasaid.Text = "";
            txtdestino.Clear();
        }

        public void Consultar()
        {
            try
            {
                DataTable dt = new DataTable();

                if (txtcedula.Text != "")
                {
                    dt = objApi.ConsultarPersonaIngreso(txtcedula.Text);

                    if (dt.Rows.Count > 0)
                    {
                        dtgregistros.DataSource = dt;
                        dtgregistros.Refresh();
                        dtgregistros.Columns["RegistroId"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No existe cedula registrada en la base de datos", "Sistema REG", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }

        }

        private bool CrearUsuario()
        {
            try
            {

                frmPersonasIngreso abrirFormUsuarioPersonas = new frmPersonasIngreso();
                abrirFormUsuarioPersonas.FormularioEjecutorEsRegistro = "Registro";
                abrirFormUsuarioPersonas.Cedula = txtcedula.Text.Trim();
                abrirFormUsuarioPersonas.PrimerApellido = txtprimerapellido.Text.Trim();
                abrirFormUsuarioPersonas.SegundoApellido = txtsegundoapellido.Text.Trim();
                abrirFormUsuarioPersonas.PrimerNombre = txtprimernombre.Text.Trim();
                abrirFormUsuarioPersonas.SegundoNombre = txtsegundonombre.Text.Trim();
                //Cierra el formulario de regitro
                this.Close();
                //Abre el formulario de personaingreso
                abrirFormUsuarioPersonas.ShowDialog();

                if (abrirFormUsuarioPersonas.GuardoUsuario)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void BusquedaRango()
        {
            try
            {
                string fechainicial = dtfechainicial.Value.Date.ToShortDateString();
                string fechafinal = dtfechafinal.Value.Date.ToShortDateString();
                DataTable dt = new DataTable();

                dt = objApi.ConsultarRegistrosRangoFechas(fechainicial, fechafinal);

                if (dt.Rows.Count > 0)
                {
                    dtgregistros.DataSource = dt;
                    dtgregistros.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void Registrar()
        {
            try
            {
                libEntidades.Entidadesregvis.clsEntidadRegistros registro = new libEntidades.Entidadesregvis.clsEntidadRegistros();
                string result = string.Empty;
                int validarExistePersona, validarsalida;
                DataTable dt = new DataTable();

                if (string.IsNullOrEmpty(txtcedula.Text))
                {
                    MessageBox.Show("Debe llenar el campo cédula antes de guardar", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                validarExistePersona = objApi.ValidarPersonas(txtcedula.Text);

                if (validarExistePersona == 0)
                {
                    if (CrearUsuario())
                    {
                        return;
                    }
                }
                else
                {
                    #region[Registro de salida]

                    validarsalida = objApi.ValidarPersonaSalio(txtcedula.Text);
                    if (validarsalida > 0)
                    {
                        result = objApi.RegistrarSalida(Convert.ToInt32(txtcedula.Text));
                        result = objApi.GuardarRegistroregvis(registro);
                        //dt trae los datos para mostrar en el formulario
                        dt = objApi.ConsultarValidacionPersonasRegistro(txtcedula.Text);
                        //Las siguientes lineas de asignación, carga los datos guardados en la bd a los campos del formulario
                        txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                        txtprimernombre.Text = dt.Rows[0]["PrimerNombre"].ToString();
                        txtsegundonombre.Text = dt.Rows[0]["SegundoNombre"].ToString();
                        txtprimerapellido.Text = dt.Rows[0]["PrimerApellido"].ToString();
                        txtsegundoapellido.Text = dt.Rows[0]["SegundoApellido"].ToString();
                        txtnota.Text = dt.Rows[0]["Nota"].ToString();
                        cmbtipovisitante.SelectedText = dt.Rows[0]["TipoVisitante"].ToString();
                        txtdestino.Text = dt.Rows[0]["NumeroCasa"].ToString();
                        RutaFoto = dt.Rows[0]["RutaFoto"].ToString();
                        if (string.IsNullOrEmpty(dt.Rows[0]["RutaFoto"].ToString()))
                        {
                            pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                        }
                        else
                        {
                            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            //Comprueba que el archivo .jpg si exista en la carpeta de fotos
                            bool fileExists = (System.IO.File.Exists(RutaFoto) ? true : false);
                            if (fileExists != true)
                            {
                                pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                                return;
                            }
                            pbFoto.Image = (Image)Image.FromFile(dt.Rows[0]["RutaFoto"].ToString());
                        }
                        //MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        txtcedula.Focus();
                        txtcedula.SelectAll();
                        MostrarRegistros();
                    }
                    else
                    {
                        #endregion

                        #region [Registro de ingreso]

                        dt = objApi.ConsultarValidacionPersonasRegistro(txtcedula.Text);
                        if (dt.Rows.Count > 0)
                        {
                            //Si usuario es de Tipo Contratista o Empleado Interno
                            if (dt.Rows[0]["TipoVisitante"].ToString() == "Empleado Interno" || dt.Rows[0]["TipoVisitante"].ToString() == "Contratista")
                            {
                                registro.Cedula = Convert.ToInt32(txtcedula.Text);
                                registro.Nota = Convert.ToString(dt.Rows[0]["Nota"].ToString());
                                registro.CasaId = Convert.ToInt32(dt.Rows[0]["CasaId"].ToString());
                                result = objApi.GuardarRegistroregvis(registro);
                                //Trae los datos guardados a los campos del formulario
                                txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                                txtprimernombre.Text = dt.Rows[0]["PrimerNombre"].ToString();
                                txtsegundonombre.Text = dt.Rows[0]["SegundoNombre"].ToString();
                                txtprimerapellido.Text = dt.Rows[0]["PrimerApellido"].ToString();
                                txtsegundoapellido.Text = dt.Rows[0]["SegundoApellido"].ToString();
                                txtnota.Text = dt.Rows[0]["Nota"].ToString();
                                cmbtipovisitante.SelectedText = dt.Rows[0]["TipoVisitante"].ToString();
                                txtdestino.Text = dt.Rows[0]["NumeroCasa"].ToString();
                                RutaFoto = dt.Rows[0]["RutaFoto"].ToString();
                                if (string.IsNullOrEmpty(dt.Rows[0]["RutaFoto"].ToString()))
                                {
                                    pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                                }
                                else
                                {
                                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                                    //Comprueba que el archivo .jpg si exista en la carpeta de fotos
                                    bool fileExists = (System.IO.File.Exists(RutaFoto) ? true : false);
                                    if (fileExists != true)
                                    {
                                        pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                                        return;
                                    }
                                    pbFoto.Image = (Image)Image.FromFile(dt.Rows[0]["RutaFoto"].ToString());
                                }
                                //MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtcedula.Focus();
                                txtcedula.SelectAll();
                                MostrarRegistros();

                            }
                            else
                            {
                                //Si el usuario de de tipo visitante u Otro
                                string Nota = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su destino", "Sistema REG");
                                registro.CasaId = Convert.ToInt32(dt.Rows[0]["CasaId"].ToString());
                                registro.Nota = Nota;
                                registro.Cedula = Convert.ToInt32(txtcedula.Text);
                                result = objApi.GuardarRegistroregvis(registro);
                                //Trae los datos guardados a los campos del formulario
                                txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                                txtprimernombre.Text = dt.Rows[0]["PrimerNombre"].ToString();
                                txtsegundonombre.Text = dt.Rows[0]["SegundoNombre"].ToString();
                                txtprimerapellido.Text = dt.Rows[0]["PrimerApellido"].ToString();
                                txtsegundoapellido.Text = dt.Rows[0]["SegundoApellido"].ToString();
                                txtnota.Text = dt.Rows[0]["Nota"].ToString();
                                cmbtipovisitante.SelectedText = dt.Rows[0]["TipoVisitante"].ToString();
                                txtdestino.Text = dt.Rows[0]["NumeroCasa"].ToString();
                                RutaFoto = dt.Rows[0]["RutaFoto"].ToString();
                                if (string.IsNullOrEmpty(dt.Rows[0]["RutaFoto"].ToString()))
                                {
                                    pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                                }
                                else
                                {
                                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                                    //Comprueba que el archivo .jpg si exista en la carpeta de fotos
                                    bool fileExists = (System.IO.File.Exists(RutaFoto) ? true : false);
                                    if (fileExists != true)
                                    {
                                        pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                                        return;
                                    }
                                    pbFoto.Image = (Image)Image.FromFile(dt.Rows[0]["RutaFoto"].ToString());
                                }
                                //MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtcedula.Focus();
                                txtcedula.SelectAll();
                                MostrarRegistros();
                            }
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarRegistros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void txtcedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Consultar();
            }
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void btnbusquedarango_Click(object sender, EventArgs e)
        {
            BusquedaRango();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            BusquedaRango();
        }

        private void txtsegundonombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Registrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void tsbRegistroManual_Click(object sender, EventArgs e)
        {
            //No se usa el método limpiar porque en este botón no se limpia el campo cédula
            lblregistroid.Text = "";
            lblcontador.Text = "";
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            txtnota.Text = "";
            cmbtipovisitante.Text = "";
            txtdestino.Clear();
            pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
            dtfechainicial.Value = DateTime.Now.AddDays(0);
            dtfechafinal.Value = DateTime.Now.AddDays(0);
            lblcasaid.Text = "";
            txtdestino.Clear();
            txtprimerapellido.Focus();

            MostrarRegistros();
            Registrar();
        }

        #endregion

    }
}
