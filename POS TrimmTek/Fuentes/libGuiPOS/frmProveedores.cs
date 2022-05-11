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
    public partial class frmProveedores : Form
    {
        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadProveedor entidadProveedor = new clsEntidadProveedor();
        DataTable dtProveedores = new DataTable();

        public frmProveedores()
        {
            InitializeComponent();
        }

        #region [Métodos Privádos]

        private void ListarProveedores()
        {
            try
            {
                tsbGuardar.Visible = false;
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;

                dtProveedores = objApi.ProveedoresCrud("LISTAR PROVEEDORES", entidadProveedor);

                if (dtProveedores.Rows.Count > 0)
                {
                    if (dtProveedores.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGridOcultaResultado(dbgProveedores, dtProveedores);
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                if (this.txtNit.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el Nit del Proveedor", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNit.Focus();
                    return false;
                }
                if (this.txtRazonSocial.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la Razón Social del Proveedor", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtRazonSocial.Focus();
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

        private void AsignarEntidadProveedor()
        {
            entidadProveedor.NIT = txtNit.Text;
            entidadProveedor.Razon_Social = txtRazonSocial.Text;
            entidadProveedor.Email_Proveedor = txtEmail.Text;
            entidadProveedor.Celular = txtCelular.Text;
            entidadProveedor.Tl_Fijo = txtFijo.Text;
            entidadProveedor.DirProveedor = txtDireccion.Text;
            entidadProveedor.Id_Estado = 7;
            entidadProveedor.Nombre_Contacto = txtContacto.Text;
            entidadProveedor.Usu_CreaProveedor = clsEntidadAutenticacion.Usuariologin;
            entidadProveedor.Fecha_CreaProveedor = Convert.ToString(DateTime.Now);
            entidadProveedor.Usu_ModProveedor = clsEntidadAutenticacion.Usuariologin;
            entidadProveedor.Fecha_ModProveedor = Convert.ToString(DateTime.Now);
        }

        private void Guardar()
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                AsignarEntidadProveedor();

                DataTable dtInsertarProductos = new DataTable();
                dtInsertarProductos = objApi.ProveedoresCrud("INSERTAR", entidadProveedor);

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

        private void LimpiarCampos()
        {
            txtNit.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtFijo.Text = string.Empty;
            txtNit.Focus();

            tsbGuardar.Visible = true;
            tsbActualizar.Visible = false;
            tsbEliminar.Visible = false;
            lblIdProveedor.Visible = false;
            txtIdProveedor.Visible = false;
            
        }

        private void Actualizar()
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }
                entidadProveedor.Id_Proveedor = Convert.ToInt32(txtIdProveedor.Text);
                AsignarEntidadProveedor();

                DataTable dt = new DataTable();
                dt = objApi.ProveedoresCrud("ACTUALIZAR", entidadProveedor);

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
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el Proveedor ?", "Sistema POS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    AsignarEntidadProveedor();

                    DataTable dtInhabilitarProductos = new DataTable();
                    dtInhabilitarProductos = objApi.ProveedoresCrud("ELIMINAR", entidadProveedor);

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

        private void SeleccionarProveedor()
        {
            txtIdProveedor.Text = dbgProveedores.Columns["Id_Proveedor"].Text;
            txtNit.Text = dbgProveedores.Columns["NIT"].Text;
            txtRazonSocial.Text = dbgProveedores.Columns["Razon_Social"].Text;
            txtDireccion.Text = dbgProveedores.Columns["Direccion"].Text;
            txtFijo.Text = dbgProveedores.Columns["Tl_Fijo"].Text;
            txtCelular.Text = dbgProveedores.Columns["Celular"].Text;
            txtContacto.Text = dbgProveedores.Columns["Nombre_Contacto"].Text;
            txtEmail.Text = dbgProveedores.Columns["Email_Proveedor"].Text;

            txtIdProveedor.ReadOnly = true;
            lblIdProveedor.Visible = true;
            txtIdProveedor.Visible = true;

            tpProveedor.Show();
            tsbActualizar.Visible = true;
            tsbEliminar.Visible = true;
        }
        
        #endregion

        #region [Eventos]

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            tpProveedor.Show();
            txtRazonSocial.CharacterCasing = CharacterCasing.Upper;
            txtContacto.CharacterCasing = CharacterCasing.Upper;
        }

        private void tpProveedor_Enter(object sender, EventArgs e)
        {
            txtNit.Focus();

            tsbNuevo.Visible = true;
            tsbGuardar.Visible = true;
            tsbEliminar.Visible = false;
            tsbActualizar.Visible = false;

        }

        private void tpListaProveedores_Enter(object sender, EventArgs e)
        {
            ListarProveedores();
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
            Close();
        }

        private void dbgProveedores_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarProveedor();
        }

        private void panelProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
