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

namespace libGuiPOS
{
    public partial class frmAutorizacion : Form
    {
        frmFacturacion formularioFacturacion;

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmAutorizacion()
        {
            InitializeComponent();
        }
        
        private clsEntidadUsuario entidadUsuario;

        public clsEntidadUsuario EntidadUsuario
        {
            get { return entidadUsuario; }
            set { entidadUsuario = value; }
        }

        #region [Métodos Privados]

        private void Autorizar()
        {
            try
            {
                if (this.txtUsuario.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar un usuario o presionar el botón Cancelar para cerrar la ventana",
                        "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.txtPwd.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar una contraseña o presionar el botón Cancelar para cerrar la ventana",
                        "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                EntidadUsuario = new clsEntidadUsuario();
                EntidadUsuario.Usuario = this.txtUsuario.Text.Trim();
                EntidadUsuario.pwd = this.txtPwd.Text.Trim();
                this.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Autorizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                EntidadUsuario = new clsEntidadUsuario();
                EntidadUsuario.email = string.Empty;
                EntidadUsuario.pwd = string.Empty;
                this.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                Autorizar();
            }
        }

        private void panelAutorizacion_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
