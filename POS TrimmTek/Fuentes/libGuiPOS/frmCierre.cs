using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libEntidades;
using libInterfaz;

namespace libGuiPOS
{
    public partial class frmCierre : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades(); clsEntidadCierre entidadCierre = new clsEntidadCierre();
        DataSet dsCierre = new DataSet();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmCierre()
        {
            InitializeComponent();
        }

        #region [Variables]

        string strTipoCierre = string.Empty;
        private bool AsignaFormatoNum = false;
        string Monto = "0";

        #endregion

        #region [Métodos Privados]

        private void LimpiarCampos()
        {
            try
            {
                txtTotalEfectivo.Text = "0";
                txtTotalVendido.Text = "0";
                txtObservaciones.Text = string.Empty;
                lblMensaje.Visible = false;
                txtDiferencia.Visible = false;
                tsbAjustar.Visible = false;
                lblObservaciones.Visible = false;
                txtObservaciones.Visible = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cierre(string TipoCierre)
        {
            try
            {
                //Convierte el valor de txtTotalEfectivo en el formato simple para guardar en la base de datos
                if (!string.IsNullOrEmpty(txtTotalEfectivo.Text))
                {
                    Monto = txtTotalEfectivo.Text;
                    if (txtTotalEfectivo.Text.Contains(",") || txtTotalEfectivo.Text.Contains(".") ||
                        txtTotalEfectivo.Text.Contains("$"))
                    {
                        Monto = txtTotalEfectivo.Text.Replace(",", "").Replace(".", "").Replace("$", "");
                    }

                }
                if (txtTotalEfectivo.Text == string.Empty || Convert.ToInt32(Monto) <= 0)
                {
                    MessageBox.Show("El Total en Efectivo debe ser mayor que Cero", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotalEfectivo.Focus();
                    return;
                }

                entidadCierre.Fecha_Cierre = Convert.ToDateTime(dtpFechaCierre.Text).ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                entidadCierre.Dinero_en_Caja = Convert.ToInt32(Monto);
                entidadCierre.Observacion = txtObservaciones.Text;
                entidadCierre.Usu_Crea_Cierre = clsEntidadAutenticacion.Usuariologin;

                dsCierre = objApi.CierreDia(TipoCierre, entidadCierre);

                if (dsCierre.Tables.Count > 0)
                {
                    if (dsCierre.Tables[0].Rows.Count > 0)
                    {
                        if (dsCierre.Tables[0].Rows[0]["SW"].ToString() != "0")
                        {
                            //Mensaje de Error
                            MessageBox.Show(dsCierre.Tables[0].Rows[0]["MENSAJE"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTotalEfectivo.Text = "0";
                            return;
                        }

                        decimal ValorVendido = Convert.ToDecimal(dsCierre.Tables[0].Rows[0]["ValorVendido"].ToString());
                        decimal Efectivo = Convert.ToDecimal(Monto);
                        int Diferencia = Convert.ToInt32(ValorVendido - Efectivo);
                        txtTotalVendido.Text = ValorVendido.ToString("#,##");
                        txtDiferencia.Text = Math.Abs(Diferencia).ToString("#,##");


                        if (Diferencia == 0 || txtDiferencia.Text == string.Empty)
                        {
                            lblMensaje.Visible = true;
                            txtDiferencia.Visible = true;
                            lblMensaje.ForeColor = Color.Black;
                            txtDiferencia.Visible = false;
                            txtDiferencia.ForeColor = Color.Black;
                            lblMensaje.Text = "Caja Cuadrada";
                            MessageBox.Show("La Caja está Cuadrada", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (Diferencia > 0)
                        {
                            lblMensaje.Visible = true;
                            txtDiferencia.Visible = true;
                            lblMensaje.ForeColor = Color.Red;
                            txtDiferencia.ForeColor = Color.Red;
                            lblMensaje.Text = "Dinero Faltante";
                            MessageBox.Show("La Caja está Descuadrada, le faltan $" + Diferencia.ToString("#,##"), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (Diferencia < 0)
                        {
                            lblMensaje.Visible = true;
                            txtDiferencia.Visible = true;
                            lblMensaje.ForeColor = Color.Green;
                            txtDiferencia.ForeColor = Color.Green;
                            lblMensaje.Text = "Dinero Sobrante";
                            MessageBox.Show("La Caja está Descuadrada, le sobran $" + Math.Abs(Diferencia).ToString("#,##"), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SeleccionarCierre()
        {
            try
            {
                dtpFechaCierre.Value = Convert.ToDateTime(dbgCierres.Columns["Dia"].Text);
                decimal ValorVendido = Convert.ToDecimal(dbgCierres.Columns["Dinero en caja"].Text);
                decimal Efectivo = Convert.ToDecimal(dbgCierres.Columns["Ventas en Sistema"].Text);
                decimal Diferencia = Convert.ToDecimal(Math.Abs(ValorVendido - Efectivo));
                txtTotalEfectivo.Text = ValorVendido.ToString("#,##");
                txtTotalVendido.Text = Efectivo.ToString("#,##");
                txtDiferencia.Text = Diferencia.ToString("#,##");
                txtObservaciones.Text = dbgCierres.Columns["Observacion"].Text;

                if (ValorVendido - Efectivo == 0)
                {
                    MessageBox.Show("No se puede ajustar una caja cuadrada", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    return;
                }
                if (ValorVendido - Efectivo < 0)
                {
                    lblMensaje.Visible = true;
                    txtDiferencia.Visible = true;
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Dinero Faltante";
                }
                if (ValorVendido - Efectivo > 0)
                {
                    lblMensaje.Visible = true;
                    txtDiferencia.Visible = true;
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Dinero Sobrante";
                }

                tsbAjustar.Visible = true;
                lblObservaciones.Visible = true;
                txtObservaciones.Visible = true;
                tpCierre.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarCierre()
        {
            try
            {
                entidadCierre.Fecha_Cierre = Convert.ToDateTime(dtpFechaCierre.Text).ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                entidadCierre.Dinero_en_Caja = Convert.ToInt32(Monto);
                entidadCierre.Observacion = txtObservaciones.Text;
                entidadCierre.Id_Estado = 26;
                entidadCierre.Fecha_ModCierre = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                entidadCierre.Usu_Crea_Cierre = clsEntidadAutenticacion.Usuariologin;


                frmAutorizacion FormAutorizacion = new frmAutorizacion();
                FormAutorizacion.ShowDialog();

                if (FormAutorizacion.EntidadUsuario.Usuario != string.Empty && FormAutorizacion.EntidadUsuario.pwd != string.Empty)
                {
                    entidadCierre.UsuarioAutoriza = FormAutorizacion.EntidadUsuario.Usuario;
                    entidadCierre.PwdUsuarioAutoriza = FormAutorizacion.EntidadUsuario.pwd;

                    dsCierre = objApi.CierreDia("ACTUALIZAR", entidadCierre);

                    if (dsCierre.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show(dsCierre.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LimpiarCampos();
                        return;
                    }

                    MessageBox.Show("Error del Sistema", "Sistema POS", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCierres()
        {
            try
            {
                dsCierre = objApi.CierreDia("LISTARCIERRES", entidadCierre);

                if (dsCierre.Tables[0].Rows.Count > 0)
                {
                    if (dsCierre.Tables[0].Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgCierres, dsCierre.Tables[0]);
                        dbgCierres.Splits[0].DisplayColumns["SW"].Visible = false;
                        
                        //string Total = dsCierre.Tables[1].Rows[0]["Total Ventas"].ToString();
                        int TotalVentas = Convert.ToInt32(dsCierre.Tables[1].Rows[0]["Total Ventas"].ToString());                        
                        txtTotal.Text = dsCierre.Tables[1].Rows[0]["Total Ventas"].ToString();
                        txtTotal.Text = TotalVentas.ToString("##,###");
                        return;
                    }
                }

                MessageBox.Show("No hay registros para mostrar", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void frmCierre_Load(object sender, EventArgs e)
        {
            tpCierre.Show();
            tsbAjustar.Visible = false;
            lblObservaciones.Visible = false;
            txtObservaciones.Visible = false;
            dtpFechaCierre.Value = Convert.ToDateTime(DateTime.Now);
        }

        private void txtTotalEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalEfectivo.Text != string.Empty)
            {
                txtTotalEfectivo.Text = Convert.ToDecimal(txtTotalEfectivo.Text).ToString("#,##");
            }
            if (AsignaFormatoNum)
            {
                AsignaFormatoNum = false;
                objUtilidades.FormatearNumeros(txtTotalEfectivo);
            }
        }

        private void txtTotalEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!objUtilidades.PermitirSoloNumeros(e))
                {
                    //Evita que se escriban letras en ese textbox
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

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            strTipoCierre = "INSERTAR";
            Cierre(strTipoCierre);
        }

        private void tpCierre_Enter(object sender, EventArgs e)
        {
            txtTotalEfectivo.Focus();
        }

        private void tpListaCierres_Enter(object sender, EventArgs e)
        {
            ListarCierres();
        }

        private void dbgCierres_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarCierre();
        }

        private void tsbAjustar_Click(object sender, EventArgs e)
        {
            if (txtTotalEfectivo.Text != txtTotalVendido.Text)
            {
                MessageBox.Show("Total Efectivo y Total Vendido deben ser iguales.\r\nVerifique la información", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtObservaciones.Text == string.Empty)
            {
                MessageBox.Show("Debe poner una observación para hacer el ajuste", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObservaciones.Focus();
                return;
            }
            
            AjustarCierre();
        }

        private void dtpFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tsbCierreParcial_Click(object sender, EventArgs e)
        {
            strTipoCierre = "CIERRE PARCIAL";
            Cierre(strTipoCierre);
        }

        private void panelCierre_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
       
    }
}
