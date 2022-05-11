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
using libEntidades;
using libInterfaz;

namespace libGuiPOS
{
    public partial class frmCambiarPwd : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsEntidadUsuario entidadUsuario = new clsEntidadUsuario();
        DataTable dtActualizarContraseña = new DataTable();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmCambiarPwd()
        {
            InitializeComponent();
        }

        #region [Métodos Públicos]
        private void LimpiarCampos()
        {
            txtPwdRecibida.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtRepitaPwd.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            if (txtUsuario.Text.Trim() == string.Empty || txtPwdRecibida.Text.Trim() == string.Empty || txtPwd.Text.Trim() == string.Empty ||
                txtRepitaPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe diligenciar todos los campos", "Sistema POS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                txtPwdRecibida.Focus();
                return false;
            }

            if (txtPwd.Text != txtRepitaPwd.Text)
            {
                MessageBox.Show("Los campos Contraseña y Repita Contraseña deben coincidir", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                txtRepitaPwd.Focus();
                return false;
            }

            return true;
        }

        private void ActualizarContraseña()
        {
            try
            {
                entidadUsuario.IdUsuario = string.Empty;
                entidadUsuario.nombre = txtUsuario.Text.Trim();
                entidadUsuario.Usuario = txtUsuario.Text.Trim();
                entidadUsuario.email = string.Empty;
                entidadUsuario.tipouser = 0;
                entidadUsuario.pwd = txtPwd.Text.Trim();
                entidadUsuario.pwdRecibida = txtPwdRecibida.Text.Trim();

                dtActualizarContraseña = objApi.UsuariosCrud("ACTUALIZAR CONTRASEÑA", entidadUsuario);


                if (dtActualizarContraseña.Rows.Count > 0)
                {
                    if (dtActualizarContraseña.Rows[0]["SW"].ToString() == "0")
                    {
                        MessageBox.Show(dtActualizarContraseña.Rows[0]["Mensaje"].ToString(), "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (dtActualizarContraseña.Rows[0]["SW"].ToString() == "1")
                    {
                        MessageBox.Show(dtActualizarContraseña.Rows[0]["Mensaje"].ToString(), "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CambiarPwd();
        }

        private void CambiarPwd()
        {
            if (!ValidarCampos())
            {
                return;
            }

            ActualizarContraseña();
            this.Hide();
        }

        private void txtPwdRecibida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPwdRecibida.Text != string.Empty)
            {
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPwd.Text != string.Empty)
            {
                txtRepitaPwd.Focus();
            }
        }

        private void txtRepitaPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPwd.Text != string.Empty)
            {
                CambiarPwd();
            }
        }

        private void panelCambiarPwd_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        
    }
}
