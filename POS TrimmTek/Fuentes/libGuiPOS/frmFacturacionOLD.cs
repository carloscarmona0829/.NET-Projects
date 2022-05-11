using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1List;
using Microsoft.VisualBasic;
using libEntidades;
using libInterfaz;
using libEntidades;
using libInterfaz;
using Microsoft.VisualBasic;


//1. abrirFrmListaClientes tiene una variable de tipo EntidadUsuario que se llenó en ese formulario y la estamos trayendo con su propiedad IdUsuario

namespace libGuiPOS
{
    public partial class frmFacturacion : Form
    {

        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        clsEntidadUsuario entidadUsuario = new clsEntidadUsuario();
        clsEntidadProductos entidadProductos = new clsEntidadProductos();
        clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();
        DataTable dtProductos = new DataTable();
        DataTable dtComanda = new DataTable();
        DataSet dsListaFactura = new DataSet();
        DataSet dsGuardarFactura = new DataSet();
        DataSet dsImprimirFactura = new DataSet();
        private int TotalMismoProducto = 0; //Vble para capturar lo que hay en la Col Total de la Comanda antes de ser borrado
        private int TotalFactura = 0;//Vble para capturar lo que hay en txtTotalFactura antes de ser borrado
        private bool Reimprimir = false;
        public frmFacturacion()
        {
            InitializeComponent();
        }

        #region [Metodos Privados]

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
                MessageBox.Show("El Cliente No Existe", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdentificacion.Text = string.Empty;
                return string.Empty;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ImprimirFactura(int NumeroFactura)
        {
            try
            {
                clsEntidadFacturacion entidadFacturacion = new clsEntidadFacturacion();

                entidadFacturacion.Numero_Factura = NumeroFactura;
                entidadFacturacion.Identificacion_Cliente = string.Empty;
                entidadFacturacion.Id_Barbero = 0;
                entidadFacturacion.Usu_CreaFact = Environment.UserName;
                entidadFacturacion.Fecha_Fact = string.Empty;
                entidadFacturacion.Id_Producto = 0;
                entidadFacturacion.Cantidad = 0;
                entidadFacturacion.Vlr_Unitario = 0;
                entidadFacturacion.CreaEncabezado = false;
                entidadFacturacion.Id_Factura = 0;
                entidadFacturacion.Id_Factura_Det = 0;

                dsImprimirFactura = objApi.FacturacionCrud("IMPRIMIR", entidadFacturacion);

                if (dsImprimirFactura.Tables[0].Rows[0]["SW"].ToString() == "0")
                {
                    pdFactura.Print();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                entidadFacturacion.Usu_ModFact = Environment.UserName;
                entidadFacturacion.Fecha_ModFact = Convert.ToDateTime(DateTime.Now)
                        .ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("es-COL"));

                dsAnular = objApi.FacturacionCrud("ANULAR", entidadFacturacion);
                if (dsAnular.Tables[0].Rows.Count > 0)
                {
                    if (dsAnular.Tables[0].Rows[0]["SW"].ToString() != "0")
                    {
                        MessageBox.Show(dsAnular.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    objUtilidades.CargarGrid(dbgFacturas, dsAnular.Tables[1]);
                    dbgFacturas.Splits[0].DisplayColumns["SW"].Visible = false;
                    MessageBox.Show(dsAnular.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                entidadFacturacion.CrearTruno = false;

                dsListaFactura = objApi.FacturacionCrud("LISTAR FACTURAS", entidadFacturacion);

                if (dsListaFactura.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("No hay ninguna factura creada en la base de datos", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tpFactura.Show();
                    return;
                }
                if (dsListaFactura.Tables[0].Rows[0]["SW"].ToString() == "0")
                {
                    string[] ColumnasFusion = new[] { "Barbero", "Cliente" };
                    objUtilidades.CargarGrid(dbgFacturas, dsListaFactura.Tables[0]);
                    dbgFacturas.Splits[0].DisplayColumns["SW"].Visible = false;
                    this.dbgFacturas.Splits[0].DisplayColumns["Cliente"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;
                    this.dbgFacturas.Splits[0].DisplayColumns["Barbero"].Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Restricted;

                    return;
                }

                MessageBox.Show(dsListaFactura.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPtoComanda()
        {
            try
            {
                //Asegura que se esta modificando el producto que en realidad se modificó en la comanda
                //dbgProductos.Bookmark = dbgComanda.Bookmark;

                int CantidadActual = Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text);
                int CantidadEliminada = Convert.ToInt32(Interaction.InputBox("Cantidad a Eliminar", "Sistema POS"));
                int CantidadTotal = CantidadActual - CantidadEliminada;

                if (!dtComanda.Columns["Cantidad"].Equals("1")) ;
                {
                    if (CantidadTotal > 0)
                    {
                        dtComanda.Rows[dbgComanda.Bookmark]["Cantidad"] = CantidadTotal;

                        int PrecioTot = Convert.ToInt32(dtComanda.Rows[dbgComanda.Bookmark]["Cantidad"]) * Convert.ToInt32(dtComanda.Rows[dbgComanda.Bookmark]["Precio Unitario"]);

                        int Saldo = Convert.ToInt32(dtComanda.Rows[dbgComanda.Bookmark]["Precio Unitario"]) *
                                    CantidadEliminada;
                        TotalFactura = TotalFactura - Saldo;
                        txtTotalFactura.Text = Convert.ToString(TotalFactura);

                        //Recorre el dtProductos y me suma la cantidad descontada de cada producto en el grid comanda y me los suma al grid de productos
                        foreach (DataRow row in dtProductos.Rows)
                        {
                            if (dbgProductos.Columns["Producto"].Text == dbgComanda.Columns["Producto"].Text)
                            {
                                //Aumenta las unidades disponibles del grid productos con la Cantidad Eliminada
                                int UnidadesDisponibles = Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Text);
                                UnidadesDisponibles = UnidadesDisponibles + CantidadEliminada;
                                dbgProductos.Columns["Unid_Disp"].Text = Convert.ToString(UnidadesDisponibles);
                                return;
                            }
                        }

                        dtComanda.Rows[dbgComanda.Bookmark]["Total"] = PrecioTot.ToString();
                        dtComanda.AcceptChanges();

                        return;
                    }
                }

                if (MessageBox.Show("Desea eliminar el registro", "Sistema POS", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbgProductos.Bookmark = dbgComanda.Bookmark;
                    //Recorre el dtProductos y me suma la cantidad descontada de cada producto en el grid comanda y me los suma al grid de productos
                    foreach (DataRow row in dtProductos.Rows)
                    {
                        if (dbgProductos.Columns["Producto"].Text == dbgComanda.Columns["Producto"].Text)
                        {
                            //Aumenta las unidades disponibles del grid productos con la Cantidad Eliminada
                            int UnidadesDisponibles = Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Text);
                            UnidadesDisponibles = UnidadesDisponibles + CantidadActual;
                            dbgProductos.Columns["Unid_Disp"].Text = Convert.ToString(UnidadesDisponibles);

                            dtComanda.Rows[dbgComanda.Bookmark].Delete();
                            dtComanda.AcceptChanges();

                            return;
                        }
                    }
                }
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

                if (dtProductos.Rows.Count != 0)
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

        private void CalcularTotalFactDMA(bool RegExistente)
        {
            try
            {
                if (RegExistente)
                {
                    TotalFactura = TotalFactura + Convert.ToInt32(dtComanda.Rows[dtComanda.Rows.Count - 1]["Precio Unitario"]);
                    return;
                }
                TotalFactura = TotalFactura + Convert.ToInt32(dtComanda.Rows[dtComanda.Rows.Count - 1]["Total"]);
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
                dtComanda.Columns.Add("Cantidad", typeof(string));
                dtComanda.Columns.Add("Precio Unitario", typeof(string));
                dtComanda.Columns.Add("Total", typeof(string));
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ComandarProductos()
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
                    if (dtComanda.Rows[i]["Id_Producto"].ToString() == dbgProductos.Columns["Id_Producto"].Text)
                    {
                        Convert.ToInt32(dtComanda.Rows[i]["Cantidad"] = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]) + 1);
                        dtComanda.Rows[i]["Total"] = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]) *
                                                     Convert.ToInt32(dtComanda.Rows[i]["Precio Unitario"]);

                        //CALCULAR TOTAL FACTURA DAVID
                        CalcularTotalFactDMA(true);

                        RegistroCreado = true;
                        break;
                    }
                }
                if (!RegistroCreado)
                {
                    drComanda["Id_Producto"] = dbgProductos.Columns["Id_Producto"].Text;
                    drComanda["Producto"] = dbgProductos.Columns["Producto"].Text;
                    drComanda["Precio Unitario"] = dbgProductos.Columns["Precio"].Text;
                    drComanda["Cantidad"] = 1;
                    drComanda["Total"] = Convert.ToInt32(drComanda["Cantidad"]) * Convert.ToInt32(drComanda["Precio Unitario"])/*)*/;

                    dtComanda.Rows.Add(drComanda);

                    //CALCULAR TOTAL FACTURA DAVID
                    CalcularTotalFactDMA(false);
                }

                dtComanda.AcceptChanges();
                objUtilidades.CargarGrid(dbgComanda, dtComanda);
                dbgComanda.Splits[0].DisplayColumns["Cantidad"].Locked = false;
                dbgComanda.Splits[0].DisplayColumns["Id_Producto"].Visible = false;

                //Descuenta de las unidades disponibles del grid productos la cantidad que comanden
                int CantidadProductos = Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Text);
                CantidadProductos = CantidadProductos - 1;
                dbgProductos.Columns["Unid_Disp"].Text = Convert.ToString(CantidadProductos);

                txtTotalFactura.Text = TotalFactura.ToString();

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
                if (this.cmbBarbero.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe Indicar el barbero que realizó la venta o el servico", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbBarbero.Select();
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
                txtIdentificacion.Text = string.Empty;
                txtTotalFactura.Text = "0";
                txtNombre.Text = string.Empty;
                cmbBarbero.Text = "Seleccionar";
                dtComanda = null;
                dbgComanda.DataSource = null;
                CargarGridProductos();
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
                    entidadFacturacion.Id_Barbero = Convert.ToInt32(cmbBarbero.SelectedValue);
                    entidadFacturacion.Usu_CreaFact = Environment.UserName;
                    entidadFacturacion.Fecha_Fact = txtFechaFactura.Text;
                    entidadFacturacion.CreaEncabezado = true;
                    entidadFacturacion.CrearTruno = true;

                    for (int i = 0; i < dtComanda.Rows.Count; i++)
                    {
                        if (txtNumeroFactura.Text != string.Empty)
                        {
                            entidadFacturacion.Numero_Factura = Convert.ToInt32(txtNumeroFactura.Text);
                        }

                        entidadFacturacion.Id_Producto = Convert.ToInt32(dtComanda.Rows[i]["Id_Producto"]);
                        entidadFacturacion.Cantidad = Convert.ToInt32(dtComanda.Rows[i]["Cantidad"]);
                        entidadFacturacion.Vlr_Unitario = Convert.ToInt32(dtComanda.Rows[i]["Precio Unitario"]);

                        dsGuardarFactura = objApi.FacturacionCrud("INSERTAR", entidadFacturacion);

                        // dsGuardarFactura.Tables.Count>2 indica un error, este DataSet solo debe devolver 2 tablas
                        if (dsGuardarFactura.Tables[0].Rows[0]["SW"].ToString() == "1" || dsGuardarFactura.Tables.Count > 2)
                        {
                            //Mensaje de error
                            MessageBox.Show(dsGuardarFactura.Tables[0].Rows[0]["Mensaje"].ToString(), "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        entidadFacturacion.CreaEncabezado = false;

                        lblNumeroFactura.Visible = true;
                        txtNumeroFactura.Visible = true;

                        txtNumeroFactura.Text = dsGuardarFactura.Tables[0].Rows[0]["Numero_Factura"].ToString();
                    }

                    DialogResult dialogResult = MessageBox.Show("El Recibo de Caja Número " + dsGuardarFactura.Tables[0].Rows[0]["Numero_Factura"].ToString() + "\n" + dsGuardarFactura.Tables[0].Rows[0]["Mensaje"].ToString() + "\n" + "Desea Imprimirlo Ahora ?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ImprimirFactura(Convert.ToInt32(this.txtNumeroFactura.Text));
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

        private void LlenarComboBarbero()
        {
            try
            {
                DataSet dsCombos = new DataSet();
                entidadFacturacion = new clsEntidadFacturacion();
                dsCombos = objApi.FacturacionCrud("LISTARBARBEROS", entidadFacturacion);

                if (dsCombos.Tables[0] != null)
                {
                    //cmbBarbero.ReadOnly = false;
                    objUtilidades.LlenarComboUnicoValor(cmbBarbero, dsCombos.Tables[0], "Nombre", "Id");
                    string[] strColumnaVisible = new string[] { "Nombre" };
                    objUtilidades.OcultarColumnasCombos(cmbBarbero, dsCombos.Tables[0], strColumnaVisible);
                    cmbBarbero.Enabled = true;
                    cmbBarbero.Text = "Seleccionar";
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
                int Totales = 0;
                int TotalFact = 0;

                for (int i = 0; i < dtComanda.Rows.Count; i++)
                {
                    if (dtComanda.Rows.Count > 0)
                    {
                        Totales = Convert.ToInt32(dtComanda.Rows[i]["Total"]);
                        TotalFact = TotalFact + Totales;
                        Totales = 0;
                    }
                }

                txtTotalFactura.Text = Convert.ToString(TotalFact);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [Eventos]
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                cmbBarbero.Enabled = false;
                tpFactura.Show();
                txtFechaFactura.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd/HH:mm", CultureInfo.CreateSpecificCulture("es-COL"));
                //txtFechaFactura.Text = Convert.ToDateTime(DateTime.Now).ToString("dd MMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("es-COL"));


                CargarGridProductos();
                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbgFacturas.SelectedRows.Count > 0)
                {
                    frmAutorizacion formulario = new frmAutorizacion();

                    formulario.ShowDialog();
                    if (formulario.EntidadUsuario.email != string.Empty && formulario.EntidadUsuario.pwd != string.Empty)
                    {
                        AnularFactura(formulario.EntidadUsuario.email, formulario.EntidadUsuario.pwd);
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber almenos un registro debe estar seleccionado (Marcado con el color gris)", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtIdentificacion.Text == string.Empty)
                {
                    frmListaClientes abrirFrmListaClientes = new frmListaClientes();

                    abrirFrmListaClientes.ShowDialog();

                    this.txtIdentificacion.Text = abrirFrmListaClientes.EntidadUsuario.IdUsuario;//Ver Documentación 1. al inicio
                    this.txtNombre.Text = abrirFrmListaClientes.EntidadUsuario.nombre;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            LlenarComboBarbero();
            if (txtNombre.Text.Trim() != string.Empty)
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }

        private void txtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.txtNombre.Text = string.Empty;
                if (txtIdentificacion.Text != string.Empty)
                {
                    this.txtNombre.Text = BuscarCliente();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dbgProductos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbBarbero.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar un Cliente", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                if (cmbBarbero.Text == string.Empty || cmbBarbero.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un Cliente y un Barbero", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                if (ComandarProductos())
                {
                    CalcularTotalFactura();
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBarbero.Text == string.Empty || cmbBarbero.Text == "Seleccionar")
                {
                    MessageBox.Show("Debe seleccionar un Cliente y un Barbero", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                if (ComandarProductos())
                {
                    CalcularTotalFactura();
                }
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
                if (dbgComanda.SelectedRows.Count > 0)
                {
                    EliminarPtoComanda();
                    CalcularTotalFactura();
                    return;
                }
                MessageBox.Show("Debe seleccionar al menos un registro en la Comanda", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Enter && txtIdentificacion.Text != string.Empty)
                {
                    this.txtNombre.Text = string.Empty;
                    if (txtIdentificacion.Text != string.Empty)
                    {
                        this.txtNombre.Text = BuscarCliente();
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (e.Column.Name == "Cantidad" && dbgComanda.Columns["Cantidad"].Text == string.Empty)
                {
                    if (MessageBox.Show("Desea eliminar el registro", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        dbgComanda.Columns["Cantidad"].Text = e.OldValue.ToString();
                    }
                    else
                    {
                        int regEliminar = dbgComanda.Bookmark;
                        dtComanda.Rows[regEliminar].Delete();
                        dtComanda.AcceptChanges();
                        CalcularTotalFactura();
                        objUtilidades.CargarGrid(dbgComanda, dtComanda);
                        dbgComanda.Splits[0].DisplayColumns["Cantidad"].Locked = false;
                        return;
                    }
                }
                else if (e.Column.Name == "Cantidad" && (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) == 0))
                {
                    if (MessageBox.Show("Desea eliminar el registro", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        dbgComanda.Columns["Cantidad"].Text = e.OldValue.ToString();
                    }
                    else
                    {
                        int regEliminar = dbgComanda.Bookmark;
                        dtComanda.Rows[regEliminar].Delete();
                        dtComanda.AcceptChanges();
                        objUtilidades.CargarGrid(dbgComanda, dtComanda);
                        dbgComanda.Splits[0].DisplayColumns["Cantidad"].Locked = false;

                        int OldValue = Convert.ToInt32(e.OldValue.ToString());
                        int UnidadesDisponibles = Convert.ToInt32(dbgProductos.Columns["Unid_Disp"].Text);
                        dbgProductos.Columns["Unid_Disp"].Text = Convert.ToString(OldValue + UnidadesDisponibles);

                        CalcularTotalFactura();

                        return;
                    }
                }

                Convert.ToInt32(dbgComanda.Columns["Total"].Text = (Convert.ToInt32(dbgComanda.Columns["Cantidad"].Text) * Convert.ToInt32(dbgComanda.Columns["Precio Unitario"].Text)).ToString());

                CalcularTotalFactura();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpListaFacturas_Enter(object sender, EventArgs e)
        {
            tsbAnular.Visible = true;
            tsbGuardar.Visible = false;
            tsbReimprimir.Visible = true;

            ListarFacturas();
        }

        private void dbgComanda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    dtComanda.Rows[dbgComanda.Row].Delete();
                    dtComanda.AcceptChanges();
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

        private void tpFactura_Enter(object sender, EventArgs e)
        {
            tsbGuardar.Visible = true;
            tsbAnular.Visible = false;
            tsbReimprimir.Visible = false;
            txtIdentificacion.Focus();
        }

        private void dbgComanda_BeforeDelete(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
            CalcularTotalFactura();
        }

        private void pdFactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataTable dtDatosFactura = new DataTable();

                dtDatosFactura = dsImprimirFactura.Tables[0];

                Font prFont = new Font("Arial", 10, FontStyle.Regular);
                Font prFontb = new Font("Arial", 10, FontStyle.Bold);
                Font prFonttitulo = new Font("Arial", 12, FontStyle.Bold);

                e.Graphics.DrawString("THE PEOPLE'S BARBER SHOP", prFonttitulo, Brushes.Black, 20, 10);
                e.Graphics.DrawString("NIT: " + dsImprimirFactura.Tables[0].Rows[0]["NIT"].ToString(), prFont, Brushes.Black, 84, 40);
                e.Graphics.DrawString("Calle 50 # 78 A - 79", prFont, Brushes.Black, 82, 60);
                e.Graphics.DrawString("Telefono: 234 43 23", prFont, Brushes.Black, 80, 80);
                e.Graphics.DrawString("Medellín - Colombia", prFont, Brushes.Black, 82, 100);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10, 115);
                e.Graphics.DrawString("RECIBO DE CAJA NUMERO: " + dsImprimirFactura.Tables[0].Rows[0]["Factura"].ToString(), prFontb, Brushes.Black, 10, 130);
                e.Graphics.DrawString("Fecha  Hora " + dsImprimirFactura.Tables[0].Rows[0]["Fecha"].ToString(), prFont, Brushes.Black, 10, 155);
                e.Graphics.DrawString("Barbero: " + dsImprimirFactura.Tables[0].Rows[0]["Barbero"].ToString(), prFont, Brushes.Black, 10, 180);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10, 195);
                e.Graphics.DrawString("DATOS DEL CLIENTE ", prFontb, Brushes.Black, 10, 210);
                e.Graphics.DrawString("Cliente: " + dsImprimirFactura.Tables[0].Rows[0]["Cliente"].ToString(), prFont, Brushes.Black, 10, 235);
                e.Graphics.DrawString("Nit/C.C: " + dsImprimirFactura.Tables[0].Rows[0]["Identificacion"].ToString(), prFont, Brushes.Black, 10, 260);
                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10, 275);
                e.Graphics.DrawString("ITEM    " + "DESCRIPCION    " + "  CANT    " + "VALOR", prFontb, Brushes.Black, 10, 290);

                int contAlto = 315;
                for (int i = 0; i < dtDatosFactura.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Id_Producto"].ToString(), prFont, Brushes.Black, 25, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Nom_Producto"].ToString(), prFont, Brushes.Black, 60, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Cantidad"].ToString(), prFont, Brushes.Black, 195, contAlto);
                    e.Graphics.DrawString(dtDatosFactura.Rows[i]["Total"].ToString(), prFont, Brushes.Black, 225, contAlto);
                    contAlto += 15;
                }

                e.Graphics.DrawString("----------------------------------------------------------", prFont, Brushes.Black, 10, contAlto);
                e.Graphics.DrawString("TOTAL", prFontb, Brushes.Black, 10, contAlto += 15);
                e.Graphics.DrawString(dtDatosFactura.Rows[0]["TotFact"].ToString(), prFontb, Brushes.Black, 225, contAlto);
                if (Reimprimir == true)
                {
                    e.Graphics.DrawString("******* COPIA *******", prFont, Brushes.Black, 75, contAlto += 25);
                }
                e.Graphics.DrawString(dsImprimirFactura.Tables[0].Rows[0]["Leyenda"].ToString(), prFont, Brushes.Black, 60, contAlto += 40);
                e.Graphics.DrawString("Gracias Por Preferirnos", prFont, Brushes.Black, 70, contAlto += 25);
                e.Graphics.DrawString("FELIZ NAVIDAD", prFontb, Brushes.Black, 90, contAlto += 25);

                e.HasMorePages = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbReimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbgFacturas.SelectedRows.Count > 0)
                {
                    Reimprimir = true;
                    ImprimirFactura(Convert.ToInt32(dbgFacturas.Columns["Factura"].Text));
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

        #endregion
        
    }
}
