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
using System.Windows.Forms.VisualStyles;
using libEntidades;
using libInterfaz;

namespace libGuiPOS
{
    public partial class frmPermisosAPerfil : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadPermisosAPerfil entidadPermisosAPerfil = new clsEntidadPermisosAPerfil();
        DataTable dtPermisosAPerfil = new DataTable();
        DataRow drPermisoAPerfil;

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmPermisosAPerfil()
        {
            InitializeComponent();
        }

        #region [Métodos Públicos]

        private void Guardar()
        {
            try
            {
                if (cmbPerfiles.Text == "Seleccionar" || cmbModulos.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un Perfil y un Módulo", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                DataRow[] drGuardarPermisos;

                drGuardarPermisos = dtPermisosAPerfil.Select("SW = '1' OR SW = 'TRUE'");

                int ContIni = dtPermisosAPerfil.Rows.Count;
                int ContFin = ContIni;

                foreach (DataRow row in drGuardarPermisos)
                {
                    entidadPermisosAPerfil.Id_Perfil = Convert.ToInt32(row["Id_Perfil"].ToString());
                    entidadPermisosAPerfil.Id_Modulo = Convert.ToInt32(row["Id_Modulo"].ToString());

                    objApi.PermisosAPerfilCRUD("INSERTAR", entidadPermisosAPerfil);

                    ContFin = ContFin + 1;
                }

                if (ContIni == ContFin)
                {
                    MessageBox.Show("Debe Agregar un Permiso a la Lista", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Los permisos fueron Agregados exitosamente", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                if (entidadPermisosAPerfil.Id_Perfil == 0 && entidadPermisosAPerfil.Id_Modulo == 0)
                {
                    MessageBox.Show("Debe seleccionar un registro de la lista de permisos", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (dbgPermisosAPerfiles.Columns["SW"].Value == "1")
                    {
                        //Elimina el registro eliminado del grid
                        dtPermisosAPerfil.Rows[dbgPermisosAPerfiles.Row].Delete();
                        dtPermisosAPerfil.AcceptChanges();
                        return;
                    }

                    entidadPermisosAPerfil.Id_Perfil = Convert.ToInt32(dbgPermisosAPerfiles.Columns["Id_Perfil"].Text);
                    entidadPermisosAPerfil.Id_Modulo = Convert.ToInt32(dbgPermisosAPerfiles.Columns["Id_Modulo"].Text);

                    objApi.PermisosAPerfilCRUD("ELIMINAR", entidadPermisosAPerfil);

                    MessageBox.Show("Los permisos fueron eliminados exitosamente", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //Elimina el registro eliminado del grid
                    dtPermisosAPerfil.Rows[dbgPermisosAPerfiles.Row].Delete();
                    dtPermisosAPerfil.AcceptChanges();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CrearTablaPermisosAPerfil()
        {
            try
            {
                dtPermisosAPerfil = new DataTable();
                dtPermisosAPerfil.Columns.Add("SW", typeof(string));
                dtPermisosAPerfil.Columns.Add("Id_Perfil", typeof(string));
                dtPermisosAPerfil.Columns.Add("Perfil", typeof(string));
                dtPermisosAPerfil.Columns.Add("Id_Modulo", typeof(string));
                dtPermisosAPerfil.Columns.Add("Modulo", typeof(string));
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarGrid()
        {
            try
            {
                objUtilidades.CargarGrid(dbgPermisosAPerfiles, dtPermisosAPerfil);

                if (dtPermisosAPerfil.Rows.Count > 0)
                {
                    if (dtPermisosAPerfil.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgPermisosAPerfiles, dtPermisosAPerfil);
                        dbgPermisosAPerfiles.Splits[0].DisplayColumns["SW"].Visible = false;
                        dbgPermisosAPerfiles.Splits[0].DisplayColumns["Id_Perfil"].Visible = false;
                        dbgPermisosAPerfiles.Splits[0].DisplayColumns["Id_Modulo"].Visible = false;

                        objUtilidades.CargarGrid(dbgPermisosAPerfiles, dtPermisosAPerfil);
                        dbgPermisosAPerfiles.Splits[0].DisplayColumns["SW"].Visible = false;
                        this.dbgPermisosAPerfiles.Splits[0].DisplayColumns["Perfil"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                        this.dbgPermisosAPerfiles.Splits[0].DisplayColumns["Modulo"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgreagarPermiso()
        {
            try
            {
                if (dtPermisosAPerfil == null)
                {
                    CrearTablaPermisosAPerfil();
                }
                //Agregar filas al DataTable
                DataRow drPermisosAPerfil = dtPermisosAPerfil.NewRow();

                drPermisosAPerfil["SW"] = "1";
                drPermisosAPerfil["Id_Perfil"] = cmbPerfiles.SelectedValue;
                drPermisosAPerfil["Perfil"] = cmbPerfiles.SelectedText;
                drPermisosAPerfil["Id_Modulo"] = cmbModulos.SelectedValue;
                drPermisosAPerfil["Modulo"] = cmbModulos.SelectedText;

                dtPermisosAPerfil.Rows.Add(drPermisosAPerfil);
                dtPermisosAPerfil.AcceptChanges();

                objUtilidades.CargarGrid(dbgPermisosAPerfiles, dtPermisosAPerfil);
                dbgPermisosAPerfiles.Splits[0].DisplayColumns["SW"].Visible = false;
                dbgPermisosAPerfiles.Splits[0].DisplayColumns["Id_Perfil"].Visible = false;
                dbgPermisosAPerfiles.Splits[0].DisplayColumns["Id_Modulo"].Visible = false;

                objUtilidades.CargarGrid(dbgPermisosAPerfiles, dtPermisosAPerfil);
                dbgPermisosAPerfiles.Splits[0].DisplayColumns["SW"].Visible = false;
                this.dbgPermisosAPerfiles.Splits[0].DisplayColumns["Perfil"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                this.dbgPermisosAPerfiles.Splits[0].DisplayColumns["Modulo"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                dsCombos = objApi.CargarCombosPermisosAPerfiles();

                if (dsCombos.Tables[0] != null)
                {
                    objUtilidades.LlenarComboUnicoValor(cmbPerfiles, dsCombos.Tables[0], "Perfil", "Id");
                    cmbPerfiles.Text = "Seleccionar";
                    objUtilidades.LlenarComboUnicoValor(cmbModulos, dsCombos.Tables[1], "Modulo", "Id");
                    cmbModulos.Text = "Seleccionar";
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region [Eventos]

        private void frmPermisosAPerfil_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbModulos.Text != "Seleccionar")
                {
                    for (int i = 0; i < dbgPermisosAPerfiles.RowCount; i++)
                    {
                        if (dbgPermisosAPerfiles[i, "Modulo"].ToString() == this.cmbModulos.Text)
                        {
                            MessageBox.Show("El Modulo " + this.cmbModulos.Text + " ya está agregado", "Sistema POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.cmbModulos.Text = "Seleccionar";
                            return;
                        }
                    }

                    AgreagarPermiso();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Un Perfil y luego un Módulo", "Sistema POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbModulos.Text = "Seleccionar";
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void cmbPerfiles_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmbPerfiles.Text != "Seleccionar")
                {
                    entidadPermisosAPerfil.Id_Perfil = Convert.ToInt32(cmbPerfiles.SelectedValue);
                    dtPermisosAPerfil = objApi.PermisosAPerfilCRUD("CONSULTAR", entidadPermisosAPerfil);

                    if (dtPermisosAPerfil.Rows.Count > 0)
                    {
                        if (dtPermisosAPerfil.Rows[0]["SW"].ToString() == "0")
                        {
                            CargarGrid();
                            return;
                        }
                    }
                    dtPermisosAPerfil = null;
                    dbgPermisosAPerfiles.DataSource = null;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void cmbModulos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPerfiles.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar primero un Perfil", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbgPermisosAPerfiles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    dtPermisosAPerfil.Rows[dbgPermisosAPerfiles.Row].Delete();
                    dtPermisosAPerfil.AcceptChanges();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelPermiso_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
