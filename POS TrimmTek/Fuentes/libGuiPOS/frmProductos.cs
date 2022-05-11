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
using Microsoft.SqlServer.Server;

namespace libGuiPOS
{
    public partial class frmProductos : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadProductos entidadProductos = new clsEntidadProductos();
        DataTable dtProductos = new DataTable();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmProductos()
        {
            InitializeComponent();
        }

        #region [Métodos Privados]

        private void AsignarEntidadProductos()
        {
            entidadProductos.Codigo_Barras = txtCodigoBarras.Text;
            entidadProductos.Producto = txtNombre.Text;
            entidadProductos.Costo = Convert.ToInt32(txtCosto.Text);
            entidadProductos.PVP = Convert.ToInt32(txtPvp.Text);
            entidadProductos.Id_Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            entidadProductos.Id_TipoProducto = Convert.ToInt32(cmbTipoProducto.SelectedValue);
            //Estas validaciones se hacen porque si asigno el valor a la entidad y esta vacío, generaría un error
            if (txtCantidadMinima.Text != string.Empty)
            {
                entidadProductos.Cant_Minima = Convert.ToInt32(txtCantidadMinima.Text);
            }
            if (txtCantidadStock.Text != string.Empty)
            {
                entidadProductos.Cant_Stock = Convert.ToInt32(txtCantidadStock.Text);
            }
            //Esta validación es para que cuando se cree un servicio que por ende no lleva cantidad ménima ni máxima, permita agregarlo a la comanda
            if (cmbTipoProducto.Text == "Servicio")
            {
                entidadProductos.Cant_Stock = 99999;
            }
            entidadProductos.Usu_CreaProducto = clsEntidadAutenticacion.Usuariologin;
            entidadProductos.Fecha_CreaProducto = Convert.ToString(DateTime.Now);
            entidadProductos.Usu_ModProducto = clsEntidadAutenticacion.Usuariologin;
            entidadProductos.Fecha_ModProducto = Convert.ToString(DateTime.Now);
        }

        private void Guardar()
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                AsignarEntidadProductos();

                DataTable dtInsertarProductos = new DataTable();
                dtInsertarProductos = objApi.ProductosCrud("INSERTAR", entidadProductos);

                if (dtInsertarProductos.Rows.Count > 0)
                {
                    if (dtInsertarProductos.Rows[0]["SW"].ToString() != "0")
                    {
                        MessageBox.Show(dtInsertarProductos.Rows[0]["Mensaje"].ToString(), "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show(dtInsertarProductos.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpia los campos de la interfase luego de guardar
                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                entidadProductos.Id_Producto = Convert.ToInt32(txtCodigoProducto.Text);
                AsignarEntidadProductos();

                DataTable dt = new DataTable();
                dt = objApi.ProductosCrud("ACTUALIZAR", entidadProductos);

                if (dt.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show(dt.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(dt.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el Producto ?", "Sistema POS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    entidadProductos.Id_Producto = Convert.ToInt32(txtCodigoProducto.Text);
                    AsignarEntidadProductos();

                    DataTable dtInhabilitarProductos = new DataTable();
                    dtInhabilitarProductos = objApi.ProductosCrud("INHABILITAR", entidadProductos);

                    if (dtInhabilitarProductos.Rows.Count > 0)
                    {
                        if (dtInhabilitarProductos.Rows[0]["SW"].ToString() != "0")
                        {
                            MessageBox.Show(dtInhabilitarProductos.Rows[0]["Mensaje"].ToString(), "Sistema POS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(dtInhabilitarProductos.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }

                    LimpiarCampos();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarCombosProveedoryTipoProducto()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                dsCombos = objApi.CargarCombosProveedoryTipoProducto();
                LimpiarCampos();

                if (dsCombos.Tables[0] != null)
                {
                    objUtilidades.LlenarComboUnicoValor(cmbProveedor, dsCombos.Tables[0], "Valor", "Id");
                    cmbProveedor.Text = "Seleccionar";
                    objUtilidades.LlenarComboUnicoValor(cmbTipoProducto, dsCombos.Tables[1], "Valor", "Id");
                    cmbTipoProducto.Text = "Seleccionar";
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListarProductos()
        {
            try
            {
                tsbGuardar.Visible = false;
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;

                dtProductos = objApi.ProductosCrud("LISTAR", entidadProductos);

                if (dtProductos.Rows.Count > 0)
                {
                    if (dtProductos.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGridOcultaResultado(dbgProductos, dtProductos);
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SeleccionarProducto()
        {
            txtCodigoProducto.Text = dbgProductos.Columns["Id_Producto"].Text;
            txtCodigoBarras.Text = dbgProductos.Columns["CodBarras"].Text;
            txtNombre.Text = dbgProductos.Columns["Producto"].Text;
            txtCosto.Text = dbgProductos.Columns["Costo"].Text;
            txtPvp.Text = dbgProductos.Columns["Precio"].Text;
            cmbProveedor.Text = dbgProductos.Columns["Proveedor"].Text;
            cmbTipoProducto.Text = dbgProductos.Columns["Tipo Producto"].Text;
            txtCantidadMinima.Text = dbgProductos.Columns["Cant Minima"].Text;
            txtCantidadStock.Text = dbgProductos.Columns["Unid_Disp"].Text;

            txtCodigoProducto.ReadOnly = true;
            lblCodigoProducto.Visible = true;
            txtCodigoProducto.Visible = true;

            tpProducto.Show();
            tsbNuevo.Visible = true;
            tsbGuardar.Visible = false;
            tsbActualizar.Visible = true;
            tsbEliminar.Visible = true;
        }

        private bool ValidarCampos()
        {
            try
            {
                if (this.txtNombre.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre del producto", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                    return false;
                }
                if (this.txtCodigoBarras.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el código de barras", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCodigoBarras.Focus();
                    return false;
                }
                if (this.txtCosto.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el costo", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCosto.Focus();
                    return false;
                }
                if (this.txtNombre.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                    return false;
                }
                if (this.txtPvp.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el precio de venta", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPvp.Focus();
                    return false;
                }
                if (this.cmbProveedor.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un proveedor", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbProveedor.Focus();
                    return false;
                }
                if (this.cmbTipoProducto.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un tipo", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbTipoProducto.Focus();
                    return false;
                }
                if (cmbTipoProducto.Text == "Producto" && this.txtCantidadMinima.Text.Trim() == string.Empty || cmbTipoProducto.Text == "Producto" && txtCantidadMinima.Text == "0")
                {
                    MessageBox.Show("Debe ingresar la cantidad minima", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCantidadMinima.Focus();
                    return false;
                }
                if (cmbTipoProducto.Text == "Producto" && this.txtCantidadStock.Text.Trim() == string.Empty || cmbTipoProducto.Text == "Producto" && txtCantidadMinima.Text == "0")
                {
                    MessageBox.Show("Debe ingresar la cantidad a guardar en la bodega", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCantidadStock.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoBarras.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPvp.Text = string.Empty;
            cmbProveedor.Text = "Seleccionar";
            cmbTipoProducto.Text = "Seleccionar";
            txtCantidadMinima.Text = string.Empty;
            txtCantidadStock.Text = string.Empty;
            txtNombre.Focus();

            tsbGuardar.Visible = true;
            tsbActualizar.Visible = false;
            tsbEliminar.Visible = false;
            lblCodigoProducto.Visible = false;
            txtCodigoProducto.Visible = false;
            txtCantidadMinima.Enabled = false;
            txtCantidadStock.Enabled = false;
        }

        #endregion

        #region [Eventos]

        private void frmProductos_Load(object sender, EventArgs e)
        {
            tpProducto.Show();

            //Todo lo que se escriba en ese textbox se convierte a Mayusculas
            //txtNombre.CharacterCasing = CharacterCasing.Upper;
            CargarCombosProveedoryTipoProducto();
            LimpiarCampos();
        }

        private void tpProducto_Enter(object sender, EventArgs e)
        {
            txtNombre.Focus();

            tsbNuevo.Visible = true;
            tsbGuardar.Visible = true;
            tsbEliminar.Visible = false;
            tsbActualizar.Visible = false;
        }

        private void tpListaProductos_Enter(object sender, EventArgs e)
        {
            ListarProductos();
            tsbNuevo.Visible = false;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
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
            this.Close();
        }

        private void dbgProductos_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!objUtilidades.PermitirSoloNumeros(e))
            {
                //Evita que se escriban letras en ese textbox
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void txtPvp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!objUtilidades.PermitirSoloNumeros(e))
            {
                //Evita que se escriban letras en ese textbox
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void txtCantidadMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!objUtilidades.PermitirSoloNumeros(e))
            {
                //Evita que se escriban letras en ese textbox
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void txtCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!objUtilidades.PermitirSoloNumeros(e))
            {
                //Evita que se escriban letras en ese textbox
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void cmbTipoProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoProducto.Text == "Servicio")
            {
                txtCantidadMinima.Enabled = false;
                txtCantidadStock.Enabled = false;
                txtCantidadMinima.Text = string.Empty;
                txtCantidadStock.Text = string.Empty;
            }
            else
            {
                txtCantidadMinima.Enabled = true;
                txtCantidadStock.Enabled = true;
            }
        }

        private void panel1Productos_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
