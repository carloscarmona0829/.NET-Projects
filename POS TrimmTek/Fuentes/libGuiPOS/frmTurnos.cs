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
    public partial class frmTurnos : Form
    {
        private clsPosAPI objApi = new clsPosAPI();
        private clsUtilidades objUtilidades = new clsUtilidades();
        private clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();
        private DataSet dsListaTurnos = new DataSet();


        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmTurnos()
        {
            InitializeComponent();
        }

        #region [Métodos Privádos]
        public void ListarTurnos()
        {
            try
            {
                entidadFacturacion.Identificacion_Cliente = string.Empty;
                entidadFacturacion.Id_Barbero = 0;
                entidadFacturacion.Usu_CreaFact = String.Empty;
                entidadFacturacion.Fecha_Fact = String.Empty;
                entidadFacturacion.Id_Producto = 0;
                entidadFacturacion.Cantidad = 0;
                entidadFacturacion.Vlr_Unitario = 0;
                entidadFacturacion.CreaEncabezado = false;

                dsListaTurnos = objApi.FacturacionCrud("LISTAR TURNOS", entidadFacturacion);

                if (dsListaTurnos.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("No hay ninguna factura creada en la base de datos", "Sistema POS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (dsListaTurnos.Tables.Count > 0)
                {
                    objUtilidades.CargarGrid(dbgTurnos, dsListaTurnos.Tables[0]);
                    dbgTurnos.Splits[0].DisplayColumns["Id"].Visible = false;
                    dbgTurnos.Splits[0].DisplayColumns["NumeroVerificacion"].Visible = false;
                    dbgTurnos.Splits[0].DisplayColumns["DigitoVerificacion"].Visible = false;
                    dbgTurnos.Splits[0].DisplayColumns["Id_Cliente"].Visible = false;
                    dbgTurnos.Splits[0].DisplayColumns["Id_Barbero"].Visible = false;

                    this.dbgTurnos.Splits[0].DisplayColumns["Empleado"].Merge =
                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                    this.dbgTurnos.Splits[0].DisplayColumns["Producto"].Merge =
                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;

                    return;
                }

                MessageBox.Show(dsListaTurnos.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            ListarTurnos();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTurnos_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
       
    }
}


