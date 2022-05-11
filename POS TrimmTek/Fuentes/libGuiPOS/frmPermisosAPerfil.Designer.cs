namespace libGuiPOS
{
    partial class frmPermisosAPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisosAPerfil));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.panelPermiso = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModulos = new C1.Win.C1List.C1Combo();
            this.cmbPerfiles = new C1.Win.C1List.C1Combo();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.dbgPermisosAPerfiles = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.toolStrip1.SuspendLayout();
            this.panelPermiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfiles)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPermisosAPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 16;
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
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::libGuiPOS.Properties.Resources.green_cross_icon481;
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
            // panelPermiso
            // 
            this.panelPermiso.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPermiso.Controls.Add(this.label1);
            this.panelPermiso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPermiso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPermiso.Location = new System.Drawing.Point(0, 0);
            this.panelPermiso.Name = "panelPermiso";
            this.panelPermiso.Size = new System.Drawing.Size(850, 50);
            this.panelPermiso.TabIndex = 15;
            this.panelPermiso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPermiso_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(236, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASIGNACIÓN DE PERMISOS A PERFILES";
            // 
            // cmbModulos
            // 
            this.cmbModulos.AddItemSeparator = ';';
            this.cmbModulos.AutoCompletion = true;
            this.cmbModulos.AutoDropDown = true;
            this.cmbModulos.AutoSelect = true;
            this.cmbModulos.Caption = "";
            this.cmbModulos.CaptionHeight = 17;
            this.cmbModulos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbModulos.ColumnCaptionHeight = 17;
            this.cmbModulos.ColumnFooterHeight = 17;
            this.cmbModulos.ContentHeight = 22;
            this.cmbModulos.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbModulos.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbModulos.EditorFont = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulos.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbModulos.EditorHeight = 22;
            this.cmbModulos.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulos.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbModulos.Images"))));
            this.cmbModulos.ItemHeight = 15;
            this.cmbModulos.LimitToList = true;
            this.cmbModulos.Location = new System.Drawing.Point(266, 80);
            this.cmbModulos.MatchEntryTimeout = ((long)(2000));
            this.cmbModulos.MaxDropDownItems = ((short)(5));
            this.cmbModulos.MaxLength = 32767;
            this.cmbModulos.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbModulos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbModulos.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbModulos.Size = new System.Drawing.Size(287, 28);
            this.cmbModulos.TabIndex = 21;
            this.cmbModulos.Click += new System.EventHandler(this.cmbModulos_Click);
            this.cmbModulos.PropBag = resources.GetString("cmbModulos.PropBag");
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.AddItemSeparator = ';';
            this.cmbPerfiles.AutoCompletion = true;
            this.cmbPerfiles.AutoDropDown = true;
            this.cmbPerfiles.AutoSelect = true;
            this.cmbPerfiles.Caption = "";
            this.cmbPerfiles.CaptionHeight = 17;
            this.cmbPerfiles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbPerfiles.ColumnCaptionHeight = 17;
            this.cmbPerfiles.ColumnFooterHeight = 17;
            this.cmbPerfiles.ContentHeight = 22;
            this.cmbPerfiles.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbPerfiles.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbPerfiles.EditorFont = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfiles.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPerfiles.EditorHeight = 22;
            this.cmbPerfiles.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfiles.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbPerfiles.Images"))));
            this.cmbPerfiles.ItemHeight = 15;
            this.cmbPerfiles.LimitToList = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(266, 26);
            this.cmbPerfiles.MatchEntryTimeout = ((long)(2000));
            this.cmbPerfiles.MaxDropDownItems = ((short)(5));
            this.cmbPerfiles.MaxLength = 32767;
            this.cmbPerfiles.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbPerfiles.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbPerfiles.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbPerfiles.Size = new System.Drawing.Size(287, 28);
            this.cmbPerfiles.TabIndex = 20;
            this.cmbPerfiles.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPerfiles_Validating);
            this.cmbPerfiles.PropBag = resources.GetString("cmbPerfiles.PropBag");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(151, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Modulo: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Perfil: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnAgragar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbPerfiles);
            this.panel2.Controls.Add(this.cmbModulos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 149);
            this.panel2.TabIndex = 26;
            // 
            // btnAgragar
            // 
            this.btnAgragar.Image = global::libGuiPOS.Properties.Resources.green_document_plus_icon48;
            this.btnAgragar.Location = new System.Drawing.Point(609, 43);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(50, 50);
            this.btnAgragar.TabIndex = 25;
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // dbgPermisosAPerfiles
            // 
            this.dbgPermisosAPerfiles.AllowUpdate = false;
            this.dbgPermisosAPerfiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dbgPermisosAPerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgPermisosAPerfiles.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgPermisosAPerfiles.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgPermisosAPerfiles.Images"))));
            this.dbgPermisosAPerfiles.Location = new System.Drawing.Point(0, 240);
            this.dbgPermisosAPerfiles.Name = "dbgPermisosAPerfiles";
            this.dbgPermisosAPerfiles.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgPermisosAPerfiles.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgPermisosAPerfiles.PreviewInfo.ZoomFactor = 75D;
            this.dbgPermisosAPerfiles.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgPermisosAPerfiles.PrintInfo.PageSettings")));
            this.dbgPermisosAPerfiles.Size = new System.Drawing.Size(850, 310);
            this.dbgPermisosAPerfiles.TabIndex = 24;
            this.dbgPermisosAPerfiles.Text = "c1TrueDBGrid1";
            this.dbgPermisosAPerfiles.Visible = false;
            this.dbgPermisosAPerfiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgPermisosAPerfiles_KeyDown);
            this.dbgPermisosAPerfiles.PropBag = resources.GetString("dbgPermisosAPerfiles.PropBag");
            // 
            // frmPermisosAPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dbgPermisosAPerfiles);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelPermiso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermisosAPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.Load += new System.EventHandler(this.frmPermisosAPerfil_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelPermiso.ResumeLayout(false);
            this.panelPermiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfiles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPermisosAPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panelPermiso;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1List.C1Combo cmbModulos;
        private C1.Win.C1List.C1Combo cmbPerfiles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgPermisosAPerfiles;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}