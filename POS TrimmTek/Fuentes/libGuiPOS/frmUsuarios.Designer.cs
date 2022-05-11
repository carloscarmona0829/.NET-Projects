namespace libGuiPOS
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.dktUsuarios = new C1.Win.C1Command.C1DockingTab();
            this.tpUsuario = new C1.Win.C1Command.C1DockingTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutorizador = new System.Windows.Forms.CheckBox();
            this.lblAutorizador = new System.Windows.Forms.Label();
            this.txtRepitaPwd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbEstado = new C1.Win.C1List.C1Combo();
            this.cmbPerfil = new C1.Win.C1List.C1Combo();
            this.cmbTipoUsuario = new C1.Win.C1List.C1Combo();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtFijo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpListaUsuarios = new C1.Win.C1Command.C1DockingTabPage();
            this.dbgUsuarios = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dktUsuarios)).BeginInit();
            this.dktUsuarios.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUsuario)).BeginInit();
            this.tpListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dktUsuarios
            // 
            this.dktUsuarios.Controls.Add(this.tpUsuario);
            this.dktUsuarios.Controls.Add(this.tpListaUsuarios);
            this.dktUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dktUsuarios.Location = new System.Drawing.Point(0, 91);
            this.dktUsuarios.Name = "dktUsuarios";
            this.dktUsuarios.SelectedIndex = 1;
            this.dktUsuarios.Size = new System.Drawing.Size(850, 459);
            this.dktUsuarios.TabIndex = 0;
            this.dktUsuarios.TabsSpacing = 0;
            this.dktUsuarios.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Controls.Add(this.groupBox2);
            this.tpUsuario.Location = new System.Drawing.Point(1, 24);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Size = new System.Drawing.Size(848, 434);
            this.tpUsuario.TabIndex = 2;
            this.tpUsuario.Text = "Usuario";
            this.tpUsuario.Enter += new System.EventHandler(this.tpUsuario_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutorizador);
            this.groupBox2.Controls.Add(this.lblAutorizador);
            this.groupBox2.Controls.Add(this.txtRepitaPwd);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.cmbPerfil);
            this.groupBox2.Controls.Add(this.cmbTipoUsuario);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtPwd);
            this.groupBox2.Controls.Add(this.txtFijo);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdentificacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 406);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Del Usuario";
            // 
            // chkAutorizador
            // 
            this.chkAutorizador.Enabled = false;
            this.chkAutorizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizador.Location = new System.Drawing.Point(562, 256);
            this.chkAutorizador.Name = "chkAutorizador";
            this.chkAutorizador.Size = new System.Drawing.Size(15, 15);
            this.chkAutorizador.TabIndex = 33;
            this.chkAutorizador.UseVisualStyleBackColor = true;
            // 
            // lblAutorizador
            // 
            this.lblAutorizador.AutoSize = true;
            this.lblAutorizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizador.Location = new System.Drawing.Point(410, 252);
            this.lblAutorizador.Name = "lblAutorizador";
            this.lblAutorizador.Size = new System.Drawing.Size(95, 20);
            this.lblAutorizador.TabIndex = 32;
            this.lblAutorizador.Text = "Autorizador:";
            // 
            // txtRepitaPwd
            // 
            this.txtRepitaPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaPwd.Location = new System.Drawing.Point(562, 360);
            this.txtRepitaPwd.Name = "txtRepitaPwd";
            this.txtRepitaPwd.PasswordChar = '*';
            this.txtRepitaPwd.Size = new System.Drawing.Size(222, 26);
            this.txtRepitaPwd.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(410, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Repita Contraseña: ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AddItemSeparator = ';';
            this.cmbEstado.Caption = "";
            this.cmbEstado.CaptionHeight = 17;
            this.cmbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbEstado.ColumnCaptionHeight = 17;
            this.cmbEstado.ColumnFooterHeight = 17;
            this.cmbEstado.ContentHeight = 21;
            this.cmbEstado.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbEstado.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbEstado.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEstado.EditorHeight = 21;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbEstado.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbEstado.Images"))));
            this.cmbEstado.ItemHeight = 15;
            this.cmbEstado.Location = new System.Drawing.Point(562, 203);
            this.cmbEstado.MatchEntryTimeout = ((long)(2000));
            this.cmbEstado.MaxDropDownItems = ((short)(5));
            this.cmbEstado.MaxLength = 32767;
            this.cmbEstado.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbEstado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbEstado.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbEstado.Size = new System.Drawing.Size(222, 27);
            this.cmbEstado.TabIndex = 9;
            this.cmbEstado.Text = "c1Combo1";
            this.cmbEstado.PropBag = resources.GetString("cmbEstado.PropBag");
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.AddItemSeparator = ';';
            this.cmbPerfil.Caption = "";
            this.cmbPerfil.CaptionHeight = 17;
            this.cmbPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbPerfil.ColumnCaptionHeight = 17;
            this.cmbPerfil.ColumnFooterHeight = 17;
            this.cmbPerfil.ContentHeight = 21;
            this.cmbPerfil.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbPerfil.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbPerfil.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPerfil.EditorHeight = 21;
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbPerfil.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbPerfil.Images"))));
            this.cmbPerfil.ItemHeight = 15;
            this.cmbPerfil.Location = new System.Drawing.Point(562, 142);
            this.cmbPerfil.MatchEntryTimeout = ((long)(2000));
            this.cmbPerfil.MaxDropDownItems = ((short)(5));
            this.cmbPerfil.MaxLength = 32767;
            this.cmbPerfil.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbPerfil.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbPerfil.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbPerfil.Size = new System.Drawing.Size(222, 27);
            this.cmbPerfil.TabIndex = 8;
            this.cmbPerfil.Text = "c1Combo1";
            this.cmbPerfil.PropBag = resources.GetString("cmbPerfil.PropBag");
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.AddItemSeparator = ';';
            this.cmbTipoUsuario.Caption = "";
            this.cmbTipoUsuario.CaptionHeight = 17;
            this.cmbTipoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipoUsuario.ColumnCaptionHeight = 17;
            this.cmbTipoUsuario.ColumnFooterHeight = 17;
            this.cmbTipoUsuario.ContentHeight = 21;
            this.cmbTipoUsuario.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbTipoUsuario.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbTipoUsuario.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTipoUsuario.EditorHeight = 21;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbTipoUsuario.Images"))));
            this.cmbTipoUsuario.ItemHeight = 15;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(562, 81);
            this.cmbTipoUsuario.MatchEntryTimeout = ((long)(2000));
            this.cmbTipoUsuario.MaxDropDownItems = ((short)(5));
            this.cmbTipoUsuario.MaxLength = 32767;
            this.cmbTipoUsuario.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbTipoUsuario.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbTipoUsuario.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbTipoUsuario.Size = new System.Drawing.Size(222, 27);
            this.cmbTipoUsuario.TabIndex = 7;
            this.cmbTipoUsuario.Text = "c1Combo1";
            this.cmbTipoUsuario.TextChanged += new System.EventHandler(this.cmbTipoUsuario_TextChanged);
            this.cmbTipoUsuario.PropBag = resources.GetString("cmbTipoUsuario.PropBag");
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(562, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(136, 273);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(254, 26);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(562, 300);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(222, 26);
            this.txtPwd.TabIndex = 10;
            // 
            // txtFijo
            // 
            this.txtFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFijo.Location = new System.Drawing.Point(136, 217);
            this.txtFijo.Name = "txtFijo";
            this.txtFijo.Size = new System.Drawing.Size(254, 26);
            this.txtFijo.TabIndex = 3;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(136, 159);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(254, 26);
            this.txtCelular.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(410, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Estado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Perfil: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tipo de Usuario: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha Nacimiento: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Checked = false;
            this.dtpFechaNacimiento.CustomFormat = "MMMM dd, yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(159, 333);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(231, 26);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono Fíjo: ";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(136, 43);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(254, 26);
            this.txtIdentificacion.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Correo Electrónico: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Identificación: ";
            // 
            // tpListaUsuarios
            // 
            this.tpListaUsuarios.Controls.Add(this.dbgUsuarios);
            this.tpListaUsuarios.Location = new System.Drawing.Point(1, 24);
            this.tpListaUsuarios.Name = "tpListaUsuarios";
            this.tpListaUsuarios.Size = new System.Drawing.Size(848, 434);
            this.tpListaUsuarios.TabIndex = 1;
            this.tpListaUsuarios.Text = "Lista Usuarios";
            this.tpListaUsuarios.Enter += new System.EventHandler(this.tpListaUsuarios_Enter);
            // 
            // dbgUsuarios
            // 
            this.dbgUsuarios.AllowUpdate = false;
            this.dbgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgUsuarios.GroupByCaption = "Drag a column header here to group by that column";
            this.dbgUsuarios.Images.Add(((System.Drawing.Image)(resources.GetObject("dbgUsuarios.Images"))));
            this.dbgUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dbgUsuarios.Name = "dbgUsuarios";
            this.dbgUsuarios.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.dbgUsuarios.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.dbgUsuarios.PreviewInfo.ZoomFactor = 75D;
            this.dbgUsuarios.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("dbgUsuarios.PrintInfo.PageSettings")));
            this.dbgUsuarios.Size = new System.Drawing.Size(848, 434);
            this.dbgUsuarios.TabIndex = 1;
            this.dbgUsuarios.Text = "c1TrueDBGrid1";
            this.dbgUsuarios.DoubleClick += new System.EventHandler(this.dbgUsuarios_DoubleClick);
            this.dbgUsuarios.PropBag = resources.GetString("dbgUsuarios.PropBag");
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
            this.toolStrip1.TabIndex = 13;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE USUARIOS";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuarios.Controls.Add(this.label1);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(850, 50);
            this.panelUsuarios.TabIndex = 12;
            this.panelUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUsuarios_MouseDown);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.dktUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dktUsuarios)).EndInit();
            this.dktUsuarios.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUsuario)).EndInit();
            this.tpListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Command.C1DockingTab dktUsuarios;
        private C1.Win.C1Command.C1DockingTabPage tpListaUsuarios;
        private C1.Win.C1Command.C1DockingTabPage tpUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRepitaPwd;
        private System.Windows.Forms.Label label14;
        private C1.Win.C1List.C1Combo cmbEstado;
        private C1.Win.C1List.C1Combo cmbPerfil;
        private C1.Win.C1List.C1Combo cmbTipoUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtFijo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid dbgUsuarios;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.CheckBox chkAutorizador;
        private System.Windows.Forms.Label lblAutorizador;
        private System.Windows.Forms.TextBox txtIdentificacion;

    }
}