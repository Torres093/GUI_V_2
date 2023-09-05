namespace GUI_V_2
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MnMenuVertical = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.frmMenu = new System.Windows.Forms.Panel();
            this.MnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.frmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnMenuVertical
            // 
            this.MnMenuVertical.BackColor = System.Drawing.Color.Black;
            this.MnMenuVertical.Controls.Add(this.btnLogOut);
            this.MnMenuVertical.Controls.Add(this.btnusuarios);
            this.MnMenuVertical.Controls.Add(this.btncompras);
            this.MnMenuVertical.Controls.Add(this.btnclientes);
            this.MnMenuVertical.Controls.Add(this.btnventas);
            this.MnMenuVertical.Controls.Add(this.btnproductos);
            this.MnMenuVertical.Controls.Add(this.pbLogo);
            this.MnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MnMenuVertical.Name = "MnMenuVertical";
            this.MnMenuVertical.Size = new System.Drawing.Size(250, 498);
            this.MnMenuVertical.TabIndex = 0;
            this.MnMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            this.MnMenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 455);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 40);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnusuarios.Image")));
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(3, 319);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(250, 40);
            this.btnusuarios.TabIndex = 6;
            this.btnusuarios.Text = "Pagos";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btncompras
            // 
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.Color.White;
            this.btncompras.Image = ((System.Drawing.Image)(resources.GetObject("btncompras.Image")));
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(-3, 269);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(250, 40);
            this.btncompras.TabIndex = 5;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 223);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(250, 40);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "Empleados";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnventas
            // 
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(0, 176);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(250, 40);
            this.btnventas.TabIndex = 2;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.Color.White;
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(0, 129);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(250, 40);
            this.btnproductos.TabIndex = 1;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::GUI_V_2.Properties.Resources.WhatsApp_Image_2023_07_26_at_10_091;
            this.pbLogo.Location = new System.Drawing.Point(-244, -41);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(640, 198);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DimGray;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(774, 45);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(721, 5);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(745, 5);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(8, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(285, 171);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(96, 33);
            this.lblfecha.TabIndex = 17;
            this.lblfecha.Text = "label2";
            // 
            // frmMenu
            // 
            this.frmMenu.BackColor = System.Drawing.Color.Gray;
            this.frmMenu.Controls.Add(this.lblfecha);
            this.frmMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMenu.Location = new System.Drawing.Point(250, 45);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(774, 453);
            this.frmMenu.TabIndex = 3;
            this.frmMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.frmMenu);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MnMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MnMenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Panel frmMenu;
    }
}

