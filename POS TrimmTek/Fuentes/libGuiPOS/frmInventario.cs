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
using C1.Win.C1TrueDBGrid;
using libInterfaz;
using Microsoft.VisualBasic;
using OfficeExcel = Microsoft.Office.Interop.Excel;

namespace libGuiPOS
{
    public partial class frmInventario : Form
    {
        private clsPosAPI objApi = new clsPosAPI();
        private clsUtilidades objUtilidades = new clsUtilidades();
        private string actualizarProductos;
        private DataSet dsInventario = new DataSet();

        #region [Mover Formularios]

        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        public frmInventario()
        {
            InitializeComponent();
        }

        #region [Métodos Privádos]        

        private void ListarInventario()
        {
            try
            {
                dsInventario = objApi.Inventario("LISTAR INVENTARIO", actualizarProductos);

                if (dsInventario.Tables[0].Rows.Count > 0)
                {
                    objUtilidades.CargarGrid(dbgInventario, dsInventario.Tables[0]);
                    dbgInventario.Splits[0].DisplayColumns["SW"].Visible = false;
                    dbgInventario.Splits[0].DisplayColumns["Cantidad Entra"].Locked = false;

                    return;
                }

               
                MessageBox.Show("No hay Productos para mostrar", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);



            }
            catch (Exception Error)
            {                
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarInventario()
        {
            try
            {
                //Este bloque de código solo recorre las filas del listado de productos que sean actualizadas, las demás las obvia
                DataTable dtInventarioActualiza = new DataTable();
                DataRow[] drActualiza;
                dtInventarioActualiza = dsInventario.Tables[0].Clone();

                drActualiza = dsInventario.Tables[0].Select("SW = '1' OR SW = 'TRUE'");

                foreach (DataRow row in drActualiza)
                {
                    dtInventarioActualiza.ImportRow(row);
                }
                dtInventarioActualiza.AcceptChanges();

                for (int i = 0; i < dtInventarioActualiza.Rows.Count; i++)
                {
                    actualizarProductos += dtInventarioActualiza.Rows[i]["Id_Producto"].ToString() + ":" +
                                           Convert.ToDouble(dtInventarioActualiza.Rows[i]["Total Inventario"]) + ",";
                }

                actualizarProductos = actualizarProductos.Substring(0, actualizarProductos.Length - 1);
                dsInventario = objApi.Inventario("ACTUALIZAR INVENTARIO", actualizarProductos);

                objUtilidades.CargarGrid(dbgInventario, dsInventario.Tables[0]);
                dbgInventario.Splits[0].DisplayColumns["SW"].Visible = false;
                dbgInventario.Splits[0].DisplayColumns["Cantidad Entra"].Locked = false;

                actualizarProductos = string.Empty;

                MessageBox.Show("Inventario Actualizado Exitosamente", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CalcularTotal()
        {
            if (dbgInventario.Columns["Cantidad Entra"].Text != string.Empty)
            {
                dbgInventario.Columns["SW"].Text = "1";
                dbgInventario.Columns["Total Inventario"].Text =
                    (Convert.ToDouble(dbgInventario.Columns["Existencias"].Text) +
                     Convert.ToDouble(dbgInventario.Columns["Cantidad Entra"].Text)).ToString();
                return;
            }

            dbgInventario.Columns["SW"].Text = "0";
            dbgInventario.Columns["Total Inventario"].Text = string.Empty;
        }

        private DataSet ExportarInventario()
        {
            DataSet ds = new DataSet();
            ds = objApi.Inventario("LISTAR INVENTARIO", actualizarProductos);

            return ds;
        }

        private void Exportar_Excel(DataSet ds, string strPath)
        {
            int inHeaderLength = 3, inColumn = 0, inRow = 0;
            System.Reflection.Missing Default = System.Reflection.Missing.Value;
            //Create Excel File
            //strPath += @"\Excel" + DateTime.Now.ToString().Replace(':', '-') + ".xlsx";
            //strPath += @"\Excel.xlsx"; Aquí se pone un path específico si se desea guardar siempre en un lugar
            OfficeExcel.Application excelApp = new OfficeExcel.Application();
            OfficeExcel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);
            foreach (DataTable dtbl in ds.Tables)
            {
                //Create Excel WorkSheet
                OfficeExcel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count], 1, Default);
                excelWorkSheet.Name = "Productos";//dtbl.TableName;//Name worksheet

                int cont = 0;

                if (cont == 0)
                {

                    //Excel Header
                    OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "H1");
                    cellRang.Merge(false);
                    cellRang.Interior.Color = System.Drawing.Color.White;
                    cellRang.Font.Color = System.Drawing.ColorTranslator.FromHtml("#31b1ed");
                    cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
                    cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
                    cellRang.Font.Size = 26;
                    excelWorkSheet.Cells[1, 1] = "Listado de Productos";


                    //Style table column names
                    cellRang = excelWorkSheet.get_Range("A4", "H4");
                    cellRang.Font.Bold = true;
                    cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                    cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#4c92b5");
                    excelWorkSheet.get_Range("F4").EntireColumn.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignRight;
                    //Formate price column
                    excelWorkSheet.get_Range("E5", "F5").EntireColumn.NumberFormat = "0";
                    //Auto fit columns
                    excelWorkSheet.Columns.AutoFit();

                    cont = cont + 1;
                }

                //Write Column Name
                for (int i = 0; i < dtbl.Columns.Count; i++)
                    excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = dtbl.Columns[i].ColumnName.ToUpper();

                //Write Rows
                for (int m = 0; m < dtbl.Rows.Count; m++)
                {
                    for (int n = 0; n < dtbl.Columns.Count; n++)
                    {
                        inColumn = n + 1;
                        inRow = inHeaderLength + 2 + m;
                        excelWorkSheet.Cells[inRow, inColumn] = dtbl.Rows[m].ItemArray[n].ToString();
                        if (m % 2 == 0)
                            excelWorkSheet.get_Range("A" + inRow.ToString(), "H" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#cce2ed");
                    }
                }
               
            }

            //Delete First Page
            excelApp.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet lastWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets[1];
            lastWorkSheet.Delete();
            excelApp.DisplayAlerts = true;

            //Set Defualt Page
            (excelWorkBook.Sheets[1] as OfficeExcel._Worksheet).Activate();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            MessageBox.Show("Archivo Generado Exitosamente", "Sistema POS", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private string CapturarRutaArchivo()
        {
            //Este metodo no esta guardando el archivo en este momento, solo esta capturando la ruta para guardarla
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.FileName = DateTime.Now.ToString("ddd dd MMM yyy");

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return "Cancelado";
            }

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                //System.IO.FileStream fs = 
                //(System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                //switch (saveFileDialog1.FilterIndex)
                //{
                //    case 1:
                //        this.button1.Image.Save(fs,
                //          System.Drawing.Imaging.ImageFormat.Jpeg);
                //        break;

                //    case 2:
                //        this.button1.Image.Save(fs,
                //          System.Drawing.Imaging.ImageFormat.Bmp);
                //        break;

                //    case 3:
                //        this.button1.Image.Save(fs,
                //          System.Drawing.Imaging.ImageFormat.Gif);
                //        break;
                //}
                //fs.Close();

                string strRuta = saveFileDialog1.FileName;

                return strRuta;

            }
            return "Cancelado";
        }

        #endregion

        #region [Eventos]

        private void frmInventario_Load(object sender, EventArgs e)
        {
            ListarInventario();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea actulizar el inventario", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ActualizarInventario();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelInventario_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dbgInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!objUtilidades.PermitirSoloNumeros(e))
            //{
            //    //Evita que se escriban letras en ese control
            //    e.Handled = true;
            //    return;
            //}
            //e.Handled = false;         

        }

        private void dbgInventario_BeforeColUpdate(object sender, BeforeColUpdateEventArgs e)
        {
            //if (objUtilidades.PermitirSoloNumeros(e))
            //{
            //    //Evita que se escriban letras en ese control
            //    e.Handled = true;
            //    return;
            //}
            //e.Handled = false;

            //Valida que solo se puedan ingresar valores positivos
            if (e.Column.Name == "Cantidad Entra" && dbgInventario.Columns["Cantidad Entra"].Text == string.Empty || e.Column.Name == "Cantidad Entra" &&
                (Convert.ToInt32(dbgInventario.Columns["Cantidad Entra"].Text) == 0))
            {
                dbgInventario.Columns["SW"].Text = "0";
                dbgInventario.Columns["Cantidad Entra"].Text = string.Empty;
                dbgInventario.Columns["Total Inventario"].Text = string.Empty;
                return;
            }
            CalcularTotal();
        }

        private void tsbExportar_Click(object sender, EventArgs e)
        {
            DataSet dsData = ExportarInventario();
            string strPath = CapturarRutaArchivo();
            if (dsData != null && strPath != "Cancelado")
            {
                Exportar_Excel(dsData, strPath);
            }
            return;
        }


        #endregion
        
    }
}