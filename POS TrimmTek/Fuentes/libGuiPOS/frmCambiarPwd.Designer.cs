namespace libGuiPOS
{
    partial class frmCambiarPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarPwd));
            this.panelCambiarPwd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtRepitaPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwdRecibida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelCambiarPwd.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCambiarPwd
            // 
            this.panelCambiarPwd.BackColor = System.Drawing.Color.SeaGreen;
            this.panelCambiarPwd.Controls.Add(this.label4);
            this.panelCambiarPwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCambiarPwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCambiarPwd.Location = new System.Drawing.Point(0, 0);
            this.panelCambiarPwd.Name = "panelCambiarPwd";
            this.panelCambiarPwd.Size = new System.Drawing.Size(626, 54);
            this.panelCambiarPwd.TabIndex = 22;
            this.panelCambiarPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCambiarPwd_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(197, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "CAMBIAR CONTRASEÑA";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtUsuario);
            this.gbDatos.Controls.Add(this.txtRepitaPwd);
            this.gbDatos.Controls.Add(this.txtPwd);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtPwdRecibida);
            this.gbDatos.Location = new System.Drawing.Point(58, 224);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(501, 154);
            this.gbDatos.TabIndex = 23;
            this.gbDatos.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(27, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(214, 22);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(261, 27);
            this.txtUsuario.TabIndex = 18;
            // 
            // txtRepitaPwd
            // 
            this.txtRepitaPwd.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaPwd.Location = new System.Drawing.Point(213, 121);
            this.txtRepitaPwd.Name = "txtRepitaPwd";
            this.txtRepitaPwd.PasswordChar = '*';
            this.txtRepitaPwd.Size = new System.Drawing.Size(262, 27);
            this.txtRepitaPwd.TabIndex = 17;
            this.txtRepitaPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRepitaPwd_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(213, 87);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(262, 27);
            this.txtPwd.TabIndex = 16;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(26, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Repita Contraseña ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(26, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nueva Contraseña ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña Recibida";
            // 
            // txtPwdRecibida
            // 
            this.txtPwdRecibida.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdRecibida.Location = new System.Drawing.Point(213, 55);
            this.txtPwdRecibida.Name = "txtPwdRecibida";
            this.txtPwdRecibida.Size = new System.Drawing.Size(262, 27);
            this.txtPwdRecibida.TabIndex = 12;
            this.txtPwdRecibida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwdRecibida_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Para iniciar sesión nuevamente, debe digitar la contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "que recibió en el correo electrónico, poner una nueva y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "posteriormente,confirmar la nueva contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Esta será la contraseña que usará de ahora en adelante.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(61, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 143);
            this.panel2.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::libGuiPOS.Properties.Resources.Cerrar_48x48;
            this.btnCancelar.Location = new System.Drawing.Point(185, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 48);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::libGuiPOS.Properties.Resources.accept_48x48;
            this.btnAceptar.Location = new System.Drawing.Point(388, 388);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(48, 48);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCambiarPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 447);
            this.Controls.Add(this.panelCambiarPwd);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambiarPwd";
            this.panelCambiarPwd.ResumeLayout(false);
            this.panelCambiarPwd.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCambiarPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwdRecibida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepitaPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}