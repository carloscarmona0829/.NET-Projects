namespace libGuiPOS.Registros
{
    partial class frmCasas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombrepropietario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcasaid = new System.Windows.Forms.Label();
            this.txtnumerocasa = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtcasas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumerocasabusqueda = new System.Windows.Forms.TextBox();
            this.txtnombrebusqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcasas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnombrepropietario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblcasaid);
            this.groupBox1.Controls.Add(this.txtnumerocasa);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(122, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Casas";
            // 
            // txtnombrepropietario
            // 
            this.txtnombrepropietario.Location = new System.Drawing.Point(177, 45);
            this.txtnombrepropietario.Name = "txtnombrepropietario";
            this.txtnombrepropietario.Size = new System.Drawing.Size(250, 20);
            this.txtnombrepropietario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // lblcasaid
            // 
            this.lblcasaid.AutoSize = true;
            this.lblcasaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcasaid.Location = new System.Drawing.Point(24, 72);
            this.lblcasaid.Name = "lblcasaid";
            this.lblcasaid.Size = new System.Drawing.Size(50, 15);
            this.lblcasaid.TabIndex = 4;
            this.lblcasaid.Text = "lblcasaid";
            this.lblcasaid.Visible = false;
            // 
            // txtnumerocasa
            // 
            this.txtnumerocasa.Location = new System.Drawing.Point(481, 45);
            this.txtnumerocasa.Name = "txtnumerocasa";
            this.txtnumerocasa.Size = new System.Drawing.Size(100, 20);
            this.txtnumerocasa.TabIndex = 2;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(24, 45);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 0;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Lote";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtcasas);
            this.groupBox3.Location = new System.Drawing.Point(191, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dtcasas
            // 
            this.dtcasas.AllowUserToAddRows = false;
            this.dtcasas.AllowUserToDeleteRows = false;
            this.dtcasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcasas.Location = new System.Drawing.Point(6, 15);
            this.dtcasas.Name = "dtcasas";
            this.dtcasas.ReadOnly = true;
            this.dtcasas.Size = new System.Drawing.Size(466, 219);
            this.dtcasas.TabIndex = 0;
            this.dtcasas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtcasas_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbActualizar,
            this.tsbEliminar,
            this.tsbSalir,
            this.tsbConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 41);
            this.toolStrip1.TabIndex = 3;
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
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click_1);
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbConsultar.Image = global::libGuiPOS.Properties.Resources.green_search_icon48;
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(96, 38);
            this.tsbConsultar.Text = "Consultar";
            this.tsbConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuarios.Controls.Add(this.label3);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(850, 50);
            this.panelUsuarios.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(293, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADMINISTRACIÓN DE CASAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnumerocasabusqueda);
            this.groupBox2.Controls.Add(this.txtnombrebusqueda);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(151, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // txtnumerocasabusqueda
            // 
            this.txtnumerocasabusqueda.Location = new System.Drawing.Point(48, 32);
            this.txtnumerocasabusqueda.Name = "txtnumerocasabusqueda";
            this.txtnumerocasabusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtnumerocasabusqueda.TabIndex = 0;
            this.txtnumerocasabusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnumerocasabusqueda_KeyDown);
            this.txtnumerocasabusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumerocasabusqueda_KeyPress);
            // 
            // txtnombrebusqueda
            // 
            this.txtnombrebusqueda.Location = new System.Drawing.Point(260, 32);
            this.txtnombrebusqueda.Name = "txtnombrebusqueda";
            this.txtnombrebusqueda.Size = new System.Drawing.Size(250, 20);
            this.txtnombrebusqueda.TabIndex = 1;
            this.txtnombrebusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombrebusqueda_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero Casa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre Propietario";
            // 
            // frmCasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCasas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casas";
            this.Load += new System.EventHandler(this.frmCasas_Load);
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtcasas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumerocasa;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcasaid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtcasas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrepropietario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombrebusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.TextBox txtnumerocasabusqueda;
        private System.Windows.Forms.Label label6;
    }
}