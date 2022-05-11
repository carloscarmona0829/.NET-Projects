namespace libGuiPOS
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.dktProveedores = new C1.Win.C1Command.C1DockingTab();
            this.tpProveedor = new C1.Win.C1Command.C1DockingTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtFijo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpListaProveedores = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgProveedores = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panelProveedores.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktProveedores)).BeginInit();
            this.dktProveedores.SuspendLayout();
            this.tpProveedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpListaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProveedores.Controls.Add(this.label1);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProveedores.Location = new System.Drawing.Point(0, 0);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(850, 50);
            this.panelProveedores.TabIndex = 13;
            this.panelProveedores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelProveedores_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(243, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE PROVEEDORES";
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
            this.toolStrip1.TabIndex = 14;
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
            // dktProveedores
            // 
            this.dktProveedores.Controls.Add(this.tpProveedor);
            this.dktProveedores.Controls.Add(this.tpListaProveedores);
            this.dktProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktProveedores.Location = new System.Drawing.Point(0, 91);
            this.dktProveedores.Name = "dktProveedores";
            this.dktProveedores.SelectedIndex = 1;
            this.dktProveedores.Size = new System.Drawing.Size(850, 459);
            this.dktProveedores.TabIndex = 15;
            this.dktProveedores.TabsSpacing = 0;
            this.dktProveedores.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpProveedor
            // 
            this.tpProveedor.AccessibleDescription = "";
            this.tpProveedor.Controls.Add(this.groupBox2);
            this.tpProveedor.Location = new System.Drawing.Point(1, 24);
            this.tpProveedor.Name = "tpProveedor";
            this.tpProveedor.Size = new System.Drawing.Size(848, 434);
            this.tpProveedor.TabIndex = 0;
            this.tpProveedor.Text = "Proveedor";
            this.tpProveedor.Enter += new System.EventHandler(this.tpProveedor_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdProveedor);
            this.groupBox2.Controls.Add(this.lblIdProveedor);
            this.groupBox2.Controls.Add(this.txtContacto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtFijo);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.txtRazonSocial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 301);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Del Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(135, 57);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtIdProveedor.TabIndex = 15;
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(14, 57);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(103, 20);
            this.lblIdProveedor.TabIndex = 16;
            this.lblIdProveedor.Text = "Id Proveedor:";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(563, 57);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(222, 26);
            this.txtContacto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contacto: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(563, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(135, 226);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(254, 26);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtFijo
            // 
            this.txtFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFijo.Location = new System.Drawing.Point(563, 171);
            this.txtFijo.Name = "txtFijo";
            this.txtFijo.Size = new System.Drawing.Size(222, 26);
            this.txtFijo.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(563, 113);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(222, 26);
            this.txtCelular.TabIndex = 5;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(135, 167);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(254, 26);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono Fíjo: ";
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(135, 113);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(254, 26);
            this.txtNit.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Correo Electrónico: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Razón Social: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "NIT : ";
            // 
            // tpListaProveedores
            // 
            this.tpListaProveedores.Controls.Add(this.dbgProveedores);
            this.tpListaProveedores.Location = new System.Drawing.Point(1, 24);
            this.tpListaProveedores.Name = "tpListaProveedores";
            this.tpListaProveedores.Size = new System.Drawing.Size(848, 434);
            this.tpListaProveedores.TabIndex = 1;
            this.tpListaProveedores.Text = "Lista Proveedores";
            this.tpListaProveedores.Enter += new System.EventHandler(this.tpListaProveedores_Enter);
            // 
            // dbgProveedores
            // 
            this.dbgProveedores.AllowUpdate = false;
            this.dbgProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgProveedores.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgProveedores.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgProveedores.Images"))));
            this.dbgProveedores.Location = new System.Drawing.Point(0, 0);
            this.dbgProveedores.Name = "dbgProveedores";
            this.dbgProveedores.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgProveedores.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgProveedores.PreviewInfo.ZoomFactor = 75D;
            this.dbgProveedores.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgProveedores.PrintInfo.PageSettings")));
            this.dbgProveedores.Size = new System.Drawing.Size(848, 434);
            this.dbgProveedores.TabIndex = 2;
            this.dbgProveedores.Text = "c1TrueDBGrid1";
            this.dbgProveedores.DoubleClick += new System.EventHandler(this.dbgProveedores_DoubleClick);
            this.dbgProveedores.PropBag = resources.GetString("dbgProveedores.PropBag");
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktProveedores);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dktProveedores)).EndInit();
            this.dktProveedores.ResumeLayout(false);
            this.tpProveedor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpListaProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private C1.Win.C1Command.C1DockingTab dktProveedores;
        private C1.Win.C1Command.C1DockingTabPage tpProveedor;
        private C1.Win.C1Command.C1DockingTabPage tpListaProveedores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFijo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgProveedores;
        public System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblIdProveedor;
    }
}