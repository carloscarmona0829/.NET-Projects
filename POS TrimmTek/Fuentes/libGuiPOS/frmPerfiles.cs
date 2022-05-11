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
    public partial class frmPerfiles : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        private int IdEstadoPerfil;
        private clsEntidadPerfil entidadPerfil;

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmPerfiles()
        {
            InitializeComponent();
        }

        #region [Métodos Públicos]

        private void Guardar()
        {
            try
            {
                entidadPerfil = new clsEntidadPerfil();

                if (this.txtPerfil.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe asignar un nombre al perfil", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                AsignarEntiPerfiles(entidadPerfil);

                DataTable dt = new DataTable();
                dt = objApi.PerfilesCrud("INSERTAR", entidadPerfil);

                if (dt.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Se generó un error al insertar el Perfil", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                    ;
                }
                MessageBox.Show("El Perfil fue creado con Exito", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
                entidadPerfil = new clsEntidadPerfil();
                AsignarEntiPerfiles(entidadPerfil);

                DataTable dt = new DataTable();
                dt = objApi.PerfilesCrud("ACTUALIZAR", entidadPerfil);

                if (dt.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Se generó un error al Actualizar el Perfil", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El Perfil fue Actualizado con Exito", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                LimpiarCampos();
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;
                tsbGuardar.Visible = true;
                txtPerfil.Enabled = true;
                txtPerfil.Focus();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            try
            {
                if (dbgPerfiles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un perfil para eliminar");
                    return;
                }
                entidadPerfil = new clsEntidadPerfil();


                if (
                    MessageBox.Show("Seguro que desea eliminar el Perifl?", "Sistema POS", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    AsignarEntiPerfiles(entidadPerfil);

                    DataTable dt = new DataTable();
                    dt = objApi.PerfilesCrud("INHABILITAR", entidadPerfil);

                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Se generó un error al Eliminar el Perfil", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El Perfil fue Borrado Exitosamente", "Sistema POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    LimpiarCampos();

                    tsbActualizar.Visible = false;
                    tsbEliminar.Visible = false;
                    tsbGuardar.Visible = true;
                    txtPerfil.Enabled = true;
                    txtPerfil.Focus();

                    this.tpListaPerfiles_Enter(sender, e);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            this.txtPerfil.Text = string.Empty;
            this.tsbActualizar.Visible = false;
            this.tsbGuardar.Visible = true;
            this.tsbEliminar.Visible = false;
        }        

        private void ConsultarPerfil(int Id_Estado)
        {
            try
            {
                entidadPerfil = new clsEntidadPerfil();

                AsignarEntiPerfiles(entidadPerfil, Id_Estado);

                tsbGuardar.Visible = false;
                tsbActualizar.Visible = false;
                tsbEliminar.Visible = false;
                
                DataTable dtConsultarPerfil = new DataTable();
                dtConsultarPerfil = objApi.PerfilesCrud("CONSULTAR", entidadPerfil);

                if (dtConsultarPerfil.Rows.Count > 0)
                {
                    if (dtConsultarPerfil.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgPerfiles, dtConsultarPerfil);
                        dbgPerfiles.Splits[0].DisplayColumns["Id"].Visible = false;
                        dbgPerfiles.Splits[0].DisplayColumns["SW"].Visible = false;                        

                        tpListaPerfiles.Enabled = true;
                        return;                
                    }
                    MessageBox.Show(dtConsultarPerfil.Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                MessageBox.Show("Ocurrio un error al consultar la información de los perfiles", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarEntiPerfiles(clsEntidadPerfil entidadPerfil, int IdEstado = 7)
        {
            try
            {
                entidadPerfil.Perfil = txtPerfil.Text;
                entidadPerfil.IdEstado = IdEstado;
                if (dbgPerfiles.Columns.Count > 0)
                {
                    entidadPerfil.IdPerfil = Convert.ToInt32(dbgPerfiles.Columns["Id"].Value);
                    return;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            tpPerfil.Show();
            tsbGuardar.Visible = true;
            //Todo lo que se escriba en ese textbox se convierte a Mayusculas
            txtPerfil.CharacterCasing = CharacterCasing.Upper;
        }

        private void tpPerfil_Enter(object sender, EventArgs e)
        {
            try
            {
                tsbGuardar.Visible = true;
                tsbEliminar.Visible = false;
                tsbActualizar.Visible = false;

                txtPerfil.Focus();

                if (txtPerfil.Text != String.Empty)
                {
                    tsbGuardar.Visible = false;
                    tsbActualizar.Visible = true;
                    tsbEliminar.Visible = true;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpListaPerfiles_Enter(object sender, EventArgs e)
        {
            IdEstadoPerfil = 7;
            ConsultarPerfil(IdEstadoPerfil);
            tsbEliminar.Visible = true;
        }

        private void dbgPerfiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtPerfil.Text = dbgPerfiles.Columns["Perfil"].Text;

                tsbActualizar.Visible = true;
                tsbEliminar.Visible = true;

                tpPerfil.Show();
                tsbGuardar.Visible = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Eliminar(sender, e);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void panelPerfiles_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
