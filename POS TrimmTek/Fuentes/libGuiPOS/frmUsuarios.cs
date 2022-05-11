using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using libEntidades;
using libInterfaz;

namespace libGuiPOS
{
    public partial class frmUsuarios : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadUsuario entidadUsuarios = new clsEntidadUsuario();
        DataTable dtUsuarios = new DataTable();
        private bool ActualizaUsuario = false;
        public string FormularioEjecutorEsFacturacion { get; set; }
        public bool GuardoUsuario { get; set; }
        public string Identificacion { get; set; }

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmUsuarios()
        {
            InitializeComponent();
        }
        
        #region [Métodos Privados]

        private void Guardar()
        {
            try
            {
                if (!ValidarCamposListaUsuarios())
                {
                    return;
                }

                AsignarEntidadUsuarios();

                DataTable dtInsertarUsuarios = new DataTable();
                dtInsertarUsuarios = objApi.UsuariosCrud("INSERTAR", entidadUsuarios);

                if (dtInsertarUsuarios.Rows.Count > 0)
                {
                    if (dtInsertarUsuarios.Rows[0]["SW"].ToString() != "0")
                    {
                        MessageBox.Show(dtInsertarUsuarios.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("El Usuario fue creado con Exito", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (FormularioEjecutorEsFacturacion == "Facturacion")
                {
                    GuardoUsuario = true;
                    Close();
                    return;
                }

                //Limpia los campos de la interfase luego de guardar
                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar()
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                AsignarEntidadUsuarios();

                if (txtPwd.Text != txtRepitaPwd.Text)
                {
                    MessageBox.Show("Los campos Contraseña y Repita Contraseña deben coincidir", "Sistema POS",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    DataTable dt = new DataTable();
                    dt = objApi.UsuariosCrud("ACTUALIZAR", entidadUsuarios);

                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Se generó un error al Actualizar el usuario", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El Usuario fue Actualizado con Exito", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    LimpiarCampos();
                    tsbActualizar.Visible = false;
                    tsbEliminar.Visible = false;
                    tsbGuardar.Visible = true;
                    txtIdentificacion.Enabled = true;
                    txtIdentificacion.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el Usuario?", "Sistema POS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    entidadUsuarios.IdUsuario = txtIdentificacion.Text;
                    entidadUsuarios.nombre = txtNombre.Text;
                    entidadUsuarios.celular = txtCelular.Text;
                    entidadUsuarios.fijo = txtFijo.Text;
                    entidadUsuarios.fechnto = dtpFechaNacimiento.Value.ToString("yyyyMMdd");
                    entidadUsuarios.email = txtEmail.Text;
                    entidadUsuarios.pwd = txtPwd.Text;
                    entidadUsuarios.dir = txtDireccion.Text;
                    entidadUsuarios.tipouser = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                    entidadUsuarios.perfil = Convert.ToInt32(cmbPerfil.SelectedValue);
                    entidadUsuarios.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    entidadUsuarios.usuAccion = clsEntidadAutenticacion.Usuariologin;
                    entidadUsuarios.fechAccion = Convert.ToString(DateTime.Now);
                    entidadUsuarios.UsuModifica = clsEntidadAutenticacion.Usuariologin;
                    entidadUsuarios.FechaModifica = Convert.ToString(DateTime.Now);


                    DataTable dt = new DataTable();
                    dt = objApi.UsuariosCrud("INHABILITAR", entidadUsuarios);

                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Se generó un error al Eliminar el usuario", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El Usuario fue Borrado Exitosamente", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    LimpiarCampos();

                    tsbActualizar.Visible = false;
                    tsbEliminar.Visible = false;
                    tsbGuardar.Visible = true;
                    txtIdentificacion.Enabled = true;
                    txtIdentificacion.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarEntidadUsuarios()
        {
            try
            {
                entidadUsuarios.IdUsuario = txtIdentificacion.Text;
                entidadUsuarios.nombre = txtNombre.Text;
                entidadUsuarios.celular = txtCelular.Text;
                entidadUsuarios.fijo = txtFijo.Text;
                entidadUsuarios.fechnto = dtpFechaNacimiento.Value.ToString("yyyyMMdd");
                entidadUsuarios.email = txtEmail.Text;
                entidadUsuarios.pwd = txtPwd.Text;
                entidadUsuarios.dir = txtDireccion.Text;
                entidadUsuarios.tipouser = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                entidadUsuarios.perfil = Convert.ToInt32(cmbPerfil.SelectedValue);
                entidadUsuarios.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                entidadUsuarios.usuAccion = clsEntidadAutenticacion.Usuariologin;
                entidadUsuarios.fechAccion = Convert.ToString(DateTime.Now);
                if (chkAutorizador.Checked)
                {
                    entidadUsuarios.Autorizador = true;
                }
                else
                {
                    entidadUsuarios.Autorizador = false;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombosTipoUsuarioyPerfil()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                dsCombos = objApi.CargarCombosUsuarios();

                if (dsCombos.Tables[0] != null)
                {
                    objUtilidades.LlenarComboUnicoValor(cmbTipoUsuario, dsCombos.Tables[0], "Valor", "Id");
                    cmbTipoUsuario.Text = "Seleccionar";
                    objUtilidades.LlenarComboUnicoValor(cmbPerfil, dsCombos.Tables[1], "Valor", "Id");
                    cmbPerfil.Text = "Seleccionar";
                    objUtilidades.LlenarComboUnicoValor(cmbEstado, dsCombos.Tables[2], "Valor", "Id");
                    cmbEstado.Text = "Activo";
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUsuarios()
        {
            try
            {
                tsbGuardar.Visible = false;
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;

                entidadUsuarios.IdUsuario = "";
                entidadUsuarios.nombre = "";
                entidadUsuarios.email = "";
                entidadUsuarios.tipouser = 13;

                dtUsuarios = objApi.UsuariosCrud("LISTAUSUARIOS", entidadUsuarios);

                if (dtUsuarios.Rows.Count > 0)
                {
                    if (dtUsuarios.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgUsuarios, dtUsuarios);
                        dbgUsuarios.Splits[0].DisplayColumns["Id"].Visible = false;
                        dbgUsuarios.Splits[0].DisplayColumns["SW"].Visible = false;

                        return;
                    }

                    MessageBox.Show("No hay registros para mostrar", "Sistema POS", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                }

                MessageBox.Show(dtUsuarios.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarUsuario()
        {
            txtIdentificacion.Text = dbgUsuarios.Columns["Identificacion"].Text;
            txtNombre.Text = dbgUsuarios.Columns["Nombre"].Text;
            txtCelular.Text = dbgUsuarios.Columns["Celular"].Text;
            txtFijo.Text = dbgUsuarios.Columns["Fijo"].Text;
            this.dtpFechaNacimiento.Value = Convert.ToDateTime(dbgUsuarios.Columns["FechaNacimiento"].Text);
            txtEmail.Text = dbgUsuarios.Columns["Email"].Text;
            txtDireccion.Text = dbgUsuarios.Columns["DirResidencia"].Text;
            cmbTipoUsuario.Text = dbgUsuarios.Columns["TipoUsuario"].Text;
            cmbPerfil.Text = dbgUsuarios.Columns["Perfil"].Text;
            cmbEstado.Text = dbgUsuarios.Columns["Estado"].Text;
            chkAutorizador.Checked = Convert.ToBoolean(dbgUsuarios.Columns["Autorizador"].Text);

            txtIdentificacion.ReadOnly = true;

            tpUsuario.Show();
        }

        private bool ValidarCamposListaUsuarios()
        {
            try
            {
                if (this.txtIdentificacion.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la identificación del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIdentificacion.Focus();
                    return false;
                }
                if (this.txtNombre.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                    return false;
                }
                
                if (this.dtpFechaNacimiento.Text.Trim() == "enero 01, 1980")
                {
                    MessageBox.Show("Debe ingresar la fecha de nacimiento del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dtpFechaNacimiento.Focus();
                    return false;
                }
                if (this.txtEmail.Text.Trim() == string.Empty || !this.txtEmail.Text.Contains("@") || !this.txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Debe ingresar un E-mail válido", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEmail.Focus();
                    return false;
                }
                if (this.cmbTipoUsuario.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un tipo para el usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbTipoUsuario.Focus();
                    return false;
                }
                if (this.cmbPerfil.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un perfil para el usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbPerfil.Focus();
                    return false;
                }
                if (this.cmbEstado.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un estado para el usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbEstado.Focus();
                    return false;
                }
                if (txtPwd.Text != txtRepitaPwd.Text)
                {
                    MessageBox.Show("Los campos Contraseña y Repita Contraseña deben coincidir", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (DataRow Fila in dtUsuarios.Rows)
                {
                    if (Fila["Identificacion"].ToString().Trim() == txtIdentificacion.Text.Trim())
                    {
                        MessageBox.Show(
                            "El usuario que intenta ingresar ya existe en el sistema y está activo, verifique la información",
                            "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                if (this.txtIdentificacion.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la identificación del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIdentificacion.Focus();
                    return false;
                }
                if (this.txtNombre.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                    return false;
                }
                if (this.txtCelular.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el celular del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCelular.Focus();
                    return false;
                }
                if (this.dtpFechaNacimiento.Text.Trim() == "enero 01, 1900")
                {
                    MessageBox.Show("Debe ingresar la fecha de nacimiento del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dtpFechaNacimiento.Focus();
                    return false;
                }
                if (this.txtEmail.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar E-mail del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEmail.Focus();
                    return false;
                }
                if (this.cmbTipoUsuario.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un tipo de usuario del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbTipoUsuario.Focus();
                    return false;
                }
                if (this.cmbPerfil.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un tipo de usuario del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbPerfil.Focus();
                    return false;
                }
                if (this.cmbEstado.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un tipo de usuario del usuario", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbEstado.Focus();
                    return false;
                }
                if (txtPwd.Text != txtRepitaPwd.Text)
                {
                    MessageBox.Show("Los campos Contraseña y Repita Contraseña deben coincidir", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Text = String.Empty;
            txtIdentificacion.ReadOnly = false;
            txtNombre.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtFijo.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPwd.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            cmbTipoUsuario.Text = "Seleccionar";
            cmbPerfil.Text = "Seleccionar";
            cmbEstado.Text = "Activo";
            txtRepitaPwd.Text = String.Empty;
            txtIdentificacion.Focus();
            dtpFechaNacimiento.Text = "1980/02/29";
            chkAutorizador.Checked = false;
            tsbActualizar.Visible = false;
            tsbGuardar.Visible = true;
            tsbEliminar.Visible = false;
            tsbNuevo.Visible = false;
            ActualizaUsuario = false;
        }

        #endregion

        #region [Eventos]

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            tpUsuario.Show();
            dtpFechaNacimiento.Text = "1980/02/29";

            if (FormularioEjecutorEsFacturacion == "Facturacion")
            {
                txtIdentificacion.Text = Identificacion;
            }


            //En esta opción no se pueden limpiar los campos porque no traería del formFacturación el Id del Cliente
            CargarCombosTipoUsuarioyPerfil();
            //Todo lo que se escriba en ese textbox se convierte a Mayusculas
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void tpUsuario_Enter(object sender, EventArgs e)
        {
            tsbNuevo.Visible = true;
            if (ActualizaUsuario)
            {
                tsbActualizar.Visible = true;
                tsbEliminar.Visible = true;
                tsbGuardar.Visible = false;
            }
            else
            {
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;
                tsbGuardar.Visible = true;
            }

            if (clsEntidadAutenticacion.Autorizador == 1)
            {
                chkAutorizador.Enabled = true;
            }

            if (FormularioEjecutorEsFacturacion == "Facturacion")
            {
                txtNombre.Focus();
            }

        }

        private void tpListaUsuarios_Enter(object sender, EventArgs e)
        {
            tsbNuevo.Visible = false;
            tsbGuardar.Visible = false;
            tsbActualizar.Visible = false;
            tsbEliminar.Visible = false;
           
            ListarUsuarios();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            ActualizaUsuario = false;
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            if (FormularioEjecutorEsFacturacion == "Facturacion")
            {
                GuardoUsuario = false;
            }
            Close();
        }

        private void dbgUsuarios_DoubleClick(object sender, EventArgs e)
        {
            ActualizaUsuario = true;
            SeleccionarUsuario();
        }

        private void cmbTipoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.Text == "Cliente")
            {
                cmbPerfil.Text = "Cliente";
                cmbPerfil.Enabled = false;
                chkAutorizador.Enabled = false;
            }
            else
            {
                cmbPerfil.Text = "Seleccionar";
                cmbPerfil.Enabled = true;
                chkAutorizador.Enabled = true;
            }
        }

        private void panelUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
