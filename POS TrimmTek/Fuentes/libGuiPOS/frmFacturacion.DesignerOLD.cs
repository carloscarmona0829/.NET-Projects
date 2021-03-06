namespace libGuiPOS
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbReimprimir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dktFacturacion = new C1.Win.C1Command.C1DockingTab();
            this.tpFactura = new C1.Win.C1Command.C1DockingTabPage();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.dbgProductos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grbComanda = new System.Windows.Forms.GroupBox();
            this.dbgComanda = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.cmbBarbero = new C1.Win.C1List.C1Combo();
            this.txtFechaFactura = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.tpListaFacturas = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgFacturas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.pdFactura = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktFacturacion)).BeginInit();
            this.dktFacturacion.SuspendLayout();
            this.tpFactura.SuspendLayout();
            this.grbAcciones.SuspendLayout();
            this.grbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgProductos)).BeginInit();
            this.grbComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgComanda)).BeginInit();
            this.gbEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBarbero)).BeginInit();
            this.tpListaFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbSalir,
            this.tsbAnular,
            this.tsbReimprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 41);
            this.toolStrip1.TabIndex = 17;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbGuardar.Image = global::libGuiPOS.Properties.Resources.Guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(87, 38);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.Image = global::libGuiPOS.Properties.Resources.Inicio;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(67, 38);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Image = global::libGuiPOS.Properties.Resources.Eliminar;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(80, 38);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tsbReimprimir
            // 
            this.tsbReimprimir.Image = global::libGuiPOS.Properties.Resources.printers_and_faxes_icon;
            this.tsbReimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReimprimir.Name = "tsbReimprimir";
            this.tsbReimprimir.Size = new System.Drawing.Size(104, 38);
            this.tsbReimprimir.Text = "Reimprimir";
            this.tsbReimprimir.Click += new System.EventHandler(this.tsbReimprimir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 50);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(413, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE RECIBOS DE CAJA";
            // 
            // dktFacturacion
            // 
            this.dktFacturacion.Controls.Add(this.tpFactura);
            this.dktFacturacion.Controls.Add(this.tpListaFacturas);
            this.dktFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktFacturacion.Location = new System.Drawing.Point(0, 91);
            this.dktFacturacion.Name = "dktFacturacion";
            this.dktFacturacion.SelectedIndex = 1;
            this.dktFacturacion.Size = new System.Drawing.Size(1200, 609);
            this.dktFacturacion.TabIndex = 20;
            this.dktFacturacion.TabsSpacing = 0;
            this.dktFacturacion.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpFactura
            // 
            this.tpFactura.Controls.Add(this.txtTotalFactura);
            this.tpFactura.Controls.Add(this.label5);
            this.tpFactura.Controls.Add(this.grbAcciones);
            this.tpFactura.Controls.Add(this.grbProductos);
            this.tpFactura.Controls.Add(this.grbComanda);
            this.tpFactura.Controls.Add(this.gbEncabezado);
            this.tpFactura.Controls.Add(this.txtNumeroFactura);
            this.tpFactura.Controls.Add(this.lblNumeroFactura);
            this.tpFactura.Location = new System.Drawing.Point(1, 24);
            this.tpFactura.Name = "tpFactura";
            this.tpFactura.Size = new System.Drawing.Size(1198, 584);
            this.tpFactura.TabIndex = 2;
            this.tpFactura.Text = "Factura";
            this.tpFactura.Enter += new System.EventHandler(this.tpFactura_Enter);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFactura.Location = new System.Drawing.Point(362, 520);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(169, 26);
            this.txtTotalFactura.TabIndex = 50;
            this.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total";
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.btnProductos);
            this.grbAcciones.Controls.Add(this.btnComanda);
            this.grbAcciones.Location = new System.Drawing.Point(618, 237);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Size = new System.Drawing.Size(64, 266);
            this.grbAcciones.TabIndex = 49;
            this.grbAcciones.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(10, 155);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(45, 45);
            this.btnProductos.TabIndex = 36;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.Image = ((System.Drawing.Image)(resources.GetObject("btnComanda.Image")));
            this.btnComanda.Location = new System.Drawing.Point(10, 68);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(45, 45);
            this.btnComanda.TabIndex = 35;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // grbProductos
            // 
            this.grbProductos.Controls.Add(this.dbgProductos);
            this.grbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProductos.Location = new System.Drawing.Point(689, 237);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Size = new System.Drawing.Size(497, 303);
            this.grbProductos.TabIndex = 48;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Productos";
            // 
            // dbgProductos
            // 
            this.dbgProductos.AllowUpdate = false;
            this.dbgProductos.CaptionHeight = 17;
            this.dbgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgProductos.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgProductos.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgProductos.Images"))));
            this.dbgProductos.Location = new System.Drawing.Point(3, 22);
            this.dbgProductos.Name = "dbgProductos";
            this.dbgProductos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgProductos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgProductos.PreviewInfo.ZoomFactor = 75D;
            this.dbgProductos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgProductos.PrintInfo.PageSettings")));
            this.dbgProductos.RowHeight = 15;
            this.dbgProductos.Size = new System.Drawing.Size(491, 278);
            this.dbgProductos.TabIndex = 2;
            this.dbgProductos.Text = "c1TrueDBGrid1";
            this.dbgProductos.DoubleClick += new System.EventHandler(this.dbgProductos_DoubleClick);
            this.dbgProductos.PropBag = resources.GetString("dbgProductos.PropBag");
            // 
            // grbComanda
            // 
            this.grbComanda.Controls.Add(this.dbgComanda);
            this.grbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbComanda.Location = new System.Drawing.Point(11, 40);
            this.grbComanda.Name = "grbComanda";
            this.grbComanda.Size = new System.Drawing.Size(600, 463);
            this.grbComanda.TabIndex = 47;
            this.grbComanda.TabStop = false;
            this.grbComanda.Text = "Comanda";
            // 
            // dbgComanda
            // 
            this.dbgComanda.CaptionHeight = 17;
            this.dbgComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgComanda.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgComanda.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgComanda.Images"))));
            this.dbgComanda.Location = new System.Drawing.Point(3, 22);
            this.dbgComanda.Name = "dbgComanda";
            this.dbgComanda.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgComanda.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgComanda.PreviewInfo.ZoomFactor = 75D;
            this.dbgComanda.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgComanda.PrintInfo.PageSettings")));
            this.dbgComanda.RowHeight = 15;
            this.dbgComanda.Size = new System.Drawing.Size(594, 438);
            this.dbgComanda.TabIndex = 2;
            this.dbgComanda.Text = "c1TrueDBGrid1";
            this.dbgComanda.BeforeColUpdate += new C1.Win.C1TrueDBGrid.BeforeColUpdateEventHandler(this.dbgComanda_BeforeColUpdate);
            this.dbgComanda.BeforeDelete += new C1.Win.C1TrueDBGrid.CancelEventHandler(this.dbgComanda_BeforeDelete);
            this.dbgComanda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgComanda_KeyDown);
            this.dbgComanda.PropBag = resources.GetString("dbgComanda.PropBag");
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.Controls.Add(this.cmbBarbero);
            this.gbEncabezado.Controls.Add(this.txtFechaFactura);
            this.gbEncabezado.Controls.Add(this.txtNombre);
            this.gbEncabezado.Controls.Add(this.btnBuscar);
            this.gbEncabezado.Controls.Add(this.label2);
            this.gbEncabezado.Controls.Add(this.txtIdentificacion);
            this.gbEncabezado.Controls.Add(this.label3);
            this.gbEncabezado.Controls.Add(this.label4);
            this.gbEncabezado.Location = new System.Drawing.Point(617, 82);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(569, 127);
            this.gbEncabezado.TabIndex = 46;
            this.gbEncabezado.TabStop = false;
            // 
            // cmbBarbero
            // 
            this.cmbBarbero.AddItemSeparator = ';';
            this.cmbBarbero.Caption = "";
            this.cmbBarbero.CaptionHeight = 17;
            this.cmbBarbero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbBarbero.ColumnCaptionHeight = 17;
            this.cmbBarbero.ColumnFooterHeight = 17;
            this.cmbBarbero.ContentHeight = 21;
            this.cmbBarbero.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbBarbero.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbBarbero.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarbero.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBarbero.EditorHeight = 21;
            this.cmbBarbero.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbBarbero.Images"))));
            this.cmbBarbero.ItemHeight = 15;
            this.cmbBarbero.Location = new System.Drawing.Point(95, 81);
            this.cmbBarbero.MatchEntryTimeout = ((long)(2000));
            this.cmbBarbero.MaxDropDownItems = ((short)(5));
            this.cmbBarbero.MaxLength = 32767;
            this.cmbBarbero.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbBarbero.Name = "cmbBarbero";
            this.cmbBarbero.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbBarbero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbBarbero.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbBarbero.Size = new System.Drawing.Size(281, 27);
            this.cmbBarbero.TabIndex = 35;
            this.cmbBarbero.PropBag = resources.GetString("cmbBarbero.PropBag");
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.Enabled = false;
            this.txtFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFactura.Location = new System.Drawing.Point(390, 95);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.ReadOnly = true;
            this.txtFechaFactura.Size = new System.Drawing.Size(169, 26);
            this.txtFechaFactura.TabIndex = 34;
            this.txtFechaFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(227, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(271, 26);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(511, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 45);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Barbero";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(95, 31);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(115, 26);
            this.txtIdentificacion.TabIndex = 0;
            this.txtIdentificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentificacion_KeyDown);
            this.txtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdentificacion_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha  Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cliente";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(1003, 40);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(169, 20);
            this.txtNumeroFactura.TabIndex = 44;
            this.txtNumeroFactura.Visible = false;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(809, 38);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(194, 24);
            this.lblNumeroFactura.TabIndex = 45;
            this.lblNumeroFactura.Text = "Recibo De Caja No.";
            this.lblNumeroFactura.Visible = false;
            // 
            // tpListaFacturas
            // 
            this.tpListaFacturas.Controls.Add(this.dbgFacturas);
            this.tpListaFacturas.Location = new System.Drawing.Point(1, 24);
            this.tpListaFacturas.Name = "tpListaFacturas";
            this.tpListaFacturas.Size = new System.Drawing.Size(1198, 584);
            this.tpListaFacturas.TabIndex = 1;
            this.tpListaFacturas.Text = "Lista de Recibos de Caja";
            this.tpListaFacturas.Enter += new System.EventHandler(this.tpListaFacturas_Enter);
            // 
            // dbgFacturas
            // 
            this.dbgFacturas.AllowDelete = true;
            this.dbgFacturas.AllowUpdate = false;
            this.dbgFacturas.CaptionHeight = 17;
            this.dbgFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgFacturas.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgFacturas.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgFacturas.Images"))));
            this.dbgFacturas.Location = new System.Drawing.Point(0, 0);
            this.dbgFacturas.Name = "dbgFacturas";
            this.dbgFacturas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgFacturas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgFacturas.PreviewInfo.ZoomFactor = 75D;
            this.dbgFacturas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgFacturas.PrintInfo.PageSettings")));
            this.dbgFacturas.RowHeight = 15;
            this.dbgFacturas.Size = new System.Drawing.Size(1198, 584);
            this.dbgFacturas.TabIndex = 0;
            this.dbgFacturas.Text = "c1TrueDBGrid1";
            this.dbgFacturas.PropBag = resources.GetString("dbgFacturas.PropBag");
            // 
            // pdFactura
            // 
            this.pdFactura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdFactura_PrintPage);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dktFacturacion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktFacturacion)).EndInit();
            this.dktFacturacion.ResumeLayout(false);
            this.tpFactura.ResumeLayout(false);
            this.tpFactura.PerformLayout();
            this.grbAcciones.ResumeLayout(false);
            this.grbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgProductos)).EndInit();
            this.grbComanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgComanda)).EndInit();
            this.gbEncabezado.ResumeLayout(false);
            this.gbEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBarbero)).EndInit();
            this.tpListaFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Command.C1DockingTab dktFacturacion;
        private C1.Win.C1Command.C1DockingTabPage tpFactura;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.GroupBox grbProductos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgProductos;
        private System.Windows.Forms.GroupBox grbComanda;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgComanda;
        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.TextBox txtFechaFactura;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private C1.Win.C1Command.C1DockingTabPage tpListaFacturas;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgFacturas;
        private C1.Win.C1List.C1Combo cmbBarbero;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument pdFactura;
        private System.Windows.Forms.ToolStripButton tsbReimprimir;
    }
}