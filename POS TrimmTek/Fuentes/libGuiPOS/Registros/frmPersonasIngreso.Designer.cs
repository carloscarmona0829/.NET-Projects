namespace libGuiPOS.Registros
{
    partial class frmPersonasIngreso
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
            this.cmbcasa = new System.Windows.Forms.ComboBox();
            this.lblpersonaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbtipovisitante = new System.Windows.Forms.ComboBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgpersonas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombrebusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcedulabusqueda = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntomarfoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.IniciarCamara = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpersonas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcasa);
            this.groupBox1.Controls.Add(this.lblpersonaid);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbtipovisitante);
            this.groupBox1.Controls.Add(this.txtnota);
            this.groupBox1.Controls.Add(this.txtsegundonombre);
            this.groupBox1.Controls.Add(this.txtprimernombre);
            this.groupBox1.Controls.Add(this.txtsegundoapellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtprimerapellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // cmbcasa
            // 
            this.cmbcasa.DisplayMember = "NumeroCasa";
            this.cmbcasa.FormattingEnabled = true;
            this.cmbcasa.Location = new System.Drawing.Point(399, 141);
            this.cmbcasa.Name = "cmbcasa";
            this.cmbcasa.Size = new System.Drawing.Size(150, 21);
            this.cmbcasa.TabIndex = 16;
            this.cmbcasa.TabStop = false;
            this.cmbcasa.ValueMember = "CasaId";
            // 
            // lblpersonaid
            // 
            this.lblpersonaid.AutoSize = true;
            this.lblpersonaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpersonaid.Location = new System.Drawing.Point(121, 17);
            this.lblpersonaid.Name = "lblpersonaid";
            this.lblpersonaid.Size = new System.Drawing.Size(65, 15);
            this.lblpersonaid.TabIndex = 10;
            this.lblpersonaid.Text = "lblpersonaid";
            this.lblpersonaid.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Destino:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo Visitante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nota:";
            // 
            // cmbtipovisitante
            // 
            this.cmbtipovisitante.DisplayMember = "NumeroCasa";
            this.cmbtipovisitante.FormattingEnabled = true;
            this.cmbtipovisitante.Items.AddRange(new object[] {
            "Seleccionar",
            "Visitante",
            "Contratista",
            "Empleado Interno",
            "Otro"});
            this.cmbtipovisitante.Location = new System.Drawing.Point(399, 175);
            this.cmbtipovisitante.Name = "cmbtipovisitante";
            this.cmbtipovisitante.Size = new System.Drawing.Size(150, 21);
            this.cmbtipovisitante.TabIndex = 7;
            this.cmbtipovisitante.TabStop = false;
            this.cmbtipovisitante.ValueMember = "CasaId";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(118, 147);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(150, 50);
            this.txtnota.TabIndex = 5;
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Location = new System.Drawing.Point(399, 104);
            this.txtsegundonombre.MaxLength = 50;
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(150, 20);
            this.txtsegundonombre.TabIndex = 4;
            this.txtsegundonombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsegundonombre_KeyDown);
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Location = new System.Drawing.Point(118, 110);
            this.txtprimernombre.MaxLength = 50;
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(150, 20);
            this.txtprimernombre.TabIndex = 3;
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(399, 69);
            this.txtsegundoapellido.MaxLength = 50;
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(150, 20);
            this.txtsegundoapellido.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Primer Nombre:";
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(118, 73);
            this.txtprimerapellido.MaxLength = 50;
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(150, 20);
            this.txtprimerapellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(118, 36);
            this.txtcedula.MaxLength = 10;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 0;
            this.txtcedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcedula_KeyDown);
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgpersonas);
            this.groupBox3.Location = new System.Drawing.Point(28, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dtgpersonas
            // 
            this.dtgpersonas.AllowUserToAddRows = false;
            this.dtgpersonas.AllowUserToDeleteRows = false;
            this.dtgpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpersonas.Location = new System.Drawing.Point(18, 13);
            this.dtgpersonas.Name = "dtgpersonas";
            this.dtgpersonas.ReadOnly = true;
            this.dtgpersonas.Size = new System.Drawing.Size(745, 175);
            this.dtgpersonas.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(835, 41);
            this.toolStrip1.TabIndex = 17;
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
            this.panelUsuarios.Controls.Add(this.label6);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(835, 50);
            this.panelUsuarios.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(272, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADMINISTRACIÓN DE PERSONAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnombrebusqueda);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtcedulabusqueda);
            this.groupBox2.Location = new System.Drawing.Point(29, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // txtnombrebusqueda
            // 
            this.txtnombrebusqueda.Location = new System.Drawing.Point(348, 16);
            this.txtnombrebusqueda.Name = "txtnombrebusqueda";
            this.txtnombrebusqueda.Size = new System.Drawing.Size(150, 20);
            this.txtnombrebusqueda.TabIndex = 1;
            this.txtnombrebusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombrebusqueda_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cedula:";
            // 
            // txtcedulabusqueda
            // 
            this.txtcedulabusqueda.Location = new System.Drawing.Point(137, 16);
            this.txtcedulabusqueda.Name = "txtcedulabusqueda";
            this.txtcedulabusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtcedulabusqueda.TabIndex = 0;
            this.txtcedulabusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcedulabusqueda_KeyDown);
            this.txtcedulabusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedulabusqueda_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.IniciarCamara);
            this.groupBox4.Controls.Add(this.btntomarfoto);
            this.groupBox4.Controls.Add(this.pbFoto);
            this.groupBox4.Location = new System.Drawing.Point(621, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 276);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // btntomarfoto
            // 
            this.btntomarfoto.Location = new System.Drawing.Point(95, 241);
            this.btntomarfoto.Name = "btntomarfoto";
            this.btntomarfoto.Size = new System.Drawing.Size(75, 23);
            this.btntomarfoto.TabIndex = 20;
            this.btntomarfoto.Text = "Tomar Foto";
            this.btntomarfoto.UseVisualStyleBackColor = true;
            this.btntomarfoto.Click += new System.EventHandler(this.btntomarfoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbFoto.Image = global::libGuiPOS.Properties.Resources.user_128;
            this.pbFoto.Location = new System.Drawing.Point(6, 17);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(174, 218);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 19;
            this.pbFoto.TabStop = false;
            // 
            // IniciarCamara
            // 
            this.IniciarCamara.Location = new System.Drawing.Point(14, 241);
            this.IniciarCamara.Name = "IniciarCamara";
            this.IniciarCamara.Size = new System.Drawing.Size(75, 23);
            this.IniciarCamara.TabIndex = 21;
            this.IniciarCamara.Text = "Cámara";
            this.IniciarCamara.UseVisualStyleBackColor = true;
            this.IniciarCamara.Click += new System.EventHandler(this.IniciarCamara_Click);
            // 
            // frmPersonasIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 610);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonasIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmPersonasIngreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgpersonas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsegundonombre;
        private System.Windows.Forms.TextBox txtprimernombre;
        private System.Windows.Forms.TextBox txtsegundoapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgpersonas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpersonaid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcedulabusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombrebusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbtipovisitante;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.Button btntomarfoto;
        private System.Windows.Forms.ComboBox cmbcasa;
        private System.Windows.Forms.Button IniciarCamara;
    }
}