namespace libGuiPOS
{
    partial class frmRecuperarPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarPwd));
            this.panelRecuperarPwd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelRecuperarPwd.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecuperarPwd
            // 
            this.panelRecuperarPwd.BackColor = System.Drawing.Color.SeaGreen;
            this.panelRecuperarPwd.Controls.Add(this.label4);
            this.panelRecuperarPwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecuperarPwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRecuperarPwd.Location = new System.Drawing.Point(0, 0);
            this.panelRecuperarPwd.Name = "panelRecuperarPwd";
            this.panelRecuperarPwd.Size = new System.Drawing.Size(640, 54);
            this.panelRecuperarPwd.TabIndex = 7;
            this.panelRecuperarPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRecuperarPwd_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(187, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "RECUPERAR CONTRASEÑA";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtEmail);
            this.gbDatos.Location = new System.Drawing.Point(58, 281);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(501, 73);
            this.gbDatos.TabIndex = 11;
            this.gbDatos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo Electrónico:  ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(187, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "que le ayudarán a iniciar sesión nuevamente.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Posteriormente, recibira un correo electrónico con instrucciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "y presionar el botón Enviar.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Para recuperar su contraseña, debe digitar su correo electrónico";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(61, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 158);
            this.panel2.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::libGuiPOS.Properties.Resources.Cerrar_48x48;
            this.btnCancelar.Location = new System.Drawing.Point(185, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 48);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::libGuiPOS.Properties.Resources.Enviar_Email;
            this.btnEnviar.Location = new System.Drawing.Point(388, 380);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(48, 48);
            this.btnEnviar.TabIndex = 19;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmRecuperarPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelRecuperarPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecuperarPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS";
            this.panelRecuperarPwd.ResumeLayout(false);
            this.panelRecuperarPwd.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecuperarPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
    }
}