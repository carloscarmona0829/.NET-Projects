using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
    public partial class frmNomina : Form
    {
        public frmNomina()
        {
            InitializeComponent();
        }

        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadNomina entidadNomina = new clsEntidadNomina();
        DataSet dsNomina = new DataSet();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region [Métodos Públicos]

        private void LlenarComboEmpleado()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();
                dsCombos = objApi.FacturacionCrud("LISTARBARBEROS", entidadFacturacion);

                if (dsCombos.Tables.Count > 0)
                {
                    if (dsCombos.Tables[0] != null)
                    {
                        objUtilidades.LlenarComboUnicoValor(cmbEmpleado, dsCombos.Tables[0], "Nombre", "Id");
                        string[] strColumnaVisible = new string[] { "Nombre" };
                        objUtilidades.OcultarColumnasCombos(cmbEmpleado, dsCombos.Tables[0], strColumnaVisible);
                        cmbEmpleado.Enabled = true;
                        cmbEmpleado.Text = "Todos";
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

        private void CargarEntidad()
        {
            try
            {
                if (cmbEmpleado.Text != "Todos")
                {
                    entidadNomina.Id_Barbero = Convert.ToInt32(cmbEmpleado.SelectedValue);
                }

                entidadNomina.Fecha_Inicio = Convert.ToDateTime(dtpDesde.Text)
                    .ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                entidadNomina.Fecha_Fin = Convert.ToDateTime(dtpHasta.Text)
                    .ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                if (chkCalcularVentas.Checked)
                {
                    entidadNomina.CalcularVentas = true;
                }
                else
                {
                    entidadNomina.CalcularVentas = false;
                }
                entidadNomina.Usu_CreaNomina = clsEntidadAutenticacion.Usuariologin;
                if (string.IsNullOrEmpty(entidadNomina.Usu_CreaNomina))
                {
                    entidadNomina.Usu_CreaNomina = clsEntidadAutenticacion.Usuariologin;
                }
                entidadNomina.Fecha_CreaNomina = Convert.ToDateTime(DateTime.Now)
                    .ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));

                entidadNomina.Id_Estado = 7;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarNomina()
        {
            try
            {
                CargarEntidad();

                dsNomina = objApi.Nomina("INSERTAR", entidadNomina);

                 if (dsNomina.Tables.Count > 0)
                {
                    if (dsNomina.Tables[0].Rows.Count > 0)
                    {
                        if (dsNomina.Tables[0].Rows[0]["SW"].ToString() != "0")
                        {
                            //Mensaje de Error
                            MessageBox.Show(dsNomina.Tables[0].Rows[0]["MENSAJE"].ToString(), "Sistema POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        MessageBox.Show(dsNomina.Tables[0].Rows[0]["MENSAJE"].ToString(), "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        if (dsNomina.Tables.Count > 1)
                        {
                            if (dsNomina.Tables[1].Rows.Count > 0)
                            {
                                if (dsNomina.Tables[1].Rows[0]["SW"].ToString() == "0")
                                {
                                    objUtilidades.CargarGrid(dbgNomina, dsNomina.Tables[1]);
                                    dbgNomina.Splits[0].DisplayColumns["SW"].Visible = false;
                                    dbgNomina.Splits[0].DisplayColumns["Id_Nomina"].Visible = false;
                                    dbgNomina.Splits[0].DisplayColumns["Usuario Crea Nómina"].Visible = false;
                                    dbgNomina.Splits[0].DisplayColumns["Usuario Modifica"].Visible = false;
                                    dbgNomina.Splits[0].DisplayColumns["Fecha Modifica"].Visible = false;
                                    dbgNomina.Splits[0].DisplayColumns["Fecha Genera Nómina"].Visible = false;

                                   this.dbgNomina.Splits[0].DisplayColumns["Nom_Usuario"].Merge =
                                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                                    this.dbgNomina.Splits[0].DisplayColumns["Nom_Producto"].Merge =
                                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                                    this.dbgNomina.Splits[0].DisplayColumns["Fecha Desde"].Merge =
                                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                                    this.dbgNomina.Splits[0].DisplayColumns["Fecha Hasta"].Merge =
                                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;

                                    return;
                                }

                                MessageBox.Show(dsNomina.Tables[1].Rows[0]["MENSAJE"].ToString(), "Sistema POS",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        MessageBox.Show("Error en el sistema.\n\rComuníquese con el proveedor", "Sistema POS",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmNomina_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleado();
        }

        private void tsbGenerarNomina_Click(object sender, EventArgs e)
        {
            GenerarNomina();
        }

        private void panelNomina_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        
    }
}
