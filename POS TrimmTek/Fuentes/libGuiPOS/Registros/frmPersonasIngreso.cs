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
using libEntidades.clsEntidadesregvis;
using libInterfaz;
using Emgu.CV;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace libGuiPOS.Registros
{
    public partial class frmPersonasIngreso : Form
    {
        //FormularioEjecutorEsRegistro no se esta usando en este proyecto
        public string FormularioEjecutorEsRegistro { get; set; }
        public string Cedula { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public bool GuardoUsuario { get; set; }

        VideoCaptureDevice frame;
        FilterInfoCollection Devices;

        //Variable global que almacena la ruta de la foto
        string RutaFoto;

        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();

        public frmPersonasIngreso()
        {
            InitializeComponent();
        }

        #region [Métodos]

        public void CargarDatosPersonas()
        {
            try
            {
                dtgpersonas.DataSource = objApi.ConsultarTodosPersonas();
                dtgpersonas.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }

        public void LimpiarDatos()
        {
            lblpersonaid.Text = "";
            txtcedula.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtnota.Text = "";
            cmbcasa.Text = "Seleccionar";
            cmbtipovisitante.Text = "Seleccionar";
            txtcedulabusqueda.Text = "";
            txtnombrebusqueda.Text = "";
            tsbNuevo.Visible = true;
            tsbGuardar.Visible = true;
            tsbActualizar.Visible = true;
            tsbEliminar.Visible = true;
            pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
            txtcedula.Focus();
        }

        public void GuardarDatos()
        {
            try
            {
                //Guarda Personas
                libEntidades.clsEntidadesregvis.clsEntidadPersonas personas = new libEntidades.clsEntidadesregvis.clsEntidadPersonas();
                string result = string.Empty;

                if (string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtprimerapellido.Text) || string.IsNullOrEmpty(txtprimernombre.Text) || (cmbcasa.Text == "Seleccionar") || (cmbcasa.Text == "") || (cmbtipovisitante.Text == "Seleccionar") || (cmbtipovisitante.Text == ""))
                {
                    MessageBox.Show("Faltan campos por llenar, por favor verifique que todos los campos", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = new DataTable();
                dt = objApi.ConsultarPersonasCedula(txtcedula.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El usuario ya esta registrado en la base de datos", "Sistema de Registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                }

                else
                {
                    personas.Cedula = Convert.ToInt32(txtcedula.Text.Trim());
                    personas.PrimerNombre = Convert.ToString(txtprimernombre.Text.Trim());
                    personas.SegundoNombre = Convert.ToString(txtsegundonombre.Text.Trim());
                    personas.PrimerApellido = Convert.ToString(txtprimerapellido.Text.Trim());
                    personas.SegundoApellido = Convert.ToString(txtsegundoapellido.Text.Trim());
                    personas.CasaId = Convert.ToInt32(cmbcasa.SelectedValue);
                    personas.TipoVisitante = Convert.ToString(cmbtipovisitante.Text);
                    personas.Nota = Convert.ToString(txtnota.Text);
                    personas.RutaFoto = pbFoto.ImageLocation = System.Configuration.ConfigurationManager.AppSettings["imgFoto"].ToString() + @"\" + txtcedula.Text + ".jpg";

                    result = objApi.GuardarPersonasregvis(personas);

                    //Esta instrucción cierra el formulario registro que fue de donde se ejecutó este formulario
                    if (FormularioEjecutorEsRegistro == "Registro")
                    {
                        GuardarFoto();
                        this.Close();
                        frmRegistro abrirFormRegistro = new frmRegistro();
                        abrirFormRegistro.ShowDialog();
                        return;
                    }

                    GuardarFoto();

                    MessageBox.Show(result, "Sistema de Registro", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    LimpiarDatos();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void ActualizarDatos()
        {
            try
            {
                //Actualiza personas
                if (string.IsNullOrEmpty(lblpersonaid.Text))
                {
                    MessageBox.Show("Debe consultar un usuario para actualizar", "Sistema de Registro", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                }
                else
                {
                    libEntidades.clsEntidadesregvis.clsEntidadPersonas personas = new libEntidades.clsEntidadesregvis.clsEntidadPersonas();
                    string result = string.Empty;

                    if (string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtprimerapellido.Text) || string.IsNullOrEmpty(txtprimernombre.Text))
                    {
                        MessageBox.Show("Faltan campos por llenar, por favor verifique que todos los campos", "Sistema de Registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        personas.Cedula = Convert.ToInt32(txtcedula.Text.Trim());
                        personas.PrimerNombre = Convert.ToString(txtprimernombre.Text.Trim());
                        personas.SegundoNombre = Convert.ToString(txtsegundonombre.Text.Trim());
                        personas.PrimerApellido = Convert.ToString(txtprimerapellido.Text.Trim());
                        personas.SegundoApellido = Convert.ToString(txtsegundoapellido.Text.Trim());
                        personas.CasaId = Convert.ToInt32(cmbcasa.SelectedValue);
                        personas.TipoVisitante = Convert.ToString(cmbtipovisitante.Text);
                        personas.Nota = Convert.ToString(txtnota.Text.Trim());
                        personas.RutaFoto = pbFoto.ImageLocation = System.Configuration.ConfigurationManager.AppSettings["imgFoto"].ToString() + @"\" + txtcedula.Text + ".jpg";

                        result = objApi.ActualizarPersonasregvis(personas, Convert.ToInt32(lblpersonaid.Text));
                    }
                    CargarDatosPersonas();
                    MessageBox.Show(result, "Sistema de Registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    tsbActualizar.Visible = false;
                    tsbGuardar.Visible = true;
                    tsbEliminar.Visible = false;
                    LimpiarDatos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void EliminarDatos()
        {
            try
            {
                //Elimina personas
                if (string.IsNullOrEmpty(lblpersonaid.Text))
                {
                    MessageBox.Show("Debe consultar un usuario para eliminar", "Sistema de Registro", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Desea Eliminar el usuario?", "Sistema de Registro",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                    {
                        return;
                    }
                    string result = string.Empty;
                    result = objApi.EliminarPersonasregvis(lblpersonaid.Text);
                    CargarDatosPersonas();
                    MessageBox.Show(result, "Sistema de Registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void Consultar()
        {
            try
            {
                DataTable dt = new DataTable();

                if (txtcedula.Text != "")
                {
                    dt = objApi.ConsultarPersonasCedula(txtcedula.Text);

                    if (dt.Rows.Count > 0)
                    {
                        lblpersonaid.Text = dt.Rows[0]["PersonaIngresoId"].ToString();
                        txtprimerapellido.Text = dt.Rows[0]["PrimerApellido"].ToString();
                        txtsegundoapellido.Text = dt.Rows[0]["SegundoApellido"].ToString();
                        txtprimernombre.Text = dt.Rows[0]["PrimerNombre"].ToString();
                        txtsegundonombre.Text = dt.Rows[0]["SegundoNombre"].ToString();
                        cmbcasa.SelectedValue = dt.Rows[0]["CasaId"].ToString();
                        txtnota.Text = dt.Rows[0]["Nota"].ToString();
                        //Se necesita este vaciado para que no duplique el texto en el combobox
                        cmbtipovisitante.Text = "";
                        cmbtipovisitante.SelectedText = dt.Rows[0]["TipoVisitante"].ToString();
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

                                tsbGuardar.Visible = false;
                                tsbNuevo.Visible = true;
                                tsbActualizar.Visible = true;
                                tsbEliminar.Visible = true;
                                return;
                            }
                            pbFoto.Image = (Image)Image.FromFile(dt.Rows[0]["RutaFoto"].ToString());
                        }

                        tsbNuevo.Visible = true;
                        tsbGuardar.Visible = false;
                        tsbActualizar.Visible = true;
                        tsbEliminar.Visible = true;
                        txtcedula.Focus();
                        txtcedula.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show("No existe cedula registrada en la base de datos", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void CargarComboCasas()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = objApi.CargarCasaComboBox();

                cmbcasa.DataSource = dt;
                cmbcasa.ValueMember = "CasaId";
                cmbcasa.DisplayMember = "NumeroCasa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        void NuevoFrame(object send, NewFrameEventArgs e)
        {
            try
            {
                pbFoto.Image = (Image)e.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }

        void IniciarCam()
        {
            try
            {
                if (txtcedula.Text != "")
                {
                    Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    frame = new VideoCaptureDevice(Devices[0].MonikerString);
                    frame.NewFrame += new AForge.Video.NewFrameEventHandler(NuevoFrame);
                    frame.Start();
                    return;
                }
                MessageBox.Show("Debe llenar los datos antes de tomar una foto", "Sistema de Registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                txtcedula.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        public void GuardarFoto()
        {
            try
            {
                if (string.IsNullOrEmpty(txtcedula.Text))
                {
                    MessageBox.Show("Debe digitar primero su cedula antes de guardar", "Sistema REG", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //ruta es una key para que guarde las fotos en la ubicación que se ponga  en el app config y la guarde con ese formato despues del signo +         
                    RutaFoto = pbFoto.ImageLocation = System.Configuration.ConfigurationManager.AppSettings["imgFoto"].ToString() + @"\" + txtcedula.Text + ".jpg";
                    if (pbFoto.Image == null)
                    {
                        pbFoto.Image = libGuiPOS.Properties.Resources.user_128;
                    }
                    pbFoto.Image.Save(RutaFoto, ImageFormat.Jpeg);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void frmPersonasIngreso_Load(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
                CargarDatosPersonas();
                CargarComboCasas();
                if (FormularioEjecutorEsRegistro == "Registro")
                {
                    txtcedula.Text = Cedula;
                    txtprimerapellido.Text = PrimerApellido;
                    txtsegundoapellido.Text = SegundoApellido;
                    txtprimernombre.Text = PrimerNombre;
                    txtsegundonombre.Text = SegundoNombre;
                    cmbcasa.SelectedIndex = -1;
                    cmbtipovisitante.SelectedIndex = -1;
                }
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            CargarDatosPersonas();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtcedulabusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            //Permitir teclas de control como retroceso
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //El resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtcedulabusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarPersonasCedula();
            }
        }

        public void ConsultarPersonasCedula()
        {
            try
            {
                //Consulta personas por número de cédula
                DataTable dt = new DataTable();

                if (txtcedulabusqueda.Text != "")
                {
                    dt = objApi.ConsultarPersonasVistaCedula(txtcedulabusqueda.Text);

                    if (dt.Rows.Count > 0)
                    {
                        dtgpersonas.DataSource = dt;
                        dtgpersonas.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No existe cedula registrada en la base de datos", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void txtnombrebusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarPersonasNombre();
            }
        }

        public void ConsultarPersonasNombre()
        {
            try
            {
                //Consulta personas por nombre
                DataTable dt = new DataTable();

                if (txtnombrebusqueda.Text != "")
                {
                    dt = objApi.ConsultarPersonasVistaNombre(txtnombrebusqueda.Text);

                    if (dt.Rows.Count > 0)
                    {
                        dtgpersonas.DataSource = dt;
                        dtgpersonas.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No existe persona con el nombre de " + txtnombrebusqueda.Text + " registrada en la base de datos", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Realiza consultas según el parámetro digitado
                if (txtcedula.Text == "" && txtcedulabusqueda.Text == "" && txtnombrebusqueda.Text == "")
                {
                    txtcedulabusqueda.Focus();
                    MessageBox.Show("Debe digitar un parámetro de búsqueda ", "Sistema REG", MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                }
                if (txtcedula.Text != "" && txtcedulabusqueda.Text != "" && txtnombrebusqueda.Text != "")
                {
                    MessageBox.Show("Debe seleccionar solo un parámetro de busqueda", "Sistema REG", MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);

                }
                if (txtcedula.Text != "")
                {
                    Consultar();
                }
                else if (txtcedulabusqueda.Text != "")
                {
                    ConsultarPersonasCedula();
                }
                else
                {
                    ConsultarPersonasNombre();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            GuardarFoto();
            ActualizarDatos();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsegundonombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Consultar();
            }
        }

        private void IniciarCamara_Click(object sender, EventArgs e)
        {
            IniciarCam();
        }

        private void btntomarfoto_Click(object sender, EventArgs e)
        {
            if (txtcedula.Text == "")
            {
                MessageBox.Show("Debe llenar los datos antes de tomar una foto", "Sistema de Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                txtcedula.Focus();
                return;
            }
            if (RutaFoto != "" && pbFoto.Image != null)
            {
                frame.Stop();                
            }
        }

        #endregion

    }
}
