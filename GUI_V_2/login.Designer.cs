namespace GUI_V_2
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lnlContraseñaOlvidada = new System.Windows.Forms.LinkLabel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-29, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 330);
            this.panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::GUI_V_2.Properties.Resources.WhatsApp_Image_2023_07_26_at_10_09_45_PM__1_;
            this.pbLogo.Location = new System.Drawing.Point(18, -37);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(294, 377);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(453, 21);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(72, 22);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.DimGray;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtuser.Location = new System.Drawing.Point(313, 94);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(352, 26);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcceder.Location = new System.Drawing.Point(313, 239);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(352, 30);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.DimGray;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtpass.Location = new System.Drawing.Point(313, 156);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(352, 26);
            this.txtpass.TabIndex = 5;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // lnlContraseñaOlvidada
            // 
            this.lnlContraseñaOlvidada.AutoSize = true;
            this.lnlContraseñaOlvidada.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lnlContraseñaOlvidada.LinkColor = System.Drawing.Color.Gray;
            this.lnlContraseñaOlvidada.Location = new System.Drawing.Point(393, 273);
            this.lnlContraseñaOlvidada.Name = "lnlContraseñaOlvidada";
            this.lnlContraseñaOlvidada.Size = new System.Drawing.Size(196, 17);
            this.lnlContraseñaOlvidada.TabIndex = 6;
            this.lnlContraseñaOlvidada.TabStop = true;
            this.lnlContraseñaOlvidada.Text = "Has olvidado tu contraseña?";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(310, 207);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(88, 16);
            this.lblErrorMessage.TabIndex = 11;
            this.lblErrorMessage.Text = "Error Messaage";
            this.lblErrorMessage.Visible = false;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(666, 0);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(18, 20);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 8;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbSalir
            // 
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(678, 0);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(34, 20);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalir.TabIndex = 7;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(706, 302);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.lnlContraseñaOlvidada);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Beige;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.LinkLabel lnlContraseñaOlvidada;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}