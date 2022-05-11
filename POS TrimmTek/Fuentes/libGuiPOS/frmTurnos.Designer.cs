namespace libGuiPOS
{
    partial class frmTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnos));
            this.panelTurnos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.dbgTurnos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelTurnos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTurnos
            // 
            this.panelTurnos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTurnos.Controls.Add(this.label1);
            this.panelTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTurnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTurnos.Location = new System.Drawing.Point(0, 0);
            this.panelTurnos.Name = "panelTurnos";
            this.panelTurnos.Size = new System.Drawing.Size(850, 50);
            this.panelTurnos.TabIndex = 13;
            this.panelTurnos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTurnos_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(385, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TURNOS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 15;
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
            // dbgTurnos
            // 
            this.dbgTurnos.AllowUpdate = false;
            this.dbgTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgTurnos.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgTurnos.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgTurnos.Images"))));
            this.dbgTurnos.Location = new System.Drawing.Point(0, 91);
            this.dbgTurnos.Name = "dbgTurnos";
            this.dbgTurnos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgTurnos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgTurnos.PreviewInfo.ZoomFactor = 75D;
            this.dbgTurnos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgTurnos.PrintInfo.PageSettings")));
            this.dbgTurnos.Size = new System.Drawing.Size(850, 459);
            this.dbgTurnos.TabIndex = 16;
            this.dbgTurnos.Text = "c1TrueDBGrid1";
            this.dbgTurnos.PropBag = resources.GetString("dbgTurnos.PropBag");
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dbgTurnos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTurnos";
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            this.panelTurnos.ResumeLayout(false);
            this.panelTurnos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgTurnos;
    }
}