namespace libGuiPOS.Registros
{
    partial class frmRegistro
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcasaid = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.cmbtipovisitante = new System.Windows.Forms.ComboBox();
            this.tblCasaregvisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdregvisDataSet = new libGuiPOS.bdregvisDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblregistroid = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgregistros = new System.Windows.Forms.DataGridView();
            this.tblCasaregvisTableAdapter = new libGuiPOS.bdregvisDataSetTableAdapters.tblCasaregvisTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegistroManual = new System.Windows.Forms.ToolStripButton();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblcontador = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCasaregvisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdregvisDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgregistros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcasaid);
            this.groupBox1.Controls.Add(this.txtdestino);
            this.groupBox1.Controls.Add(this.cmbtipovisitante);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnota);
            this.groupBox1.Controls.Add(this.txtsegundoapellido);
            this.groupBox1.Controls.Add(this.txtprimerapellido);
            this.groupBox1.Controls.Add(this.txtsegundonombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtprimernombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblregistroid);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // lblcasaid
            // 
            this.lblcasaid.AutoSize = true;
            this.lblcasaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcasaid.Location = new System.Drawing.Point(402, 41);
            this.lblcasaid.Name = "lblcasaid";
            this.lblcasaid.Size = new System.Drawing.Size(2, 15);
            this.lblcasaid.TabIndex = 28;
            this.lblcasaid.Visible = false;
            // 
            // txtdestino
            // 
            this.txtdestino.Enabled = false;
            this.txtdestino.Location = new System.Drawing.Point(403, 128);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(149, 20);
            this.txtdestino.TabIndex = 27;
            // 
            // cmbtipovisitante
            // 
            this.cmbtipovisitante.DataSource = this.tblCasaregvisBindingSource;
            this.cmbtipovisitante.DisplayMember = "NumeroCasa";
            this.cmbtipovisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbtipovisitante.Enabled = false;
            this.cmbtipovisitante.FormattingEnabled = true;
            this.cmbtipovisitante.Location = new System.Drawing.Point(402, 158);
            this.cmbtipovisitante.Name = "cmbtipovisitante";
            this.cmbtipovisitante.Size = new System.Drawing.Size(150, 21);
            this.cmbtipovisitante.TabIndex = 7;
            this.cmbtipovisitante.TabStop = false;
            this.cmbtipovisitante.ValueMember = "CasaId";
            // 
            // tblCasaregvisBindingSource
            // 
            this.tblCasaregvisBindingSource.DataMember = "tblCasaregvis";
            this.tblCasaregvisBindingSource.DataSource = this.bdregvisDataSet;
            // 
            // bdregvisDataSet
            // 
            this.bdregvisDataSet.DataSetName = "bdregvisDataSet";
            this.bdregvisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tipo Visitante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nota:";
            // 
            // txtnota
            // 
            this.txtnota.Enabled = false;
            this.txtnota.Location = new System.Drawing.Point(121, 128);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(150, 46);
            this.txtnota.TabIndex = 5;
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(402, 67);
            this.txtsegundoapellido.MaxLength = 50;
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(150, 20);
            this.txtsegundoapellido.TabIndex = 2;
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(121, 66);
            this.txtprimerapellido.MaxLength = 50;
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(150, 20);
            this.txtprimerapellido.TabIndex = 1;
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Location = new System.Drawing.Point(402, 96);
            this.txtsegundonombre.MaxLength = 50;
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(150, 20);
            this.txtsegundonombre.TabIndex = 4;
            this.txtsegundonombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsegundonombre_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Segundo Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Primer Apellido:";
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Location = new System.Drawing.Point(121, 97);
            this.txtprimernombre.MaxLength = 50;
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(150, 20);
            this.txtprimernombre.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Segundo Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Primer Nombre:";
            // 
            // lblregistroid
            // 
            this.lblregistroid.AutoSize = true;
            this.lblregistroid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblregistroid.Location = new System.Drawing.Point(124, 17);
            this.lblregistroid.Name = "lblregistroid";
            this.lblregistroid.Size = new System.Drawing.Size(61, 15);
            this.lblregistroid.TabIndex = 6;
            this.lblregistroid.Text = "lblregistroid";
            this.lblregistroid.Visible = false;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(121, 35);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 0;
            this.txtcedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcedula_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgregistros);
            this.groupBox2.Location = new System.Drawing.Point(28, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dtgregistros
            // 
            this.dtgregistros.AllowUserToAddRows = false;
            this.dtgregistros.AllowUserToDeleteRows = false;
            this.dtgregistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgregistros.Location = new System.Drawing.Point(12, 13);
            this.dtgregistros.Name = "dtgregistros";
            this.dtgregistros.ReadOnly = true;
            this.dtgregistros.Size = new System.Drawing.Size(762, 216);
            this.dtgregistros.TabIndex = 0;
            // 
            // tblCasaregvisTableAdapter
            // 
            this.tblCasaregvisTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtfechafinal);
            this.groupBox3.Controls.Add(this.dtfechainicial);
            this.groupBox3.Location = new System.Drawing.Point(28, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Inicial";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.Location = new System.Drawing.Point(326, 38);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Size = new System.Drawing.Size(220, 20);
            this.dtfechafinal.TabIndex = 1;
            this.dtfechafinal.TabStop = false;
            this.dtfechafinal.Value = new System.DateTime(2018, 8, 23, 0, 0, 0, 0);
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.Location = new System.Drawing.Point(39, 37);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Size = new System.Drawing.Size(220, 20);
            this.dtfechainicial.TabIndex = 0;
            this.dtfechainicial.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNuevo,
            this.tsbConsultar,
            this.tsbRegistroManual});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 41);
            this.toolStrip1.TabIndex = 2;
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
            // tsbRegistroManual
            // 
            this.tsbRegistroManual.BackColor = System.Drawing.SystemColors.Control;
            this.tsbRegistroManual.Image = global::libGuiPOS.Properties.Resources.green_disk_icon48;
            this.tsbRegistroManual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistroManual.Name = "tsbRegistroManual";
            this.tsbRegistroManual.Size = new System.Drawing.Size(131, 38);
            this.tsbRegistroManual.Text = "Registro Manual";
            this.tsbRegistroManual.ToolTipText = "Registro Manual";
            this.tsbRegistroManual.Click += new System.EventHandler(this.tsbRegistroManual_Click);
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
            this.panelUsuarios.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(266, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "REGISTRAR ENTRADA Y SALIDA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbFoto);
            this.groupBox4.Location = new System.Drawing.Point(628, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 234);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbFoto.Image = global::libGuiPOS.Properties.Resources.user_128;
            this.pbFoto.Location = new System.Drawing.Point(12, 21);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(163, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 19;
            this.pbFoto.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(624, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Contador:";
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador.Location = new System.Drawing.Point(718, 104);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(75, 33);
            this.lblcontador.TabIndex = 28;
            this.lblcontador.Text = "XXX";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 610);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Visitantes";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCasaregvisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdregvisDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgregistros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgregistros;
        private bdregvisDataSet bdregvisDataSet;
        private System.Windows.Forms.BindingSource tblCasaregvisBindingSource;
        private bdregvisDataSetTableAdapters.tblCasaregvisTableAdapter tblCasaregvisTableAdapter;
        private System.Windows.Forms.Label lblregistroid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtfechafinal;
        private System.Windows.Forms.DateTimePicker dtfechainicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsegundoapellido;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.TextBox txtsegundonombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprimernombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.ComboBox cmbtipovisitante;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label lblcasaid;
        private System.Windows.Forms.ToolStripButton tsbRegistroManual;
    }
}