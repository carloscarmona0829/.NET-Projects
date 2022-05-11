namespace libGuiPOS
{
    partial class frmListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.dbgClientes = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelClientes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelClientes.Controls.Add(this.label1);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelClientes.Location = new System.Drawing.Point(0, 0);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(700, 50);
            this.panelClientes.TabIndex = 15;
            this.panelClientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClientes_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 41);
            this.toolStrip1.TabIndex = 18;
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
            // dbgClientes
            // 
            this.dbgClientes.AllowUpdate = false;
            this.dbgClientes.CaptionHeight = 17;
            this.dbgClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgClientes.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgClientes.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgClientes.Images"))));
            this.dbgClientes.Location = new System.Drawing.Point(0, 192);
            this.dbgClientes.Name = "dbgClientes";
            this.dbgClientes.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgClientes.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgClientes.PreviewInfo.ZoomFactor = 75D;
            this.dbgClientes.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgClientes.PrintInfo.PageSettings")));
            this.dbgClientes.RowHeight = 15;
            this.dbgClientes.Size = new System.Drawing.Size(700, 306);
            this.dbgClientes.TabIndex = 16;
            this.dbgClientes.Text = "c1TrueDBGrid1";
            this.dbgClientes.DoubleClick += new System.EventHandler(this.dbgClientes_DoubleClick);
            this.dbgClientes.PropBag = resources.GetString("dbgClientes.PropBag");
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dbgClientes);
            this.Controls.Add(this.panelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelClientes;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;

    }
}