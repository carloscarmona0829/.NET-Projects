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
using libInterfaz;
using libEntidades;

namespace libGuiPOS
{
    public partial class frmRecuperarPwd : Form
    {
        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmRecuperarPwd()
        {
            InitializeComponent();
        }

        #region [Métodos Privados]
        private void EnviarEmail()
        {
            try
            {
                if (txtEmail.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(
                        "Debe ingresar el E-mail con el que su usuario está registrado para generar la nueva contraseña",
                        "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                clsPosAPI objApi = new clsPosAPI();
                clsEntidadUsuario objEntidadUsuario = new clsEntidadUsuario();
                clsUtilidades objUtilidades = new clsUtilidades();
                DataTable dtRecuperar = new DataTable();

                objEntidadUsuario.email = txtEmail.Text.Trim();

                dtRecuperar = objApi.RecuperarContraseña(objEntidadUsuario);

                if (dtRecuperar.Rows.Count > 0)
                {
                    if (dtRecuperar.Rows[0]["SW"].ToString() == "0")
                    {
                        if (!objUtilidades.EnviarEmailSinOutlook(dtRecuperar.Rows[0]["Email"].ToString(), txtEmail.Text,
                            "Sistema POS",
                            "Su nueva contraseña es\n " + dtRecuperar.Rows[0]["Contraseña"].ToString() +
                            "\nEl sistema le solicitará cambio en el próximo ingreso", string.Empty, string.Empty,
                            dtRecuperar.Rows[0]["ContraseñaEnvia"].ToString()))
                        {
                            MessageBox.Show("No se pudo enviar la contraseña, cómuniquese con el proveedor", "Sistema POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Se envió una nueva contraseña al E-mail " + txtEmail.Text, "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(dtRecuperar.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Se ha producido un error en el sistema, informe al proveedor", "Sistema POS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ;
                }
                this.Hide();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region [Eventos]

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtEmail.Text != string.Empty)
            {
                EnviarEmail();
            }
        }

        private void panelRecuperarPwd_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
