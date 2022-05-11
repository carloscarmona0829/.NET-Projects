namespace libGuiPOS
{
    partial class MdiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsbMaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCierre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentasProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCasas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeaderRight = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpHeaderRight.SuspendLayout();
            this.tlpUsuario.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMaestros,
            this.tsbInventario,
            this.tsbFacturacion,
            this.tsbCierre,
            this.tsbNomina,
            this.tsbConsultas,
            this.tsbRegistros});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1270, 48);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // tsbMaestros
            // 
            this.tsbMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModulos,
            this.tsmPerfiles,
            this.tsmPermisos,
            this.tsmProductos,
            this.tsmUsuarios,
            this.tsmProveedores});
            this.tsbMaestros.Image = global::libGuiPOS.Properties.Resources.Library_icon72;
            this.tsbMaestros.Name = "tsbMaestros";
            this.tsbMaestros.Size = new System.Drawing.Size(107, 44);
            this.tsbMaestros.Text = "&Maestros";
            this.tsbMaestros.Visible = false;
            // 
            // tsmModulos
            // 
            this.tsmModulos.Name = "tsmModulos";
            this.tsmModulos.Size = new System.Drawing.Size(152, 22);
            this.tsmModulos.Text = "&Modulos";
            this.tsmModulos.Visible = false;
            this.tsmModulos.Click += new System.EventHandler(this.tsmModulos_Click);
            // 
            // tsmPerfiles
            // 
            this.tsmPerfiles.Name = "tsmPerfiles";
            this.tsmPerfiles.Size = new System.Drawing.Size(152, 22);
            this.tsmPerfiles.Text = "&Perfiles";
            this.tsmPerfiles.Visible = false;
            this.tsmPerfiles.Click += new System.EventHandler(this.tsmPerfiles_Click);
            // 
            // tsmPermisos
            // 
            this.tsmPermisos.Name = "tsmPermisos";
            this.tsmPermisos.Size = new System.Drawing.Size(152, 22);
            this.tsmPermisos.Text = "P&ermisos";
            this.tsmPermisos.Visible = false;
            this.tsmPermisos.Click += new System.EventHandler(this.tsmPermisos_Click);
            // 
            // tsmProductos
            // 
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(152, 22);
            this.tsmProductos.Text = "P&roductos";
            this.tsmProductos.Visible = false;
            this.tsmProductos.Click += new System.EventHandler(this.tsmProductos_Click);
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(152, 22);
            this.tsmUsuarios.Text = "&Usuarios";
            this.tsmUsuarios.Visible = false;
            this.tsmUsuarios.Click += new System.EventHandler(this.tsmUsuarios_Click);
            // 
            // tsmProveedores
            // 
            this.tsmProveedores.Name = "tsmProveedores";
            this.tsmProveedores.Size = new System.Drawing.Size(152, 22);
            this.tsmProveedores.Text = "&Proveedores";
            this.tsmProveedores.Visible = false;
            this.tsmProveedores.Click += new System.EventHandler(this.tsmProveedores_Click);
            // 
            // tsbInventario
            // 
            this.tsbInventario.Image = global::libGuiPOS.Properties.Resources.Inventario72_icon;
            this.tsbInventario.Name = "tsbInventario";
            this.tsbInventario.Size = new System.Drawing.Size(112, 44);
            this.tsbInventario.Text = "&Inventario";
            this.tsbInventario.Visible = false;
            this.tsbInventario.Click += new System.EventHandler(this.tsbInventario_Click);
            // 
            // tsbFacturacion
            // 
            this.tsbFacturacion.Image = global::libGuiPOS.Properties.Resources.Documents_icon72;
            this.tsbFacturacion.Name = "tsbFacturacion";
            this.tsbFacturacion.Size = new System.Drawing.Size(121, 44);
            this.tsbFacturacion.Text = "&Facturación";
            this.tsbFacturacion.Visible = false;
            this.tsbFacturacion.Click += new System.EventHandler(this.tsbFacturacion_Click);
            // 
            // tsbCierre
            // 
            this.tsbCierre.Image = global::libGuiPOS.Properties.Resources.Cierre721;
            this.tsbCierre.Name = "tsbCierre";
            this.tsbCierre.Size = new System.Drawing.Size(90, 44);
            this.tsbCierre.Text = "&Cierre";
            this.tsbCierre.Visible = false;
            this.tsbCierre.Click += new System.EventHandler(this.tsCierre_Click);
            // 
            // tsbNomina
            // 
            this.tsbNomina.Image = global::libGuiPOS.Properties.Resources.Nómina_copia2;
            this.tsbNomina.Name = "tsbNomina";
            this.tsbNomina.Size = new System.Drawing.Size(102, 44);
            this.tsbNomina.Text = "&Nómina";
            this.tsbNomina.Visible = false;
            this.tsbNomina.Click += new System.EventHandler(this.tsNomina_Click);
            // 
            // tsbConsultas
            // 
            this.tsbConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTurnos,
            this.tsmVentasProductos});
            this.tsbConsultas.Image = global::libGuiPOS.Properties.Resources.Consultas72;
            this.tsbConsultas.Name = "tsbConsultas";
            this.tsbConsultas.Size = new System.Drawing.Size(111, 44);
            this.tsbConsultas.Text = "&Consultas";
            this.tsbConsultas.Visible = false;
            // 
            // tsmTurnos
            // 
            this.tsmTurnos.Name = "tsmTurnos";
            this.tsmTurnos.Size = new System.Drawing.Size(111, 22);
            this.tsmTurnos.Text = "&Turnos";
            this.tsmTurnos.Visible = false;
            this.tsmTurnos.Click += new System.EventHandler(this.tsmTurnos_Click);
            // 
            // tsmVentasProductos
            // 
            this.tsmVentasProductos.Name = "tsmVentasProductos";
            this.tsmVentasProductos.Size = new System.Drawing.Size(111, 22);
            this.tsmVentasProductos.Text = "Ventas";
            this.tsmVentasProductos.Visible = false;
            this.tsmVentasProductos.Click += new System.EventHandler(this.tsmventasProductos_Click);
            // 
            // tsbRegistros
            // 
            this.tsbRegistros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonas,
            this.tsmCasas,
            this.tsmRegistro});
            this.tsbRegistros.Image = global::libGuiPOS.Properties.Resources.Documents_icon;
            this.tsbRegistros.Name = "tsbRegistros";
            this.tsbRegistros.Size = new System.Drawing.Size(107, 44);
            this.tsbRegistros.Text = "Registros";
            this.tsbRegistros.Visible = false;
            // 
            // tsmPersonas
            // 
            this.tsmPersonas.Name = "tsmPersonas";
            this.tsmPersonas.Size = new System.Drawing.Size(121, 22);
            this.tsmPersonas.Text = "Personas";
            this.tsmPersonas.Visible = false;
            this.tsmPersonas.Click += new System.EventHandler(this.tsmPersonas_Click);
            // 
            // tsmCasas
            // 
            this.tsmCasas.Name = "tsmCasas";
            this.tsmCasas.Size = new System.Drawing.Size(121, 22);
            this.tsmCasas.Text = "Casas";
            this.tsmCasas.Visible = false;
            this.tsmCasas.Click += new System.EventHandler(this.tsmCasas_Click);
            // 
            // tsmRegistro
            // 
            this.tsmRegistro.Name = "tsmRegistro";
            this.tsmRegistro.Size = new System.Drawing.Size(121, 22);
            this.tsmRegistro.Text = "Registro";
            this.tsmRegistro.Visible = false;
            this.tsmRegistro.Click += new System.EventHandler(this.tsmRegistro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tlpHeaderRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpHeader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tlpHeaderRight
            // 
            this.tlpHeaderRight.ColumnCount = 1;
            this.tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderRight.Controls.Add(this.tlpUsuario, 0, 1);
            this.tlpHeaderRight.Controls.Add(this.tlpBotones, 0, 0);
            this.tlpHeaderRight.Location = new System.Drawing.Point(1045, 3);
            this.tlpHeaderRight.Name = "tlpHeaderRight";
            this.tlpHeaderRight.RowCount = 2;
            this.tlpHeaderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpHeaderRight.Size = new System.Drawing.Size(218, 94);
            this.tlpHeaderRight.TabIndex = 1;
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpUsuario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpUsuario.ColumnCount = 1;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuario.Controls.Add(this.lblCerrarSesion, 0, 1);
            this.tlpUsuario.Controls.Add(this.lblUsuarioLogueado, 0, 0);
            this.tlpUsuario.Location = new System.Drawing.Point(3, 50);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 2;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsuario.Size = new System.Drawing.Size(212, 41);
            this.tlpUsuario.TabIndex = 10;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCerrarSesion.Location = new System.Drawing.Point(54, 22);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(103, 16);
            this.lblCerrarSesion.TabIndex = 8;
            this.lblCerrarSesion.Text = "Cerrar Sesión";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            this.lblCerrarSesion.MouseEnter += new System.EventHandler(this.lblCerrarSesion_MouseEnter);
            this.lblCerrarSesion.MouseLeave += new System.EventHandler(this.lblCerrarSesion_MouseLeave);
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(5, 2);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(136, 16);
            this.lblUsuarioLogueado.TabIndex = 7;
            this.lblUsuarioLogueado.Text = "Usuario Logueado";
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.68674F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31325F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpBotones.Controls.Add(this.label2, 0, 0);
            this.tlpBotones.Controls.Add(this.btnSalir, 2, 0);
            this.tlpBotones.Controls.Add(this.btnMinimizar, 1, 0);
            this.tlpBotones.Location = new System.Drawing.Point(3, 3);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpBotones.Size = new System.Drawing.Size(212, 41);
            this.tlpBotones.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido(a):";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::libGuiPOS.Properties.Resources.cerrar;
            this.btnSalir.Location = new System.Drawing.Point(169, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseCompatibleTextRendering = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::libGuiPOS.Properties.Resources.blue_ok_icon;
            this.btnMinimizar.Location = new System.Drawing.Point(122, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(41, 35);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.10039F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.89961F));
            this.tlpHeader.Controls.Add(this.pbBanner, 1, 1);
            this.tlpHeader.Controls.Add(this.pbLogo, 0, 1);
            this.tlpHeader.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 2;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHeader.Size = new System.Drawing.Size(1036, 94);
            this.tlpHeader.TabIndex = 0;
            // 
            // pbBanner
            // 
            this.pbBanner.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pbBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBanner.Location = new System.Drawing.Point(118, 3);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(915, 88);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 6;
            this.pbBanner.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(109, 88);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 1);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libGuiPOS.Properties.Resources.Fondo_tt_new_copia2;
            this.ClientSize = new System.Drawing.Size(1270, 465);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpHeaderRight.ResumeLayout(false);
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsbMaestros;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmPerfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsmModulos;
        private System.Windows.Forms.ToolStripMenuItem tsbFacturacion;
        private System.Windows.Forms.ToolStripMenuItem tsmProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeaderRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        public System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripMenuItem tsbCierre;
        private System.Windows.Forms.ToolStripMenuItem tsbConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsmTurnos;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsbNomina;
        private System.Windows.Forms.ToolStripMenuItem tsmVentasProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmProveedores;
        private System.Windows.Forms.ToolStripMenuItem tsbInventario;
        private System.Windows.Forms.ToolStripMenuItem tsbRegistros;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmCasas;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistro;
    }
}