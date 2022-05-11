namespace libGuiPOS
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1Productos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dktProductos = new C1.Win.C1Command.C1DockingTab();
            this.tpProducto = new C1.Win.C1Command.C1DockingTabPage();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new C1.Win.C1List.C1Combo();
            this.cmbProveedor = new C1.Win.C1List.C1Combo();
            this.txtPvp = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpListaProductos = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgProductos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.toolStrip1.SuspendLayout();
            this.panel1Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktProductos)).BeginInit();
            this.dktProductos.SuspendLayout();
            this.tpProducto.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).BeginInit();
            this.tpListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbActualizar,
            this.tsbEliminar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 15;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::libGuiPOS.Properties.Resources.green_document_plus_icon48;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(80, 38);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbGuardar.Image = global::libGuiPOS.Properties.Resources.green_disk_icon48;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(87, 38);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.Image = global::libGuiPOS.Properties.Resources.green_notes_icon48;
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(97, 38);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.Click += new System.EventHandler(this.tsbActualizar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::libGuiPOS.Properties.Resources.green_cross_icon48;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(88, 38);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.Image = global::libGuiPOS.Properties.Resources.red_home_icon48;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(67, 38);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // panel1Productos
            // 
            this.panel1Productos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1Productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1Productos.Controls.Add(this.label1);
            this.panel1Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1Productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1Productos.Location = new System.Drawing.Point(0, 0);
            this.panel1Productos.Name = "panel1Productos";
            this.panel1Productos.Size = new System.Drawing.Size(850, 50);
            this.panel1Productos.TabIndex = 14;
            this.panel1Productos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1Productos_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // dktProductos
            // 
            this.dktProductos.Controls.Add(this.tpProducto);
            this.dktProductos.Controls.Add(this.tpListaProductos);
            this.dktProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktProductos.Location = new System.Drawing.Point(0, 91);
            this.dktProductos.Name = "dktProductos";
            this.dktProductos.SelectedIndex = 1;
            this.dktProductos.Size = new System.Drawing.Size(850, 459);
            this.dktProductos.TabIndex = 16;
            this.dktProductos.TabsSpacing = 0;
            this.dktProductos.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpProducto
            // 
            this.tpProducto.Controls.Add(this.gbProductos);
            this.tpProducto.Location = new System.Drawing.Point(1, 24);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Size = new System.Drawing.Size(848, 434);
            this.tpProducto.TabIndex = 2;
            this.tpProducto.Text = "Productos";
            this.tpProducto.Enter += new System.EventHandler(this.tpProducto_Enter);
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.txtCodigoProducto);
            this.gbProductos.Controls.Add(this.lblCodigoProducto);
            this.gbProductos.Controls.Add(this.txtCantidadStock);
            this.gbProductos.Controls.Add(this.txtCantidadMinima);
            this.gbProductos.Controls.Add(this.label13);
            this.gbProductos.Controls.Add(this.label12);
            this.gbProductos.Controls.Add(this.cmbTipoProducto);
            this.gbProductos.Controls.Add(this.cmbProveedor);
            this.gbProductos.Controls.Add(this.txtPvp);
            this.gbProductos.Controls.Add(this.txtCosto);
            this.gbProductos.Controls.Add(this.txtNombre);
            this.gbProductos.Controls.Add(this.label6);
            this.gbProductos.Controls.Add(this.label5);
            this.gbProductos.Controls.Add(this.label3);
            this.gbProductos.Controls.Add(this.txtCodigoBarras);
            this.gbProductos.Controls.Add(this.label8);
            this.gbProductos.Controls.Add(this.label9);
            this.gbProductos.Controls.Add(this.label11);
            this.gbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(0, 0);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(848, 434);
            this.gbProductos.TabIndex = 11;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Información Del Producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(198, 46);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(206, 26);
            this.txtCodigoProducto.TabIndex = 38;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(28, 46);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(152, 20);
            this.lblCodigoProducto.TabIndex = 39;
            this.lblCodigoProducto.Text = "Código del Producto";
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadStock.Location = new System.Drawing.Point(594, 331);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(226, 26);
            this.txtCantidadStock.TabIndex = 7;
            this.txtCantidadStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadStock_KeyPress);
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMinima.Location = new System.Drawing.Point(594, 260);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(226, 26);
            this.txtCantidadMinima.TabIndex = 6;
            this.txtCantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadMinima_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(433, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Cantidad En Stock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cantidad Mínima";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AddItemSeparator = ';';
            this.cmbTipoProducto.AutoCompletion = true;
            this.cmbTipoProducto.AutoDropDown = true;
            this.cmbTipoProducto.AutoSelect = true;
            this.cmbTipoProducto.Caption = "";
            this.cmbTipoProducto.CaptionHeight = 17;
            this.cmbTipoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipoProducto.ColumnCaptionHeight = 17;
            this.cmbTipoProducto.ColumnFooterHeight = 17;
            this.cmbTipoProducto.ContentHeight = 21;
            this.cmbTipoProducto.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbTipoProducto.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbTipoProducto.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProducto.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTipoProducto.EditorHeight = 21;
            this.cmbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbTipoProducto.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbTipoProducto.Images"))));
            this.cmbTipoProducto.ItemHeight = 15;
            this.cmbTipoProducto.LimitToList = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(594, 188);
            this.cmbTipoProducto.MatchEntryTimeout = ((long)(2000));
            this.cmbTipoProducto.MaxDropDownItems = ((short)(5));
            this.cmbTipoProducto.MaxLength = 32767;
            this.cmbTipoProducto.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbTipoProducto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbTipoProducto.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbTipoProducto.Size = new System.Drawing.Size(226, 27);
            this.cmbTipoProducto.TabIndex = 5;
            this.cmbTipoProducto.Text = "c1Combo1";
            this.cmbTipoProducto.TextChanged += new System.EventHandler(this.cmbTipoProducto_TextChanged);
            this.cmbTipoProducto.PropBag = resources.GetString("cmbTipoProducto.PropBag");
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AddItemSeparator = ';';
            this.cmbProveedor.Caption = "";
            this.cmbProveedor.CaptionHeight = 17;
            this.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbProveedor.ColumnCaptionHeight = 17;
            this.cmbProveedor.ColumnFooterHeight = 17;
            this.cmbProveedor.ContentHeight = 21;
            this.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbProveedor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbProveedor.EditorHeight = 21;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbProveedor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbProveedor.Images"))));
            this.cmbProveedor.ItemHeight = 15;
            this.cmbProveedor.Location = new System.Drawing.Point(594, 116);
            this.cmbProveedor.MatchEntryTimeout = ((long)(2000));
            this.cmbProveedor.MaxDropDownItems = ((short)(5));
            this.cmbProveedor.MaxLength = 32767;
            this.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbProveedor.Size = new System.Drawing.Size(226, 27);
            this.cmbProveedor.TabIndex = 4;
            this.cmbProveedor.Text = "c1Combo1";
            this.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag");
            // 
            // txtPvp
            // 
            this.txtPvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPvp.Location = new System.Drawing.Point(198, 327);
            this.txtPvp.Name = "txtPvp";
            this.txtPvp.Size = new System.Drawing.Size(206, 26);
            this.txtPvp.TabIndex = 3;
            this.txtPvp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPvp_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(198, 256);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(206, 26);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(198, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo De Elemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio De Venta";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(198, 184);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(206, 26);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Código De Barras";
            // 
            // tpListaProductos
            // 
            this.tpListaProductos.Controls.Add(this.dbgProductos);
            this.tpListaProductos.Location = new System.Drawing.Point(1, 24);
            this.tpListaProductos.Name = "tpListaProductos";
            this.tpListaProductos.Size = new System.Drawing.Size(848, 434);
            this.tpListaProductos.TabIndex = 1;
            this.tpListaProductos.Text = "Lista Productos";
            this.tpListaProductos.Enter += new System.EventHandler(this.tpListaProductos_Enter);
            // 
            // dbgProductos
            // 
            this.dbgProductos.AllowUpdate = false;
            this.dbgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgProductos.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgProductos.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgProductos.Images"))));
            this.dbgProductos.Location = new System.Drawing.Point(0, 0);
            this.dbgProductos.Name = "dbgProductos";
            this.dbgProductos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgProductos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgProductos.PreviewInfo.ZoomFactor = 75D;
            this.dbgProductos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgProductos.PrintInfo.PageSettings")));
            this.dbgProductos.Size = new System.Drawing.Size(848, 434);
            this.dbgProductos.TabIndex = 1;
            this.dbgProductos.Text = "c1TrueDBGrid1";
            this.dbgProductos.DoubleClick += new System.EventHandler(this.dbgProductos_DoubleClick);
            this.dbgProductos.PropBag = resources.GetString("dbgProductos.PropBag");
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktProductos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1Productos.ResumeLayout(false);
            this.panel1Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktProductos)).EndInit();
            this.dktProductos.ResumeLayout(false);
            this.tpProducto.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).EndInit();
            this.tpListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Panel panel1Productos;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Command.C1DockingTab dktProductos;
        private C1.Win.C1Command.C1DockingTabPage tpProducto;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.TextBox txtPvp;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private C1.Win.C1Command.C1DockingTabPage tpListaProductos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgProductos;
        private C1.Win.C1List.C1Combo cmbTipoProducto;
        private C1.Win.C1List.C1Combo cmbProveedor;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtCantidadMinima;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
    }
}