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

namespace libGuiPOS
{
    public partial class frmLiquidar : Form
    {
        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public frmLiquidar()
        {
            InitializeComponent();
        }

        clsUtilidades objUtilidades = new clsUtilidades();

        #region [Variables]

        private bool RealizarFact;
        private bool AsignaFormatoNum = false;
        Decimal Devuelta = 0;

        public bool RealizarFactura
        {
            get { return RealizarFact; }
            set { RealizarFact = value; }
        }

        #endregion

        #region [Métodos Privados]

        private void CalcularDevuelta()
        {
            try
            {
                Devuelta = decimal.Parse(txtDineroRecibido.Text) - decimal.Parse(txtTotalVenta.Text);

                if (Devuelta < 0)
                {
                    txtDevuelta.ForeColor = Color.Red;
                    txtDevuelta.Text = Devuelta.ToString("#,##");
                    return;
                }

                txtDevuelta.ForeColor = Color.Black;
                txtDevuelta.Text = Devuelta.ToString("#,##");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Facturar()
        {
            try
            {
                if (txtDineroRecibido.Text == "0" || txtDineroRecibido.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe diligenciar todos los campos", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(Devuelta) < 0)
                {
                    MessageBox.Show("La cantidad de dinero ingresada es menor a la facturada.\n\rVerifique la información",
                        "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                RealizarFactura = true;
                this.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void tsbFacturar_Click(object sender, EventArgs e)
        {
            Facturar();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            RealizarFactura = false;
            this.Close();
        }

        private void frmLiquidar_Load(object sender, EventArgs e)
        {
            txtDineroRecibido.Focus();
        }

        private void txtDineroRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtTotalVenta.Text != "0" && txtDineroRecibido.Text != string.Empty)
            {
                Facturar();
            }
        }

        private void txtDineroRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Evita que se escriban letras en ese textbox
                if (!objUtilidades.PermitirSoloNumeros(e))
                {
                    e.Handled = true;
                    AsignaFormatoNum = false;
                    return;
                }
                e.Handled = false;

                //Formatear Textbox a tipo moneda
                AsignaFormatoNum = true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDineroRecibido_Validating(object sender, CancelEventArgs e)
        {
            if (txtTotalVenta.Text != "0" && txtDineroRecibido.Text != string.Empty)
            {
                CalcularDevuelta();
            }
        }

        private void txtDineroRecibido_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalVenta.Text != "0" && txtDineroRecibido.Text != string.Empty)
            {
                CalcularDevuelta();
            }
            if (txtDineroRecibido.Text == string.Empty)
            {
                txtDevuelta.ForeColor = Color.Red;
                txtDevuelta.Text = (Convert.ToDecimal(0) - Convert.ToDecimal(txtTotalVenta.Text)).ToString("#,##");
            }
            if (txtDineroRecibido.Text == txtTotalVenta.Text)
            {
                txtDevuelta.ForeColor = Color.Black;
                txtDevuelta.Text = "0";
            }
            if (AsignaFormatoNum)
            {
                AsignaFormatoNum = false;
                objUtilidades.FormatearNumeros(this.txtDineroRecibido);
            }
        }

        private void panelLiquidar_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
