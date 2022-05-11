using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1List;
using C1.Win.C1TrueDBGrid;
using libEntidades;
using libInterfaz;
using libEntidades;
using libInterfaz;
using Microsoft.VisualBasic;
using CancelEventArgs = System.ComponentModel.CancelEventArgs;


//1. abrirFrmListaClientes tiene una variable de tipo EntidadUsuario que se llenó en ese formulario y la estamos trayendo con su propiedad IdUsuario

namespace libGuiPOS
{
    public partial class frmFacturacion : Form
    {
        Timer Hora = new Timer();
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadUsuario entidadUsuario = new clsEntidadUsuario();
        clsEntidadProductos entidadProductos = new clsEntidadProductos();
        clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();
        DataTable dtProductos = new DataTable();
        DataTable dtComanda = new DataTable();
        DataSet dsListaFactura = new DataSet();
        DataSet dsGuardarFactura = new DataSet();
        DataSet dsImprimir = new DataSet();
        private int TotalMismoProducto = 0; //Vble para capturar lo que hay en la Col Total de la Comanda antes de ser borrado
        private int TotalFactura = 0;//Vble para capturar lo que hay en txtTotalFactura antes de ser borrado
        private bool Reimprimir = false;
        private bool EliminarRegistro = false;
        private string CantComandaActualiza = string.Empty;// Vble para almacenar la cantidad al ser modificada desde la grid. Se usa porque no encontramos alternativa OJO NO QUITAR
        private string Efectivo;//Cantidad recibida en efectivo para imprimirlo en la factura
        private string Cambio;//Devuelta para imprimirla en la factura
        private bool Liquidacion;//Variable que me controla desde la BD si el establecimiento obligara a usar la funcion de liquidar o no (0 para no, 1 para si)tblParametros
        private bool Imprimirturno;//Variable que me controla desde la BD si el establecimiento imprimira turnos o no (0 para no, 1 para si)tblParametros
        private string UsuarioLogueado;

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public frmFacturacion()
        {
            InitializeComponent();
        }

        #region [Metodos Privados]

        private void ParametrosFacturacion()
        {
            try
            {
                DataSet dsParametrosFacturacion = new DataSet();
                dsParametrosFacturacion = objApi.ParametrosFacturacion();

                if (dsParametrosFacturacion.Tables[0] != null)
                {
                    if (dsParametrosFacturacion.Tables[0].Rows[0]["Valor"].ToString() == "1")
                    {
                        Imprimirturno = true;
                    }
                    else
                    {
                        Imprimirturno = false;
                    }
                    if (dsParametrosFacturacion.Tables[0].Rows[1]["Valor"].ToString() == "1")
                    {
                        Liquidacion = true;
                        tsbLiquidar.Visible = false;
                    }
                    else
                    {
                        Liquidacion = false;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarFactura(PrintPageEventArgs e)
        {
            try
            {
                DataTable dtDatosFactura = new DataTable();
                dtDatosFactura = dsImprimir.Tables[0];

                Font prFont = new Font("Arial", 10, FontStyle.Regular);
                Font prFontb = new Font("Arial", 10, FontStyle.Bold);
                Font prFontR = new Font("Arial", 12, FontStyle.Bold);
                //Rectangle TamañoPapel = new Rectangle(0, 0, 300, 140);
                //StringFormat stringFormat = new StringFormat();
                //stringFormat.Alignment = StringAlignment.Center;
                //stringFormat.LineAlignment = StringAlignment.Center;

                //Captura fecha y hora, los separa, formatea la fecha y los concatena para mostrarlos en la factura
                string FechaHora = dsImprimir.Tables[0].Rows[0]["Fecha"].ToString();
                string[] Fecha_Hora = FechaHora.Split('/');
                string Fecha = Convert.ToDateTime(Fecha_Hora[0])
                    .ToString("dd/MM/yyyy");
                string Hora = Fecha_Hora[1];
                string FechaFactura = Fecha + "  " + Hora;

                //Separación de las Leyendas del sistema que en la tabla Parametros de la base de datos estan separadas con /
                string LeyendaBd = dsImprimir.Tables[1].Rows[8]["ParametrosFactura"].ToString();
                string[] Leyendas = LeyendaBd.Split('/');
                string leyenda1 = Leyendas[0];
                string leyenda2 = Leyendas[1];

                e.Graphics.DrawString(dsImprimir.Tables[1].Rows[1]["ParametrosFactura"].ToString(), prFontR,
                    Brushes.Black, 70, 10);
                e.Graphics.DrawString("NIT: " + dsImprimir.Tables[1].Rows[0]["ParametrosFactura"].ToString(), prFont,
                    Brushes.Black, 84, 40);
                e.Graphics.DrawString(dsImprimir.Tables[1].Rows[5]["ParametrosFactura"].ToString(), prFont, Brushes.Black,
                    82, 60);
                e.Graphics.DrawString("Telefono: " + dsImprimir.Tables[1].Rows[2]["ParametrosFactura"].ToString(), prFont,
                    Brushes.Black, 80, 80);
                e.Graphics.DrawString(dsImprimir.Tables[1].Rows[6]["ParametrosFactura"].ToString(), prFont, Brushes.Black,
                    82, 100);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                    115);
                e.Graphics.DrawString(dsImprimir.Tables[1].Rows[7]["ParametrosFactura"].ToString(), prFontb,
                    Brushes.Black, 10, 130);
                e.Graphics.DrawString(dtDatosFactura.Rows[0]["Factura"].ToString(), prFontb, Brushes.Black, 200, 130);
                e.Graphics.DrawString("Fecha Hora:   " + FechaFactura, prFont, Brushes.Black, 10, 155);
                e.Graphics.DrawString("Empleado: " + dsImprimir.Tables[0].Rows[0]["Empleado"].ToString(), prFont,
                    Brushes.Black, 10, 180);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                    195);
                e.Graphics.DrawString("DATOS DEL CLIENTE ", prFontb, Brushes.Black, 10, 210);
                e.Graphics.DrawString("Cliente: " + dsImprimir.Tables[0].Rows[0]["Cliente"].ToString(), prFont,
                    Brushes.Black, 10, 235);
                e.Graphics.DrawString("Nit/C.C: " + dsImprimir.Tables[0].Rows[0]["Identificacion"].ToString(), prFont,
                    Brushes.Black, 10, 260);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                    275);
                e.Graphics.DrawString("ITEM    " + "DESCRIPCION    " + "  CANT    " + "VALOR", prFontb, Brushes.Black, 10, 290);

                int contAlto = 315;
                for (int i = 0; i < dtDatosFactura.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Id_Producto"].ToString(), prFont, Brushes.Black, 25, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Nom_Producto"].ToString(), prFont, Brushes.Black, 60, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Cantidad"].ToString(), prFont, Brushes.Black, 195, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Total"].ToString(), prFont, Brushes.Black, 235, contAlto);
                    contAlto += 15;
                }

                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                    contAlto);
                e.Graphics.DrawString("TOTAL", prFontb, Brushes.Black, 10, contAlto += 15);
                e.Graphics.DrawString(dtDatosFactura.Rows[0]["TotFact"].ToString(), prFontb, Brushes.Black, 235, contAlto);

                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                   contAlto + 15);

                if (!Reimprimir && Efectivo != null && decimal.Parse(Efectivo) > decimal.Parse(dtDatosFactura.Rows[0]["TotFact"].ToString()))
                {
                    e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                     contAlto + 20);

                    e.Graphics.DrawString("Efectivo", prFont, Brushes.Black, 10, contAlto += 30);
                    e.Graphics.DrawString(decimal.Parse(Efectivo).ToString("##,###"), prFont, Brushes.Black, 235, contAlto);

                    e.Graphics.DrawString("CAMBIO", prFontR, Brushes.Black, 10, contAlto += 15);
                    e.Graphics.DrawString(decimal.Parse(Cambio).ToString("##,###"), prFontR, Brushes.Black, 232, contAlto);
                }

                if (Reimprimir == true)
                {
                    e.Graphics.DrawString("******* COPIA *******", prFont, Brushes.Black, 75, contAlto += 35);
                }

                e.Graphics.DrawString(dsImprimir.Tables[1].Rows[3]["ParametrosFactura"].ToString(), prFont, Brushes.Black,
                    60, contAlto += 40);
                e.Graphics.DrawString(leyenda1, prFont, Brushes.Black, 73, contAlto += 20);
                e.Graphics.DrawString(leyenda2, prFontb, Brushes.Black, 88, contAlto += 20);

                e.HasMorePages = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarTurno(PrintPageEventArgs e)
        {
            try
            {
                DataTable dtDatosFactura = new DataTable();
                dtDatosFactura = dsImprimir.Tables[0];

                Font prFont = new Font("Arial", 10, FontStyle.Regular);
                Font prFontLineas = new Font("Arial", 10, FontStyle.Bold);
                Font prFontb = new Font("Arial", 10, FontStyle.Bold);
                Font prFontG = new Font("Arial", 30, FontStyle.Bold);
                Font prFontR = new Font("Arial", 11, FontStyle.Bold);
                //Rectangle TamañoPapel = new Rectangle(0, 0, 300, 140);
                //StringFormat stringFormat = new StringFormat();
                //stringFormat.Alignment = StringAlignment.Center;
                //stringFormat.LineAlignment = StringAlignment.Center;

                //Captura fecha y hora, los separa, formatea la fecha y los concatena para mostrarlos en la factura
                string FechaHora = dsImprimir.Tables[0].Rows[0]["Fecha"].ToString();
                string[] Fecha_Hora = FechaHora.Split('/');
                string Fecha = Convert.ToDateTime(Fecha_Hora[0])
                    .ToString("dd/MM/yyyy");
                string Hora = Fecha_Hora[1];
                string FechaFactura = Fecha + "  " + Hora;

                //e.Graphics.DrawString("Comprobante de Servicio: " + dsGuardarFactura.Tables[0].Rows[1]["Id"].ToString(),
                //prFonttitulo, Brushes.Black, 10, 10);

                e.Graphics.DrawString(
                    "Turno " + dsGuardarFactura.Tables[1].Rows[0]["CantTurnos"].ToString(), prFontG, Brushes.Black, 70, 10);
                e.Graphics.DrawString(
                    "Recibo de Caja Numero: " + dsGuardarFactura.Tables[1].Rows[0]["Numero_Factura"].ToString(), prFont, Brushes.Black, 10, 60);
                e.Graphics.DrawString(
                   "Nro Verificación: " + dsGuardarFactura.Tables[1].Rows[0]["NumeroVerificacion"].ToString() + " - " +
                   dsGuardarFactura.Tables[1].Rows[0]["DigitoVerificacion"].ToString(), prFont, Brushes.Black, 10, 75);
                e.Graphics.DrawString("----------------------------------------------------------", prFontLineas, Brushes.Black,
                    10, 85);
                e.Graphics.DrawString("Fecha Hora: " + FechaFactura, prFont, Brushes.Black, 10, 100);
                e.Graphics.DrawString("----------------------------------------------------------", prFontLineas, Brushes.Black,
                    10, 110);
                e.Graphics.DrawString("Cliente: " + dsGuardarFactura.Tables[1].Rows[0]["Cliente"].ToString(), prFont,
                    Brushes.Black, 10, 125);
                e.Graphics.DrawString("Empleado:" + dsGuardarFactura.Tables[1].Rows[0]["Empleado"].ToString(), prFontR,
                    Brushes.Black, 10, 140);
                e.Graphics.DrawString("----------------------------------------------------------", prFontLineas, Brushes.Black,
                    10, 150);
                e.Graphics.DrawString("ITEM    " + "DESCRIPCION    " + "  CANT    " + "VALOR", prFontb, Brushes.Black, 10, 165);

                int contAlto = 180;
                for (int i = 0; i < dsGuardarFactura.Tables[1].Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Id_Producto"].ToString(), prFont, Brushes.Black, 25, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Nom_Producto"].ToString(), prFont, Brushes.Black, 60, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Cantidad"].ToString(), prFont, Brushes.Black, 195, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Total"].ToString(), prFont, Brushes.Black, 235, contAlto);
                    contAlto += 15;
                }

                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10,
                    contAlto);
                e.Graphics.DrawString("TOTAL", prFontb, Brushes.Black, 10, contAlto += 15);
                e.Graphics.DrawString(dtDatosFactura.Rows[0]["TotFact"].ToString(), prFontb, Brushes.Black, 235, contAlto);

                e.HasMorePages = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Liquidar()
        {
            try
            {
                if (txtTotalFactura.Text == "0")
                {
                    MessageBox.Show("Debe diligenciar todos los campos antes de liquidar", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }

                frmLiquidar abrirFormLiquidar = new frmLiquidar();
                abrirFormLiquidar.txtTotalVenta.Text = txtTotalFactura.Text;
                abrirFormLiquidar.ShowDialog();

                if (abrirFormLiquidar.RealizarFactura)
                {
                    Efectivo = abrirFormLiquidar.txtDineroRecibido.Text;
                    Cambio = abrirFormLiquidar.txtDevuelta.Text;
                    GuardarFactura();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Imprimir(int NumeroFactura)
        {
            try
            {
                clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();

                entidadFacturacion.Numero_Factura = NumeroFactura;
                entidadFacturacion.Identificacion_Cliente = string.Empty;
                entidadFacturacion.Id_Barbero = 0;
                entidadFacturacion.Usu_CreaFact = clsEntidadAutenticacion.Usuariologin;
                if (entidadFacturacion.Usu_CreaFact == null)
                {
                    entidadFacturacion.Usu_CreaFact = Environment.UserName;
                }
                entidadFacturacion.Fecha_Fact = string.Empty;
                entidadFacturacion.Id_Producto = 0;
                entidadFacturacion.Cantidad = 0;
                entidadFacturacion.Vlr_Unitario = 0;
                entidadFacturacion.CreaEncabezado = false;
                entidadFacturacion.Id_Factura = 0;
                entidadFacturacion.Id_Factura_Det = 0;

                dsImprimir = objApi.FacturacionCrud("IMPRIMIR", entidadFacturacion);

                if (dsImprimir.Tables.Count > 0)
                {
                    if (dsImprimir.Tables[0].Rows[0]["SW"].ToString() == "0")
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string BuscarCliente()
        {
            try
            {
                entidadUsuario.IdUsuario = this.txtIdentificacion.Text;
                entidadUsuario.nombre = "";
                entidadUsuario.email = "";
                entidadUsuario.tipouser = 12;

                DataTable dtUsuarios = new DataTable();
                dtUsuarios = objApi.UsuariosCrud("CONSULTAR", entidadUsuario);

                if (dtUsuarios.Rows.Count > 0)
                {
                    if (dtUsuarios.Rows[0]["SW"].ToString() == "0")
                    {
                        return dtUsuarios.Rows[0]["Nombre"].ToString();
                    }

                    return dtUsuarios.Rows[0]["Mensaje"].ToString();
                }

                return string.Empty;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void AnularFactura(string UsuarioAutoriza, string PwdUsuarioAutoriza)
        {
            try
            {
                objApi = new clsPosAPI();
                DataSet dsAnular = new DataSet();

                entidadFacturacion.Identificacion_Cliente = string.Empty;
                entidadFacturacion.Id_Barbero = 0;
                entidadFacturacion.Usu_CreaFact = string.Empty;
                entidadFacturacion.Fecha_Fact = string.Empty;
                entidadFacturacion.Id_Producto = 0;
                entidadFacturacion.Cantidad = 0;
                entidadFacturacion.Vlr_Unitario = 0;
                entidadFacturacion.CreaEncabezado = false;
                entidadFacturacion.Numero_Factura = Convert.ToInt32(dbgFacturas.Columns["Factura"].Text);
                entidadFacturacion.UsuarioAutoriza = UsuarioAutoriza;
                entidadFacturacion.PwdUsuarioAutoriza = PwdUsuarioAutoriza;
                entidadFacturacion.Usu_ModFact = clsEntidadAutenticacion.Usuariologin;
                entidadFacturacion.Fecha_ModFact = Convert.ToDateTime(DateTime.Now)
                        .ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));
                entidadFacturacion.CrearTruno = false;

                dsAnular = objApi.FacturacionCrud("ANULAR", entidadFacturacion);

                if (dsAnular.Tables[0].Rows.Count > 0)
                {
                    if (dsAnular.Tables[0].Rows[0]["SW"].ToString() != "0")
                    {                       
                        MessageBox.Show(dsAnular.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    objUtilidades.CargarGrid(dbgFacturas, dsAnular.Tables[1]);
                    dbgFacturas.Splits[0].DisplayColumns["SW"].Visible = false;
                    this.dbgFacturas.Splits[0].DisplayColumns["Cliente"].Merge =
                            C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                    this.dbgFacturas.Splits[0].DisplayColumns["Empleado"].Merge =
                        C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                    MessageBox.Show(dsAnular.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CargarGridProductos();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarFacturas()
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

                dsListaFactura = objApi.FacturacionCrud("LISTAR FACTURAS", entidadFacturacion);

                if (dsListaFactura.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("No hay ninguna factura creada en la base de datos", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tpFactura.Show();
                    return;
                }
                if (dsListaFactura.Tables.Count > 0)
                {
                    if (dsListaFactura.Tables[0].Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgFacturas, dsListaFactura.Tables[0]);
                        dbgFacturas.Splits[0].DisplayColumns["SW"].Visible = false;
                        this.dbgFacturas.Splits[0].DisplayColumns["Cliente"].Merge =
                            C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                        this.dbgFacturas.Splits[0].DisplayColumns["Empleado"].Merge =
                            C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;

                        return;
                    }
                }

                MessageBox.Show(dsListaFactura.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPtoComanda(int CantidadEliminar, int CantActual = 9999999)
        {
            try
            {
                string Producto = dbgComanda.Columns["Producto"].Text;
                if (CantidadEliminar >= CantActual)
                {
                    if (MessageBox.Show("Desea eliminar el Producto de la comanda",
                            "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dtComanda.Rows[Convert.ToInt32(dbgComanda.Row.GetHashCode())].Delete();
                        dtComanda.AcceptChanges();
                        foreach (DataRow row in dtProductos.Rows)
                        {
                            if (row["Producto"].ToString() == Producto)
                            {
                                //Aumenta las unidades disponibles del grid productos con la Cantidad Eliminada
                                if (row["Tipo Producto"].ToString() != "Servicio")
                                {
                                    int UnidadesDisponibles = Convert.ToInt32(row["Unid_Disp"].ToString());
                                    UnidadesDisponibles += CantidadEliminar;
                                    row["Unid_Disp"] = UnidadesDisponibles.ToString();
                                }
                                break;
                            }
                        }
                        dbgProductos.Refresh();
                    }
                    return;
                }

                if (CantActual != 9999999)
                {
                    dbgComanda.Columns["Cantidad"].Text =
                        (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) - CantidadEliminar).ToString();
                }

                //Recorre el dtProductos y me resta la cantidad descontada del producto actual en el grid comanda 
                //y me los suma al grid de productos
                foreach (DataRow row in dtProductos.Rows)
                {
                    if (row["Producto"].ToString() == Producto)
                    {
                        //Aumenta las unidades disponibles del grid productos con la Cantidad Eliminada
                        if (row["Tipo Producto"].ToString() != "Servicio")
                        {
                            int UnidadesDisponibles = Convert.ToInt32(row["Unid_Disp"].ToString());
                            UnidadesDisponibles += CantidadEliminar;
                            row["Unid_Disp"] = UnidadesDisponibles.ToString();
                        }
                        break;
                    }
                }
                dbgComanda.Columns["Valor Total"].Text =
                    (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) *
                     Convert.ToInt32(dbgComanda.Columns["Precio Unitario"].Text)).ToString();
                dbgProductos.Refresh();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridProductos()
        {
            try
            {
                dtProductos = objApi.ProductosCrud("LISTAR", entidadProductos);

                if (dtProductos.Rows.Count > 0)
                {
                    if (dtProductos.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGridOcultaResultado(dbgProductos, dtProductos);
                        dbgProductos.Splits[0].DisplayColumns["Id_Producto"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Costo"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Id_Proveedor"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Proveedor"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["CodBarras"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Tipo Producto"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Cant Minima"].Visible = false;
                        dbgProductos.Splits[0].DisplayColumns["Estado"].Visible = false;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearTablaComanda()
        {
            try
            {
                dtComanda = new DataTable();
                dtComanda.Columns.Add("Id_Producto", typeof(string));
                dtComanda.Columns.Add("Producto", typeof(string));
                dtComanda.Columns.Add("Tipo Producto", typeof(string));
                dtComanda.Columns.Add("Cantidad", typeof(string));
                dtComanda.Columns.Add("Precio Unitario", typeof(string));
                dtComanda.Columns.Add("Valor Total", typeof(string));
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ComandarProductos(string idPto, string Producto, string TipoPto, string Cantidad, string PrecUnit)
        {
            try
            {
                if (Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Value) <= 0)
                {
                    MessageBox.Show("No hay unidades disponibles para el producto.\n Actualice el stock del producto",
                        "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                bool RegistroCreado = false;

                if (dtComanda == null)
                {
                    CrearTablaComanda();
                }
                DataRow drComanda = dtComanda.NewRow();

                for (int i = 0; i < dtComanda.Rows.Count; i++)
                {
                    if (dtComanda.Rows[i]["Id_Producto"].ToString() == idPto)
                    {
                        Convert.ToInt32(dtComanda.Rows[i]["Cantidad"] = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]) + 1);
                        dtComanda.Rows[i]["Valor Total"] = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]) *
                                                     Convert.ToInt32(dtComanda.Rows[i]["Precio Unitario"]);
                        CalcularTotalFactura();

                        RegistroCreado = true;
                        break;
                    }
                }
                if (!RegistroCreado)
                {
                    drComanda["Id_Producto"] = idPto;
                    drComanda["Producto"] = Producto;
                    drComanda["Tipo Producto"] = TipoPto;
                    drComanda["Precio Unitario"] = PrecUnit;
                    drComanda["Cantidad"] = Cantidad;
                    drComanda["Valor Total"] = Convert.ToInt32(drComanda["Cantidad"]) * Convert.ToInt32(drComanda["Precio Unitario"]);

                    dtComanda.Rows.Add(drComanda);
                    CalcularTotalFactura();
                }

                dtComanda.AcceptChanges();
                objUtilidades.CargarGrid(dbgComanda, dtComanda);
                dbgComanda.Splits[0].DisplayColumns["Cantidad"].Locked = false;
                dbgComanda.Splits[0].DisplayColumns["Precio Unitario"].Locked = false;
                dbgComanda.Splits[0].DisplayColumns["Id_Producto"].Visible = false;
                dbgComanda.Splits[0].DisplayColumns["Tipo Producto"].Visible = false;

                //Descuenta de las unidades disponibles del grid productos la cantidad que comanden
                if (TipoPto != "Servicio")
                {
                    int CantidadProductos = Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Text);
                    CantidadProductos = CantidadProductos - 1;
                    dbgProductos.Columns["Unid_Disp"].Text = Convert.ToString(CantidadProductos);
                }

                txtTotalFactura.Text = TotalFactura.ToString("##,###");
                //txtTotalFactura.Text = TotalFactura.ToString();

                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //Comanda desde la columna del grid ya que esta editable y Dismunuye la cantidad dispobile en productos sin necesidad de llenar la grid de comanda
        private bool ComandarProductos(int CantComandar)
        {
            try
            {
                foreach (DataRow row in dtProductos.Rows)
                {
                    if (row["Producto"].ToString() == dbgComanda.Columns["Producto"].Text && row["Tipo Producto"].ToString() != "Servicio")
                    {
                        //Dismunuyen las unidades disponibles del grid productos con la Cantidad Agregada
                        int UnidadesDisponibles = Convert.ToInt32(row["Unid_Disp"].ToString());
                        UnidadesDisponibles = UnidadesDisponibles - CantComandar;
                        if (UnidadesDisponibles < 0)
                        {
                            MessageBox.Show("La cantidad a comandar supera" + "\n" + "el tope en inventario para este producto", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dbgComanda.Columns["Cantidad"].Text = Convert.ToString(Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) - CantComandar);
                            return false;
                        }

                        row["Unid_Disp"] = UnidadesDisponibles.ToString();
                        dbgProductos.Refresh();
                        break;
                    }
                }
                dbgComanda.Columns["Valor Total"].Text =
                   (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) *
                    Convert.ToInt32(dbgComanda.Columns["Precio Unitario"].Text)).ToString();
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidarDatosFact()
        {
            try
            {
                if (this.txtIdentificacion.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar un cliente", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIdentificacion.Select();
                    return false;
                }
                if (this.cmbEmpleado.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe Indicar el Empleado que realizó la venta o el servico", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbEmpleado.Select();
                    return false;
                }
                if (dbgComanda.RowCount <= 0)
                {
                    MessageBox.Show("Debe Ingresar mínimo un producto o servicio para generar la factura", "Sistema POS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LimpiarCampos()
        {
            try
            {
                txtNumeroFactura.Text = string.Empty;
                lblNumeroFactura.Visible = false;
                txtNumeroFactura.Visible = false;
                txtIdentificacion.Text = "999999";
                txtTotalFactura.Text = "0";
                txtNombre.Text = "GENERICO";
                TraerUsuarioLogueado();
                cmbEmpleado.Text = UsuarioLogueado;
                dtComanda = null;
                dbgComanda.DataSource = null;
                CargarGridProductos();
                cmbEmpleado.Focus();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarFactura()
        {
            try
            {
                if (ValidarDatosFact())
                {
                    objApi = new clsPosAPI();
                    clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();

                    entidadFacturacion.Identificacion_Cliente = this.txtIdentificacion.Text.Trim();
                    entidadFacturacion.Id_Barbero = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    entidadFacturacion.Usu_CreaFact = clsEntidadAutenticacion.Usuariologin;
                    //Validación para cuando no se inicia sesión desde el login
                    if (entidadFacturacion.Usu_CreaFact == null)
                    {
                        entidadFacturacion.Usu_CreaFact = Environment.UserName;
                    }
                    //Formato de fecha de como se guardará en la base de datos
                    entidadFacturacion.Fecha_Fact = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd/HH:mm", CultureInfo.CreateSpecificCulture("es-COL"));
                    entidadFacturacion.CreaEncabezado = true;
                    entidadFacturacion.CrearTruno = false;
                    bool existeServicio = false;
                    int numeroMensajes = 0;


                    for (int i = 0; i < dtComanda.Rows.Count; i++)
                    {
                        //Manda a crear el Turno si hay almenos un servicio comandado
                        if (dtComanda.Rows[i]["Tipo Producto"].ToString() == "Servicio")
                        {
                            existeServicio = true;
                        }

                        if (i == dtComanda.Rows.Count - 1 && existeServicio)
                        {
                            entidadFacturacion.CrearTruno = true;
                        }

                        if (txtNumeroFactura.Text != string.Empty)
                        {
                            entidadFacturacion.Numero_Factura = Convert.ToInt32(txtNumeroFactura.Text);
                        }

                        entidadFacturacion.Id_Producto = Convert.ToInt32(dtComanda.Rows[i]["Id_Producto"]);
                        entidadFacturacion.Cantidad = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]);
                        entidadFacturacion.Vlr_Unitario = Convert.ToInt32(dtComanda.Rows[i]["Precio Unitario"]);

                        dsGuardarFactura = objApi.FacturacionCrud("INSERTAR", entidadFacturacion);

                        if (dsGuardarFactura.Tables.Count > 0)
                        {
                            numeroMensajes = dsGuardarFactura.Tables[0].Rows.Count;

                            txtNumeroFactura.Text = dsGuardarFactura.Tables[0].Rows[numeroMensajes - 1]["Numero_Factura"].ToString();

                            for (int j = 0; j < numeroMensajes; j++)
                            {
                                if (dsGuardarFactura.Tables[0].Rows[j]["SW"].ToString() == "0")
                                {
                                    break;
                                }

                                MessageBox.Show(dsGuardarFactura.Tables[0].Rows[j]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            entidadFacturacion.CreaEncabezado = false;

                            lblNumeroFactura.Visible = true;
                            txtNumeroFactura.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("La base de datos no devolvió Información", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    if (MessageBox.Show(dsGuardarFactura.Tables[0].Rows[numeroMensajes - 1]["Mensaje"].ToString() + "\n" + "Desea Imprimirlo Ahora ?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        if (entidadFacturacion.CrearTruno)
                        {
                            if (Imprimir(Convert.ToInt32(this.txtNumeroFactura.Text)) && Imprimirturno)
                            {
                                pdTurno.Print();
                            }
                        }

                        LimpiarCampos();
                        txtIdentificacion.Focus();

                        return;
                    }

                    if (entidadFacturacion.CrearTruno)
                    {
                        if (Imprimir(Convert.ToInt32(this.txtNumeroFactura.Text)) && Imprimirturno)
                        {
                            pdTurno.Print();
                        }
                    }

                    if (Imprimir(Convert.ToInt32(this.txtNumeroFactura.Text)))
                    {
                        pdFactura.Print();
                    }

                    LimpiarCampos();
                    txtIdentificacion.Focus();
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboEmpleados()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                entidadFacturacion = new clsEntidadFacturacion();
                dsCombos = objApi.FacturacionCrud("LISTARBARBEROS", entidadFacturacion);

                if (dsCombos.Tables[0] != null)
                {
                    objUtilidades.LlenarComboUnicoValor(cmbEmpleado, dsCombos.Tables[0], "Nombre", "Id");
                    string[] strColumnaVisible = new string[] { "Nombre" };
                    objUtilidades.OcultarColumnasCombos(cmbEmpleado, dsCombos.Tables[0], strColumnaVisible);
                    cmbEmpleado.Enabled = true;
                    TraerUsuarioLogueado();
                    cmbEmpleado.Text = UsuarioLogueado;


                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotalFactura()
        {
            try
            {
                int TotalFact = 0;

                for (int i = 0; i < dtComanda.Rows.Count; i++)
                {
                    if (dtComanda.Rows.Count > 0)
                    {
                        TotalFact = TotalFact + Convert.ToInt32(dtComanda.Rows[i]["Valor Total"]);
                    }
                }
                //txtTotalFactura.Text = Convert.ToString(TotalFact);
                txtTotalFactura.Text = TotalFact.ToString("##,###");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraerUsuarioLogueado()
        {
            try
            {
                //Pone el usuario logueado por defecto en el combobox
                DataTable dtCargarMenu = new DataTable();

                dtCargarMenu = clsEntidadAutenticacion.dtCargarMenuPrincipal;

                if (dtCargarMenu == null || dtCargarMenu.Rows.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene permisos para ingresar esta aplicación.", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                UsuarioLogueado = (dtCargarMenu.Rows[0]["NombreUsuario"].ToString());
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hora_Factura(object sender, EventArgs e)
        {
            //obtener Hora Actual
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //Hora Completa
            string HoraActual = string.Empty;

            //Hora
            if (hh < 10)
            {
                HoraActual += "0" + hh;
            }
            else
            {
                HoraActual += hh;
            }
            HoraActual += ":";

            //Minuto
            if (mm < 10)
            {
                HoraActual += "0" + mm;
            }
            else
            {
                HoraActual += mm;
            }
            //HoraActual += ":";

            ////Segundo
            //if (ss < 10)
            //{
            //    HoraActual += "0" + ss;
            //}
            //else
            //{
            //    HoraActual += ss;
            //}

            txtHora.Text = HoraActual;
        }

        #endregion

        #region [Eventos]
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                ParametrosFacturacion();
                tpFactura.Show();
                //Formato de fecha para la presentación en el formulario campo Fecha Hora
                txtFechaFactura.Text = Convert.ToDateTime(DateTime.Now).ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("es-COL"));
                cmbEmpleado.Enabled = false;
                LimpiarCampos();

                #region [Timer Hora Factura]

                //Intervalo del Timer Hora en Milisegundos
                Hora.Interval = 1000;

                Hora.Tick += new EventHandler(this.Hora_Factura);

                //Iniciar
                Hora.Start();

                #endregion

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (Liquidacion)
            {
                Liquidar();
                return;
            }

            GuardarFactura();
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbgFacturas.SelectedRows.Count > 0)
                {
                    frmAutorizacion FormAutorizacion = new frmAutorizacion();

                    FormAutorizacion.Activate();
                    FormAutorizacion.ShowDialog();
                    if (FormAutorizacion.EntidadUsuario.Usuario != string.Empty && FormAutorizacion.EntidadUsuario.pwd != string.Empty)
                    {
                        AnularFactura(FormAutorizacion.EntidadUsuario.Usuario, FormAutorizacion.EntidadUsuario.pwd);
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber almenos un registro debe estar seleccionado (Resaltado en color gris)", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmListaClientes abrirFrmListaClientes = new frmListaClientes();
                abrirFrmListaClientes.Activate();
                abrirFrmListaClientes.ShowDialog();

                this.txtIdentificacion.Text = abrirFrmListaClientes.EntidadUsuario.IdUsuario;//Ver Documentación 1. al inicio
                this.txtNombre.Text = abrirFrmListaClientes.EntidadUsuario.nombre;
                cmbEmpleado.Focus();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbLiquidar_Click(object sender, EventArgs e)
        {
            Liquidar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            LlenarComboEmpleados();
        }

        private void dbgProductos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            try
            {
                int CantidadEliminada = 1;

                EliminarPtoComanda(CantidadEliminada, Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text));

                CalcularTotalFactura();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleado.Text == string.Empty || cmbEmpleado.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un Cliente y un Empleado", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                if (ComandarProductos(dbgProductos.Columns["Id_Producto"].Text, dbgProductos.Columns["Producto"].Text, dbgProductos.Columns["Tipo Producto"].Text, "1", dbgProductos.Columns["Precio"].Text))
                {
                    CalcularTotalFactura();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && txtNombre.Text != string.Empty)
                {
                    txtNombre.Text = string.Empty;
                    cmbEmpleado.Enabled = false;
                }

                if (e.KeyCode == Keys.Enter && txtIdentificacion.Text != string.Empty)
                {
                    txtNombre.Text = BuscarCliente();

                    if (txtNombre.Text == string.Empty)
                    {
                        if (MessageBox.Show("El Cliente No Existe" + "\n" + "Desea crearlo ahora?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (CrearCliente())
                            {
                                txtNombre.Text = BuscarCliente();
                                cmbEmpleado.Focus();
                                return;
                            }

                        }
                    }
                    cmbEmpleado.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CrearCliente()
        {
            try
            {
                frmUsuarios abrirFormUsuarios = new frmUsuarios();
                abrirFormUsuarios.FormularioEjecutorEsFacturacion = "Facturacion";
                abrirFormUsuarios.Identificacion = txtIdentificacion.Text;
                abrirFormUsuarios.ShowDialog();

                if (abrirFormUsuarios.GuardoUsuario)
                {
                    return true;
                }
                return false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dbgComanda_BeforeColUpdate(object sender, C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs e)
        {
            try
            {
                //If para verificar que no se ingresen letras en el campo cantidad del grid comanda

                if (e.Column.Name == "Cantidad" && !Information.IsNumeric(e.Column.DataColumn.Value.ToString().Trim()))
                {
                    dbgComanda.Columns["Cantidad"].Text = e.OldValue.ToString();
                    return;
                }

                if (e.Column.Name == "Precio Unitario" && !Information.IsNumeric(e.Column.DataColumn.Value.ToString().Trim()))
                {
                    dbgComanda.Columns["Precio Unitario"].Text = e.OldValue.ToString();
                    return;
                }

                //Aqui tambien debo eliminar producto de la comanda y agregar a producto el oldvalue
                if (e.Column.Name == "Cantidad" && (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) == 0))
                {
                    dbgComanda.Columns["Cantidad"].Text = e.OldValue.ToString();
                    return;
                }
                else if (e.Column.Name == "Cantidad" && Convert.ToInt32(e.OldValue) < Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text))
                {
                    ComandarProductos(Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) - Convert.ToInt32(e.OldValue));
                    CantComandaActualiza = dbgComanda.Columns["Cantidad"].Text;
                }
                else if (e.Column.Name == "Cantidad" && Convert.ToInt32(e.OldValue) > Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text))
                {
                    EliminarPtoComanda(Convert.ToInt32(e.OldValue) - Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text));
                }
                else if (e.Column.Name == "Precio Unitario")
                {
                    dbgComanda.Columns["Valor Total"].Text =
                   (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) *
                    Convert.ToInt32(dbgComanda.Columns["Precio Unitario"].Text)).ToString();
                }

                CalcularTotalFactura();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpFactura_Enter(object sender, EventArgs e)
        {
            //Establece por defecto el Cliente generico y simula un enter para que se ejecute el buscar automáticamente
            txtIdentificacion.Text = "999999";
            SendKeys.Send("{ENTER}");

            tsbGuardar.Visible = true;
            if (Liquidacion == false)
            {
                tsbLiquidar.Visible = true;
            }
            tsbAnular.Visible = false;
            tsbReimprimir.Visible = false;
            txtIdentificacion.Focus();
        }

        private void tpListaFacturas_Enter(object sender, EventArgs e)
        {
            tsbAnular.Visible = true;
            tsbGuardar.Visible = false;
            tsbLiquidar.Visible = false;
            tsbReimprimir.Visible = true;

            ListarFacturas();
        }

        private void dbgComanda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    EliminarPtoComanda(Convert.ToInt32(dtComanda.Rows[dbgComanda.Bookmark]["Cantidad"].ToString()), Convert.ToInt32(dtComanda.Rows[dbgComanda.Bookmark]["Cantidad"].ToString()));
                    CalcularTotalFactura();
                }

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

        private void dbgComanda_BeforeDelete(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
            CalcularTotalFactura();
        }

        private void tsbReimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbgFacturas.SelectedRows.Count > 0)
                {
                    Reimprimir = true;
                    Imprimir(Convert.ToInt32(dbgFacturas.Columns["Factura"].Text));
                    pdFactura.Print();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un recibo de caja para Reimprimirlo", "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdFactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DibujarFactura(e);
        }

        private void pdTurno_PrintPage(object sender, PrintPageEventArgs e)
        {
            DibujarTurno(e);
        }

        private void dbgComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!objUtilidades.PermitirSoloNumeros(e))
            {
                //Evita que se escriban letras en ese textbox
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void panelFacturacion_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
      
    }
}
