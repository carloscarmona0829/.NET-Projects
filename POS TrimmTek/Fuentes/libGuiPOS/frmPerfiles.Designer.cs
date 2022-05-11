namespace libGuiPOS
{
    partial class frmPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfiles));
            this.label1 = new System.Windows.Forms.Label();
            this.panelPerfiles = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.dktPerfiles = new C1.Win.C1Command.C1DockingTab();
            this.tpPerfil = new C1.Win.C1Command.C1DockingTabPage();
            this.grbPerfil = new System.Windows.Forms.GroupBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpListaPerfiles = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgPerfiles = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelPerfiles.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktPerfiles)).BeginInit();
            this.dktPerfiles.SuspendLayout();
            this.tpPerfil.SuspendLayout();
            this.grbPerfil.SuspendLayout();
            this.tpListaPerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE PERFILES DEL SISTEMA";
            // 
            // panelPerfiles
            // 
            this.panelPerfiles.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPerfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerfiles.Controls.Add(this.label1);
            this.panelPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfiles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPerfiles.Location = new System.Drawing.Point(0, 0);
            this.panelPerfiles.Name = "panelPerfiles";
            this.panelPerfiles.Size = new System.Drawing.Size(850, 50);
            this.panelPerfiles.TabIndex = 13;
            this.panelPerfiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPerfiles_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbActualizar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbSalir,
            this.tsbNuevo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 14;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
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
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::libGuiPOS.Properties.Resources.green_document_plus_icon48;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(80, 38);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // dktPerfiles
            // 
            this.dktPerfiles.Controls.Add(this.tpPerfil);
            this.dktPerfiles.Controls.Add(this.tpListaPerfiles);
            this.dktPerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktPerfiles.Location = new System.Drawing.Point(0, 91);
            this.dktPerfiles.Name = "dktPerfiles";
            this.dktPerfiles.SelectedIndex = 1;
            this.dktPerfiles.Size = new System.Drawing.Size(850, 459);
            this.dktPerfiles.TabIndex = 15;
            this.dktPerfiles.TabsSpacing = 0;
            this.dktPerfiles.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpPerfil
            // 
            this.tpPerfil.Controls.Add(this.grbPerfil);
            this.tpPerfil.Location = new System.Drawing.Point(1, 24);
            this.tpPerfil.Name = "tpPerfil";
            this.tpPerfil.Size = new System.Drawing.Size(848, 434);
            this.tpPerfil.TabIndex = 2;
            this.tpPerfil.Text = "Perfil";
            this.tpPerfil.Enter += new System.EventHandler(this.tpPerfil_Enter);
            // 
            // grbPerfil
            // 
            this.grbPerfil.Controls.Add(this.txtPerfil);
            this.grbPerfil.Controls.Add(this.label11);
            this.grbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPerfil.Location = new System.Drawing.Point(209, 104);
            this.grbPerfil.Name = "grbPerfil";
            this.grbPerfil.Size = new System.Drawing.Size(435, 182);
            this.grbPerfil.TabIndex = 11;
            this.grbPerfil.TabStop = false;
            this.grbPerfil.Text = "Perfiles del Sistema ";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(118, 80);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(263, 26);
            this.txtPerfil.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Perfil:  ";
            // 
            // tpListaPerfiles
            // 
            this.tpListaPerfiles.Controls.Add(this.dbgPerfiles);
            this.tpListaPerfiles.Location = new System.Drawing.Point(1, 24);
            this.tpListaPerfiles.Name = "tpListaPerfiles";
            this.tpListaPerfiles.Size = new System.Drawing.Size(848, 434);
            this.tpListaPerfiles.TabIndex = 1;
            this.tpListaPerfiles.Text = "Lista Perfiles";
            this.tpListaPerfiles.Enter += new System.EventHandler(this.tpListaPerfiles_Enter);
            // 
            // dbgPerfiles
            // 
            this.dbgPerfiles.AllowDelete = true;
            this.dbgPerfiles.AllowUpdate = false;
            this.dbgPerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgPerfiles.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgPerfiles.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgPerfiles.Images"))));
            this.dbgPerfiles.Location = new System.Drawing.Point(0, 0);
            this.dbgPerfiles.Name = "dbgPerfiles";
            this.dbgPerfiles.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgPerfiles.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgPerfiles.PreviewInfo.ZoomFactor = 75D;
            this.dbgPerfiles.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgPerfiles.PrintInfo.PageSettings")));
            this.dbgPerfiles.Size = new System.Drawing.Size(848, 434);
            this.dbgPerfiles.TabIndex = 0;
            this.dbgPerfiles.Text = "c1TrueDBGrid1";
            this.dbgPerfiles.DoubleClick += new System.EventHandler(this.dbgPerfiles_DoubleClick);
            this.dbgPerfiles.PropBag = resources.GetString("dbgPerfiles.PropBag");
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktPerfiles);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            this.panelPerfiles.ResumeLayout(false);
            this.panelPerfiles.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktPerfiles)).EndInit();
            this.dktPerfiles.ResumeLayout(false);
            this.tpPerfil.ResumeLayout(false);
            this.grbPerfil.ResumeLayout(false);
            this.grbPerfil.PerformLayout();
            this.tpListaPerfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPerfiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private C1.Win.C1Command.C1DockingTab dktPerfiles;
        private C1.Win.C1Command.C1DockingTabPage tpPerfil;
        private System.Windows.Forms.GroupBox grbPerfil;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label label11;
        private C1.Win.C1Command.C1DockingTabPage tpListaPerfiles;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgPerfiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
    }
}