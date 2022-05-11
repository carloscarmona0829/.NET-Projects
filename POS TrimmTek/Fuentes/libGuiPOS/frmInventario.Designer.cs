namespace libGuiPOS
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.panelInventario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.dbgInventario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelInventario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInventario.Controls.Add(this.label1);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(850, 50);
            this.panelInventario.TabIndex = 15;
            this.panelInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInventario_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbActualizar,
            this.tsbGuardar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 16;
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
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(88, 38);
            this.tsbGuardar.Text = "Exportar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbExportar_Click);
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
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.dbgInventario);
            this.gbInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbInventario.Location = new System.Drawing.Point(0, 91);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(850, 459);
            this.gbInventario.TabIndex = 17;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Actualización de Inventario";
            // 
            // dbgInventario
            // 
            this.dbgInventario.CaptionHeight = 17;
            this.dbgInventario.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown;
            this.dbgInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgInventario.FilterBar = true;
            this.dbgInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgInventario.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgInventario.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgInventario.Images"))));
            this.dbgInventario.Location = new System.Drawing.Point(3, 22);
            this.dbgInventario.Name = "dbgInventario";
            this.dbgInventario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgInventario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgInventario.PreviewInfo.ZoomFactor = 75D;
            this.dbgInventario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgInventario.PrintInfo.PageSettings")));
            this.dbgInventario.RowHeight = 15;
            this.dbgInventario.Size = new System.Drawing.Size(844, 434);
            this.dbgInventario.TabIndex = 2;
            this.dbgInventario.Text = "c1TrueDBGrid1";
            this.dbgInventario.BeforeColUpdate += new C1.Win.C1TrueDBGrid.BeforeColUpdateEventHandler(this.dbgInventario_BeforeColUpdate);
            this.dbgInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dbgInventario_KeyPress);
            this.dbgInventario.PropBag = resources.GetString("dbgInventario.PropBag");
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.gbInventario);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox gbInventario;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgInventario;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
    }
}