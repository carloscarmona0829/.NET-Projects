namespace libGuiPOS
{
    partial class frmLiquidar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiquidar));
            this.panelLiquidar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFacturar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDineroRecibido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panelLiquidar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLiquidar
            // 
            this.panelLiquidar.BackColor = System.Drawing.Color.SeaGreen;
            this.panelLiquidar.Controls.Add(this.label4);
            this.panelLiquidar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLiquidar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLiquidar.Location = new System.Drawing.Point(0, 0);
            this.panelLiquidar.Name = "panelLiquidar";
            this.panelLiquidar.Size = new System.Drawing.Size(500, 53);
            this.panelLiquidar.TabIndex = 22;
            this.panelLiquidar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLiquidar_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(119, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "LIQUIDAR RECIBOS DE CAJA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFacturar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 53);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 41);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbFacturar
            // 
            this.tsbFacturar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbFacturar.Image = global::libGuiPOS.Properties.Resources.green_address_book_icon48;
            this.tsbFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFacturar.Name = "tsbFacturar";
            this.tsbFacturar.Size = new System.Drawing.Size(88, 38);
            this.tsbFacturar.Text = "Facturar";
            this.tsbFacturar.Click += new System.EventHandler(this.tsbFacturar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dinero a Devolver";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalVenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDineroRecibido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(172, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 98);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVenta.Enabled = false;
            this.txtTotalVenta.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenta.Location = new System.Drawing.Point(169, 20);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(121, 24);
            this.txtTotalVenta.TabIndex = 33;
            this.txtTotalVenta.Text = "0";
            this.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Venta";
            // 
            // txtDineroRecibido
            // 
            this.txtDineroRecibido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDineroRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDineroRecibido.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDineroRecibido.Location = new System.Drawing.Point(169, 64);
            this.txtDineroRecibido.Name = "txtDineroRecibido";
            this.txtDineroRecibido.Size = new System.Drawing.Size(121, 24);
            this.txtDineroRecibido.TabIndex = 0;
            this.txtDineroRecibido.Text = "0";
            this.txtDineroRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDineroRecibido.TextChanged += new System.EventHandler(this.txtDineroRecibido_TextChanged);
            this.txtDineroRecibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDineroRecibido_KeyDown);
            this.txtDineroRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDineroRecibido_KeyPress);
            this.txtDineroRecibido.Validating += new System.ComponentModel.CancelEventHandler(this.txtDineroRecibido_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Dinero Recibido";
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDevuelta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevuelta.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevuelta.Location = new System.Drawing.Point(371, 229);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.Size = new System.Drawing.Size(106, 26);
            this.txtDevuelta.TabIndex = 34;
            this.txtDevuelta.Text = "0";
            this.txtDevuelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::libGuiPOS.Properties.Resources.Money_icon;
            this.pbLogin.Location = new System.Drawing.Point(26, 122);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(128, 128);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 30;
            this.pbLogin.TabStop = false;
            // 
            // frmLiquidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.Controls.Add(this.txtDevuelta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelLiquidar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLiquidar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLiquidar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLiquidar_Load);
            this.panelLiquidar.ResumeLayout(false);
            this.panelLiquidar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLiquidar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFacturar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTotalVenta;
        public System.Windows.Forms.TextBox txtDineroRecibido;
        public System.Windows.Forms.TextBox txtDevuelta;

    }
}