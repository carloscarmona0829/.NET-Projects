namespace libGuiPOS
{
    partial class frmNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGenerarNomina = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.panelNomina = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCalcularVentas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dbgNomina = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.toolStrip1.SuspendLayout();
            this.panelNomina.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGenerarNomina,
            this.tsbActualizar,
            this.tsbEliminar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 15;
            // 
            // tsbGenerarNomina
            // 
            this.tsbGenerarNomina.BackColor = System.Drawing.SystemColors.Control;
            this.tsbGenerarNomina.Image = global::libGuiPOS.Properties.Resources.green_case_icon48;
            this.tsbGenerarNomina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerarNomina.Name = "tsbGenerarNomina";
            this.tsbGenerarNomina.Size = new System.Drawing.Size(132, 38);
            this.tsbGenerarNomina.Text = "Generar Nómina";
            this.tsbGenerarNomina.Click += new System.EventHandler(this.tsbGenerarNomina_Click);
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.Image = global::libGuiPOS.Properties.Resources.green_notes_icon48;
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(97, 38);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.Visible = false;
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::libGuiPOS.Properties.Resources.green_cross_icon48;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(88, 38);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Visible = false;
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
            // panelNomina
            // 
            this.panelNomina.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelNomina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNomina.Controls.Add(this.label1);
            this.panelNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNomina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNomina.Location = new System.Drawing.Point(0, 0);
            this.panelNomina.Name = "panelNomina";
            this.panelNomina.Size = new System.Drawing.Size(850, 50);
            this.panelNomina.TabIndex = 14;
            this.panelNomina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNomina_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(277, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE NÓMINA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCalcularVentas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbEmpleado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 117);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Nómina";
            // 
            // chkCalcularVentas
            // 
            this.chkCalcularVentas.Checked = true;
            this.chkCalcularVentas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCalcularVentas.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCalcularVentas.Location = new System.Drawing.Point(600, 42);
            this.chkCalcularVentas.Name = "chkCalcularVentas";
            this.chkCalcularVentas.Size = new System.Drawing.Size(15, 15);
            this.chkCalcularVentas.TabIndex = 41;
            this.chkCalcularVentas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Calcular Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Hasta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.AddItemSeparator = ';';
            this.cmbEmpleado.Caption = "";
            this.cmbEmpleado.CaptionHeight = 17;
            this.cmbEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbEmpleado.ColumnCaptionHeight = 17;
            this.cmbEmpleado.ColumnFooterHeight = 17;
            this.cmbEmpleado.ContentHeight = 22;
            this.cmbEmpleado.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbEmpleado.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbEmpleado.EditorFont = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEmpleado.EditorHeight = 22;
            this.cmbEmpleado.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbEmpleado.Images"))));
            this.cmbEmpleado.ItemHeight = 15;
            this.cmbEmpleado.Location = new System.Drawing.Point(127, 35);
            this.cmbEmpleado.MatchEntryTimeout = ((long)(2000));
            this.cmbEmpleado.MaxDropDownItems = ((short)(5));
            this.cmbEmpleado.MaxLength = 32767;
            this.cmbEmpleado.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbEmpleado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbEmpleado.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbEmpleado.Size = new System.Drawing.Size(264, 28);
            this.cmbEmpleado.TabIndex = 37;
            this.cmbEmpleado.Text = "Todos";
            this.cmbEmpleado.PropBag = resources.GetString("cmbEmpleado.PropBag");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Empleado";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Checked = false;
            this.dtpHasta.CustomFormat = "MMMM dd, yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(518, 77);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(231, 27);
            this.dtpHasta.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Checked = false;
            this.dtpDesde.CustomFormat = "MMMM dd, yyyy";
            this.dtpDesde.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(102, 77);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(231, 27);
            this.dtpDesde.TabIndex = 5;
            // 
            // dbgNomina
            // 
            this.dbgNomina.AllowUpdate = false;
            this.dbgNomina.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgNomina.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgNomina.Images"))));
            this.dbgNomina.Location = new System.Drawing.Point(0, 226);
            this.dbgNomina.Name = "dbgNomina";
            this.dbgNomina.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgNomina.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgNomina.PreviewInfo.ZoomFactor = 75D;
            this.dbgNomina.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgNomina.PrintInfo.PageSettings")));
            this.dbgNomina.Size = new System.Drawing.Size(850, 319);
            this.dbgNomina.TabIndex = 17;
            this.dbgNomina.Text = "c1TrueDBGrid1";
            this.dbgNomina.PropBag = resources.GetString("dbgNomina.PropBag");
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dbgNomina);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNomina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelNomina.ResumeLayout(false);
            this.panelNomina.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGenerarNomina;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel panelNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgNomina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        public C1.Win.C1List.C1Combo cmbEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCalcularVentas;
        private System.Windows.Forms.Label label4;
    }
}