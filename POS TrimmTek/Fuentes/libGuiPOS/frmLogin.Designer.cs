namespace libGuiPOS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblRecuperarPwd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificarCadenaConexion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(386, 67);
            this.panelLogin.TabIndex = 6;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "AUTENTICACIÓN DE USUARIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(105, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña: ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(102, 54);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(159, 20);
            this.txtPwd.TabIndex = 12;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 20);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario: ";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(84, 383);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(84, 20);
            this.lblMensaje.TabIndex = 14;
            this.lblMensaje.Text = "lblMensaje";
            this.lblMensaje.Visible = false;
            // 
            // lblRecuperarPwd
            // 
            this.lblRecuperarPwd.AutoSize = true;
            this.lblRecuperarPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarPwd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRecuperarPwd.Location = new System.Drawing.Point(144, 414);
            this.lblRecuperarPwd.Name = "lblRecuperarPwd";
            this.lblRecuperarPwd.Size = new System.Drawing.Size(103, 13);
            this.lblRecuperarPwd.TabIndex = 20;
            this.lblRecuperarPwd.Text = "lblRecuperarPwd";
            this.lblRecuperarPwd.Visible = false;
            this.lblRecuperarPwd.Click += new System.EventHandler(this.lblRecuperarPwd_Click);
            this.lblRecuperarPwd.MouseEnter += new System.EventHandler(this.lblRecuperarPwd_MouseEnter);
            this.lblRecuperarPwd.MouseLeave += new System.EventHandler(this.lblRecuperarPwd_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(78, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bienvenido al Sistema ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Iniciar sesión para continuar";
            // 
            // btnVerificarCadenaConexion
            // 
            this.btnVerificarCadenaConexion.Location = new System.Drawing.Point(15, 345);
            this.btnVerificarCadenaConexion.Name = "btnVerificarCadenaConexion";
            this.btnVerificarCadenaConexion.Size = new System.Drawing.Size(157, 23);
            this.btnVerificarCadenaConexion.TabIndex = 21;
            this.btnVerificarCadenaConexion.Text = "Verificar Cadena Conexión";
            this.btnVerificarCadenaConexion.UseVisualStyleBackColor = true;
            this.btnVerificarCadenaConexion.Visible = false;
            this.btnVerificarCadenaConexion.Click += new System.EventHandler(this.btnVerificarCadenaConexion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::libGuiPOS.Properties.Resources.cerrar;
            this.btnCancelar.Location = new System.Drawing.Point(268, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(34, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::libGuiPOS.Properties.Resources.accept_ok;
            this.btnAceptar.Location = new System.Drawing.Point(186, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(34, 34);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::libGuiPOS.Properties.Resources.imgLogin;
            this.pbLogin.Location = new System.Drawing.Point(7, 223);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(96, 96);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogin.TabIndex = 4;
            this.pbLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 447);
            this.Controls.Add(this.btnVerificarCadenaConexion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecuperarPwd);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificarCadenaConexion;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.Label lblRecuperarPwd;
        public System.Windows.Forms.TextBox txtPwd;
    }
}