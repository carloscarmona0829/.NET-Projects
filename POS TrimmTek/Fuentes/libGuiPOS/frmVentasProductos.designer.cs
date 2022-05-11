namespace libGuiPOS
{
    partial class frmVentasProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasProductos));
            this.panelVentasProductos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbgVentas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelVentasProductos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVentasProductos
            // 
            this.panelVentasProductos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelVentasProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentasProductos.Controls.Add(this.label1);
            this.panelVentasProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelVentasProductos.Location = new System.Drawing.Point(0, 0);
            this.panelVentasProductos.Name = "panelVentasProductos";
            this.panelVentasProductos.Size = new System.Drawing.Size(850, 50);
            this.panelVentasProductos.TabIndex = 14;
            this.panelVentasProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(324, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS PRODUCTOS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 16;
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.Image = global::libGuiPOS.Properties.Resources.red_home_icon481;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(67, 38);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click_1);
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Image = global::libGuiPOS.Properties.Resources.green_search_icon48;
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(96, 38);
            this.tsbConsultar.Text = "Consultar";
            this.tsbConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(456, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(66, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Miramonte", 12F);
            this.dtpFechaFin.Location = new System.Drawing.Point(521, 138);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(268, 27);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Miramonte", 12F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(133, 138);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(268, 27);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 73);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Ventas";
            // 
            // dbgVentas
            // 
            this.dbgVentas.AllowUpdate = false;
            this.dbgVentas.FilterBar = true;
            this.dbgVentas.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgVentas.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgVentas.Images"))));
            this.dbgVentas.Location = new System.Drawing.Point(0, 186);
            this.dbgVentas.Name = "dbgVentas";
            this.dbgVentas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgVentas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgVentas.PreviewInfo.ZoomFactor = 75D;
            this.dbgVentas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgVentas.PrintInfo.PageSettings")));
            this.dbgVentas.Size = new System.Drawing.Size(850, 365);
            this.dbgVentas.TabIndex = 22;
            this.dbgVentas.Text = "c1TrueDBGrid1";
            this.dbgVentas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.dbgVentas.PropBag = resources.GetString("dbgVentas.PropBag");
            // 
            // frmVentasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dbgVentas);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelVentasProductos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentasProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentasProductos";
            this.panelVentasProductos.ResumeLayout(false);
            this.panelVentasProductos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentasProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgVentas;
    }
}