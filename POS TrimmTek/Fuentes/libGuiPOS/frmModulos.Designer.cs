namespace libGuiPOS
{
    partial class frmModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulos));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.panelModulos = new System.Windows.Forms.Panel();
            this.dktModulos = new C1.Win.C1Command.C1DockingTab();
            this.tpModulos = new C1.Win.C1Command.C1DockingTabPage();
            this.grbPerfil = new System.Windows.Forms.GroupBox();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpListaModulos = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgModulos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.toolStrip1.SuspendLayout();
            this.panelModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktModulos)).BeginInit();
            this.dktModulos.SuspendLayout();
            this.tpModulos.SuspendLayout();
            this.grbPerfil.SuspendLayout();
            this.tpListaModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(201, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE MODULOS DEL SISTEMA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbActualizar,
            this.tsbEliminar,
            this.tsbNuevo,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 17;
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
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::libGuiPOS.Properties.Resources.green_document_plus_icon48;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(80, 38);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            // panelModulos
            // 
            this.panelModulos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelModulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModulos.Controls.Add(this.label1);
            this.panelModulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModulos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelModulos.Location = new System.Drawing.Point(0, 0);
            this.panelModulos.Name = "panelModulos";
            this.panelModulos.Size = new System.Drawing.Size(850, 50);
            this.panelModulos.TabIndex = 16;
            this.panelModulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelModulos_MouseDown);
            // 
            // dktModulos
            // 
            this.dktModulos.Controls.Add(this.tpModulos);
            this.dktModulos.Controls.Add(this.tpListaModulos);
            this.dktModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktModulos.Location = new System.Drawing.Point(0, 91);
            this.dktModulos.Name = "dktModulos";
            this.dktModulos.SelectedIndex = 1;
            this.dktModulos.Size = new System.Drawing.Size(850, 459);
            this.dktModulos.TabIndex = 18;
            this.dktModulos.TabsSpacing = 0;
            this.dktModulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpModulos
            // 
            this.tpModulos.Controls.Add(this.grbPerfil);
            this.tpModulos.Location = new System.Drawing.Point(1, 24);
            this.tpModulos.Name = "tpModulos";
            this.tpModulos.Size = new System.Drawing.Size(848, 434);
            this.tpModulos.TabIndex = 2;
            this.tpModulos.Text = "Modulo";
            this.tpModulos.Enter += new System.EventHandler(this.tpModulos_Enter);
            // 
            // grbPerfil
            // 
            this.grbPerfil.Controls.Add(this.txtModulo);
            this.grbPerfil.Controls.Add(this.label11);
            this.grbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPerfil.Location = new System.Drawing.Point(170, 113);
            this.grbPerfil.Name = "grbPerfil";
            this.grbPerfil.Size = new System.Drawing.Size(521, 184);
            this.grbPerfil.TabIndex = 11;
            this.grbPerfil.TabStop = false;
            this.grbPerfil.Text = "Modulos del Sistema ";
            // 
            // txtModulo
            // 
            this.txtModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModulo.Location = new System.Drawing.Point(176, 84);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(260, 26);
            this.txtModulo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Modulo: ";
            // 
            // tpListaModulos
            // 
            this.tpListaModulos.Controls.Add(this.dbgModulos);
            this.tpListaModulos.Location = new System.Drawing.Point(1, 24);
            this.tpListaModulos.Name = "tpListaModulos";
            this.tpListaModulos.Size = new System.Drawing.Size(848, 434);
            this.tpListaModulos.TabIndex = 1;
            this.tpListaModulos.Text = "Lista Modulos";
            this.tpListaModulos.Enter += new System.EventHandler(this.tpListaModulos_Enter);
            // 
            // dbgModulos
            // 
            this.dbgModulos.AllowDelete = true;
            this.dbgModulos.AllowUpdate = false;
            this.dbgModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgModulos.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgModulos.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgModulos.Images"))));
            this.dbgModulos.Location = new System.Drawing.Point(0, 0);
            this.dbgModulos.Name = "dbgModulos";
            this.dbgModulos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgModulos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgModulos.PreviewInfo.ZoomFactor = 75D;
            this.dbgModulos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgModulos.PrintInfo.PageSettings")));
            this.dbgModulos.Size = new System.Drawing.Size(848, 434);
            this.dbgModulos.TabIndex = 0;
            this.dbgModulos.Text = "c1TrueDBGrid1";
            this.dbgModulos.DoubleClick += new System.EventHandler(this.dbgModulos_DoubleClick);
            this.dbgModulos.PropBag = resources.GetString("dbgModulos.PropBag");
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktModulos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelModulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.Load += new System.EventHandler(this.frmModulos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelModulos.ResumeLayout(false);
            this.panelModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktModulos)).EndInit();
            this.dktModulos.ResumeLayout(false);
            this.tpModulos.ResumeLayout(false);
            this.grbPerfil.ResumeLayout(false);
            this.grbPerfil.PerformLayout();
            this.tpListaModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Panel panelModulos;
        private C1.Win.C1Command.C1DockingTab dktModulos;
        private C1.Win.C1Command.C1DockingTabPage tpModulos;
        private System.Windows.Forms.GroupBox grbPerfil;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label label11;
        private C1.Win.C1Command.C1DockingTabPage tpListaModulos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgModulos;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
    }
}