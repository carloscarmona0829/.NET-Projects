namespace libGuiPOS
{
    partial class frmCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierre));
            this.panelCierre = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCierreParcial = new System.Windows.Forms.ToolStripButton();
            this.tsbAjustar = new System.Windows.Forms.ToolStripButton();
            this.dktUsuarios = new C1.Win.C1Command.C1DockingTab();
            this.tpCierre = new C1.Win.C1Command.C1DockingTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalVendido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalEfectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tpListaCierres = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgCierres = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelCierre.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktUsuarios)).BeginInit();
            this.dktUsuarios.SuspendLayout();
            this.tpCierre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpListaCierres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgCierres)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCierre
            // 
            this.panelCierre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelCierre.Controls.Add(this.label4);
            this.panelCierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCierre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCierre.Location = new System.Drawing.Point(0, 0);
            this.panelCierre.Name = "panelCierre";
            this.panelCierre.Size = new System.Drawing.Size(850, 53);
            this.panelCierre.TabIndex = 36;
            this.panelCierre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCierre_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(355, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "CIERRE DIARIO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbSalir,
            this.tsbCierreParcial,
            this.tsbAjustar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 53);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 41;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbGuardar.Image = global::libGuiPOS.Properties.Resources.green_lock_icon72;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(97, 38);
            this.tsbGuardar.Text = "Cerrar Día";
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
            // tsbCierreParcial
            // 
            this.tsbCierreParcial.Image = global::libGuiPOS.Properties.Resources.CierreOpen;
            this.tsbCierreParcial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCierreParcial.Name = "tsbCierreParcial";
            this.tsbCierreParcial.Size = new System.Drawing.Size(114, 38);
            this.tsbCierreParcial.Text = "Cierre Parcial";
            this.tsbCierreParcial.Click += new System.EventHandler(this.tsbCierreParcial_Click);
            // 
            // tsbAjustar
            // 
            this.tsbAjustar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbAjustar.Image = global::libGuiPOS.Properties.Resources.green_chart_icon48;
            this.tsbAjustar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAjustar.Name = "tsbAjustar";
            this.tsbAjustar.Size = new System.Drawing.Size(82, 38);
            this.tsbAjustar.Text = "Ajustar";
            this.tsbAjustar.Click += new System.EventHandler(this.tsbAjustar_Click);
            // 
            // dktUsuarios
            // 
            this.dktUsuarios.Controls.Add(this.tpCierre);
            this.dktUsuarios.Controls.Add(this.tpListaCierres);
            this.dktUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktUsuarios.Location = new System.Drawing.Point(0, 94);
            this.dktUsuarios.Name = "dktUsuarios";
            this.dktUsuarios.SelectedIndex = 2;
            this.dktUsuarios.Size = new System.Drawing.Size(850, 456);
            this.dktUsuarios.TabIndex = 42;
            this.dktUsuarios.TabsSpacing = 0;
            this.dktUsuarios.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpCierre
            // 
            this.tpCierre.Controls.Add(this.groupBox2);
            this.tpCierre.Location = new System.Drawing.Point(1, 24);
            this.tpCierre.Name = "tpCierre";
            this.tpCierre.Size = new System.Drawing.Size(848, 431);
            this.tpCierre.TabIndex = 2;
            this.tpCierre.Text = "Cierre";
            this.tpCierre.Enter += new System.EventHandler(this.tpCierre_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.dtpFechaCierre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblObservaciones);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtDiferencia);
            this.groupBox2.Controls.Add(this.lblMensaje);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(73, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 359);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cierre de Caja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(157, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Día de Cierre";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtObservaciones.Location = new System.Drawing.Point(161, 279);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(367, 55);
            this.txtObservaciones.TabIndex = 58;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Checked = false;
            this.dtpFechaCierre.CustomFormat = "MMMM dd, yyyy";
            this.dtpFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCierre.Location = new System.Drawing.Point(277, 57);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(252, 29);
            this.dtpFechaCierre.TabIndex = 57;
            this.dtpFechaCierre.ValueChanged += new System.EventHandler(this.dtpFechaCierre_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Día de Cierre";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblObservaciones.Location = new System.Drawing.Point(157, 252);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(142, 24);
            this.lblObservaciones.TabIndex = 53;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalVendido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalEfectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(161, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 94);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // txtTotalVendido
            // 
            this.txtTotalVendido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalVendido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTotalVendido.Location = new System.Drawing.Point(212, 59);
            this.txtTotalVendido.Name = "txtTotalVendido";
            this.txtTotalVendido.ReadOnly = true;
            this.txtTotalVendido.Size = new System.Drawing.Size(121, 22);
            this.txtTotalVendido.TabIndex = 33;
            this.txtTotalVendido.Text = "0";
            this.txtTotalVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(56, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total Vendido";
            // 
            // txtTotalEfectivo
            // 
            this.txtTotalEfectivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTotalEfectivo.Location = new System.Drawing.Point(212, 22);
            this.txtTotalEfectivo.Name = "txtTotalEfectivo";
            this.txtTotalEfectivo.Size = new System.Drawing.Size(121, 22);
            this.txtTotalEfectivo.TabIndex = 0;
            this.txtTotalEfectivo.Text = "0";
            this.txtTotalEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalEfectivo.TextChanged += new System.EventHandler(this.txtTotalEfectivo_TextChanged);
            this.txtTotalEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalEfectivo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(56, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Efectivo";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDiferencia.ForeColor = System.Drawing.Color.Red;
            this.txtDiferencia.Location = new System.Drawing.Point(407, 211);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.Size = new System.Drawing.Size(121, 22);
            this.txtDiferencia.TabIndex = 56;
            this.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiferencia.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(214, 211);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(89, 24);
            this.lblMensaje.TabIndex = 54;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.Visible = false;
            // 
            // tpListaCierres
            // 
            this.tpListaCierres.Controls.Add(this.txtTotal);
            this.tpListaCierres.Controls.Add(this.lblTotal);
            this.tpListaCierres.Controls.Add(this.dbgCierres);
            this.tpListaCierres.Location = new System.Drawing.Point(1, 24);
            this.tpListaCierres.Name = "tpListaCierres";
            this.tpListaCierres.Size = new System.Drawing.Size(848, 431);
            this.tpListaCierres.TabIndex = 1;
            this.tpListaCierres.Text = "Lista Cierres";
            this.tpListaCierres.Enter += new System.EventHandler(this.tpListaCierres_Enter);
            // 
            // dbgCierres
            // 
            this.dbgCierres.AllowUpdate = false;
            this.dbgCierres.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgCierres.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgCierres.Images"))));
            this.dbgCierres.Location = new System.Drawing.Point(0, 0);
            this.dbgCierres.Name = "dbgCierres";
            this.dbgCierres.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgCierres.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgCierres.PreviewInfo.ZoomFactor = 75D;
            this.dbgCierres.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgCierres.PrintInfo.PageSettings")));
            this.dbgCierres.Size = new System.Drawing.Size(848, 392);
            this.dbgCierres.TabIndex = 1;
            this.dbgCierres.Text = "c1TrueDBGrid1";
            this.dbgCierres.DoubleClick += new System.EventHandler(this.dbgCierres_DoubleClick);
            this.dbgCierres.PropBag = resources.GetString("dbgCierres.PropBag");
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(422, 396);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 29);
            this.txtTotal.TabIndex = 52;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(271, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 25);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "Total Ventas";
            // 
            // frmCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelCierre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCierre";
            this.Load += new System.EventHandler(this.frmCierre_Load);
            this.panelCierre.ResumeLayout(false);
            this.panelCierre.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktUsuarios)).EndInit();
            this.dktUsuarios.ResumeLayout(false);
            this.tpCierre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpListaCierres.ResumeLayout(false);
            this.tpListaCierres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgCierres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCierre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private C1.Win.C1Command.C1DockingTab dktUsuarios;
        private C1.Win.C1Command.C1DockingTabPage tpCierre;
        private System.Windows.Forms.GroupBox groupBox2;
        private C1.Win.C1Command.C1DockingTabPage tpListaCierres;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgCierres;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtTotalVendido;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTotalEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton tsbAjustar;
        private System.Windows.Forms.ToolStripButton tsbCierreParcial;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}