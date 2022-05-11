using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libEntidades;
using libInterfaz;

namespace libGuiPOS
{
    public partial class frmLogin : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsEntidadUsuario entidadUsuario = new clsEntidadUsuario();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        #region [Método Privados]
        private void Autenticar()
        {
            try
            {
                if (txtUsuario.Text.Trim() == string.Empty || txtPwd.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar usuario y Contraseña para realizar la autenticación", "Sistema REG",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                entidadUsuario.Usuario = txtUsuario.Text;
                entidadUsuario.pwd = txtPwd.Text;

                DataTable dtLogin = new DataTable();
                dtLogin = objApi.LoginUsuarios(entidadUsuario);

                if (dtLogin.Rows.Count > 0)
                {
                    //Login Exitoso: Muestra el Formulario Principal
                    if (dtLogin.Rows[0]["SW"].ToString() == "0")
                    {
                        clsEntidadAutenticacion.Usuariologin = txtUsuario.Text;
                        clsEntidadAutenticacion.Autorizador = Convert.ToInt32(dtLogin.Rows[0]["Autorizador"]);
                        clsEntidadAutenticacion.dtCargarMenuPrincipal = dtLogin;

                        this.Hide();

                        MdiPrincipal mdiPrincipal = new MdiPrincipal();
                        mdiPrincipal.Show();
                        return;
                    }
                    //Mensaje: Usuario y/o Contraseña no Válidos
                    else if (dtLogin.Rows[0]["SW"].ToString() == "1")
                    {
                        lblMensaje.Text = dtLogin.Rows[0]["Mensaje"].ToString();
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = Color.Red;
                        lblRecuperarPwd.Text = "Olvidé Mi Contraseña";
                        lblRecuperarPwd.Visible = true;
                        MessageBox.Show("Usuario y/o Contraseña no Válidos", "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //Mensaje: Usuario Inhabilitado para acceder al sistema
                    else if (dtLogin.Rows[0]["SW"].ToString() == "2")
                    {
                        lblMensaje.Visible = false;
                        lblRecuperarPwd.Visible = false;
                        lblMensaje.ForeColor = Color.Red;
                        MessageBox.Show(dtLogin.Rows[0]["Mensaje"].ToString(), "Sistema REG", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        return;
                    }
                    //Mensaje: Debe cambiar su contraseña
                    else if (dtLogin.Rows[0]["SW"].ToString() == "3")
                    {
                        lblMensaje.Text = dtLogin.Rows[0]["Mensaje"].ToString();
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = Color.ForestGreen;
                        lblRecuperarPwd.Text = "Cambiar Contraseña";
                        lblRecuperarPwd.Visible = true;
                        MessageBox.Show("Debe Cambiar su Contraseña", "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                MessageBox.Show("Usuario o contraseña inexistentes, verifique su información", "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region [Eventos]

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUsuario.Text != string.Empty)
            {
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUsuario.Text != string.Empty && txtPwd.Text != string.Empty)
            {
                Autenticar();
            }
        }

        private void lblRecuperarPwd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblRecuperarPwd.Text == "Olvidé Mi Contraseña")
                {
                    frmRecuperarPwd abrirFormRecuperarPwd = new frmRecuperarPwd();
                    abrirFormRecuperarPwd.ShowDialog();
                    txtUsuario.Text = string.Empty;
                    txtPwd.Text = string.Empty;
                    lblMensaje.Visible = false;
                    lblRecuperarPwd.Visible = false;
                    txtUsuario.Focus();
                }

                else
                {
                    frmCambiarPwd abrirFormCambiarPwd = new frmCambiarPwd();
                    //Para que el txtUsuario.Text del formulario frmCambiarPwd reciba el dato de este formulario, hay que poner en Public la propiedad Modifiers
                    abrirFormCambiarPwd.txtUsuario.Text = txtUsuario.Text;
                    abrirFormCambiarPwd.ShowDialog();
                    txtUsuario.Text = string.Empty;
                    txtPwd.Text = string.Empty;
                    lblMensaje.Visible = false;
                    lblRecuperarPwd.Visible = false;
                    txtUsuario.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema REG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerificarCadenaConexion_Click(object sender, EventArgs e)
        {
            //Muestra en un mensaje la cadena de conexión a la que está apuntando el proyecto para lo que hay que poner visible el boton
            MessageBox.Show(System.Configuration.ConfigurationSettings.AppSettings["dbPOSConexion"].ToString());
        }

        private void lblRecuperarPwd_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblRecuperarPwd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
