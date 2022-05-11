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
    public partial class frmVentasProductos : Form
    {
        private clsPosAPI objApi = new clsPosAPI();
        private clsUtilidades objUtilidades = new clsUtilidades();
        private clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();
        private DataSet dsListaVentas = new DataSet();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmVentasProductos()
        {
            InitializeComponent();
        }

        #region [Métodos Privádos]

        public void ListarVentas()
        {
            try
            {
                entidadFacturacion.Fecha_Fact = dtpFechaInicio.Value.ToString("yyyyMMdd");  //Fecha Inicio
                entidadFacturacion.Fecha_ModFact = dtpFechaFin.Value.ToString("yyyyMMdd");  //Fecha Fin

                dsListaVentas = objApi.FacturacionCrud("LISTAR VENTAS PRODUCTOS", entidadFacturacion);

                if (dsListaVentas.Tables.Count > 0)
                {
                    if (dsListaVentas.Tables[0].Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay información disponible para las fechas seleccionadas", "Sistema POS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    if (dsListaVentas.Tables[0].Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgVentas, dsListaVentas.Tables[0]);

                        this.dbgVentas.Splits[0].DisplayColumns["Numero_Factura"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                        this.dbgVentas.Splits[0].DisplayColumns["Empleado"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                        this.dbgVentas.Splits[0].DisplayColumns["Cliente"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                        this.dbgVentas.Splits[0].DisplayColumns["SW"].Visible = false;

                        return;
                    }
                }

                MessageBox.Show("Error en la base de datos. Comuníquese con el Proveedor", "Sistema POS",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        #endregion

    }
}
