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
    public partial class frmModulos : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        private int IdEstadoModulo;
        private clsEntidadModulosDelSistema entidadModulo;

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmModulos()
        {
            InitializeComponent();
        }

        #region [Métodos Públicos]

        private void LimpiarCampos()
        {
            txtModulo.Text = String.Empty;
            txtModulo.Focus();
            tsbActualizar.Visible = false;
            tsbEliminar.Visible = false;
            tsbGuardar.Visible = true;
        }

        private bool ValidarCampos()
        {
            try
            {
                if (this.txtModulo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Módulo debe tener algún valor", "Sistemas POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Guardar()
        {
            try
            {
                if (ValidarCampos())
                {
                    entidadModulo = new clsEntidadModulosDelSistema();

                    AsignarEntidadModulos(entidadModulo);

                    DataTable dt = new DataTable();
                    dt = objApi.ModulosSistemaCRUD("INSERTAR", entidadModulo);

                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Se generó un error al insertar el Modulo", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; ;
                    }
                    MessageBox.Show("El Modulo fue creado con Exito", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpia los campos de la interfase luego de guardar
                    LimpiarCampos();
                }
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
                if (ValidarCampos())
                {
                    entidadModulo = new clsEntidadModulosDelSistema();
                    AsignarEntidadModulos(entidadModulo);

                    DataTable dt = new DataTable();
                    dt = objApi.ModulosSistemaCRUD("ACTUALIZAR", entidadModulo);

                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Se generó un error al Actualizar el Modulo", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El Modulo fue Actualizado con Exito", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LimpiarCampos();
                    tsbActualizar.Visible = false;
                    tsbEliminar.Visible = false;
                    tsbGuardar.Visible = true;
                    txtModulo.Enabled = true;
                    txtModulo.Focus();
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
                if (dbgModulos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Para eliminar un registro primero debe seleccionarlo", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                entidadModulo = new clsEntidadModulosDelSistema();
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el Modulo?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {

                    AsignarEntidadModulos(entidadModulo);

                    DataTable dtInhabilitarModulo = new DataTable();
                    dtInhabilitarModulo = objApi.ModulosSistemaCRUD("INHABILITAR", entidadModulo);

                    if (dtInhabilitarModulo.Rows.Count > 0)
                    {
                        if (dtInhabilitarModulo.Rows[0]["SW"].ToString() != "0")
                        {
                            MessageBox.Show(dtInhabilitarModulo.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El Modulo fue Borrado Exitosamente", "Sistema POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }

                    LimpiarCampos();

                    tsbActualizar.Visible = false;
                    tsbEliminar.Visible = false;
                    tsbGuardar.Visible = true;
                    txtModulo.Enabled = true;
                    txtModulo.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consultar(int Id_Estado)
        {
            try
            {
                entidadModulo = new clsEntidadModulosDelSistema();

                AsignarEntidadModulos(entidadModulo, Id_Estado);

                tsbGuardar.Visible = false;
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;

                DataTable dtConsultarModulo = new DataTable();
                dtConsultarModulo = objApi.ModulosSistemaCRUD("CONSULTAR", entidadModulo);

                if (dtConsultarModulo.Rows.Count > 0)
                {
                    if (dtConsultarModulo.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgModulos, dtConsultarModulo);
                        dbgModulos.Splits[0].DisplayColumns["SW"].Visible = false;
                        dbgModulos.Splits[0].DisplayColumns["Id"].Visible = false;
                        dbgModulos.Splits[0].DisplayColumns["Estado"].Visible = false;

                        tpListaModulos.Enabled = true;
                        return;
                    }
                }
                MessageBox.Show(dtConsultarModulo.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarEntidadModulos(clsEntidadModulosDelSistema entidadModulos, int IdEstado = 7)
        {
            try
            {
                entidadModulos.Descripcion = txtModulo.Text;
                entidadModulos.IdEstado = IdEstado;
                if (dbgModulos.Columns.Count > 0)
                {
                    entidadModulos.Id_Lista = Convert.ToInt32(dbgModulos.Columns["Id"].Value);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [eventos]

        private void frmModulos_Load(object sender, EventArgs e)
        {
            tpModulos.Show();
            tsbGuardar.Visible = true;
        }

        private void tpModulos_Enter(object sender, EventArgs e)
        {
            tsbGuardar.Visible = true;
            tsbEliminar.Visible = false;
            tsbActualizar.Visible = false;
            tsbNuevo.Visible = true;

            txtModulo.Focus();

            if (txtModulo.Text != String.Empty)
            {
                tsbActualizar.Visible = true;
            }
        }

        private void tpListaModulos_Enter(object sender, EventArgs e)
        {
            IdEstadoModulo = 7;
            Consultar(IdEstadoModulo);
            tsbEliminar.Visible = true;
            tsbNuevo.Visible = false;
        }

        private void dbgModulos_DoubleClick(object sender, EventArgs e)
        {
            txtModulo.Text = dbgModulos.Columns["Modulo"].Text;

            tsbActualizar.Visible = true;
            tpModulos.Show();
            tsbGuardar.Visible = false;
            tsbEliminar.Visible = false;
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
            this.tpListaModulos_Enter(sender, e);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void panelModulos_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
