namespace GUI_V_2
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
            this.gbAddUsers = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgg = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gbAddUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddUsers
            // 
            this.gbAddUsers.Controls.Add(this.txtClave);
            this.gbAddUsers.Controls.Add(this.label2);
            this.gbAddUsers.Controls.Add(this.txtUsuario);
            this.gbAddUsers.Controls.Add(this.label1);
            this.gbAddUsers.Controls.Add(this.btnActualizar);
            this.gbAddUsers.Controls.Add(this.btnDelete);
            this.gbAddUsers.Controls.Add(this.btnAgg);
            this.gbAddUsers.Controls.Add(this.lblRol);
            this.gbAddUsers.Controls.Add(this.txtDUI);
            this.gbAddUsers.Controls.Add(this.cmbRol);
            this.gbAddUsers.Controls.Add(this.lblDui);
            this.gbAddUsers.Controls.Add(this.txtTelefono);
            this.gbAddUsers.Controls.Add(this.lblTel);
            this.gbAddUsers.Controls.Add(this.lblCorreo);
            this.gbAddUsers.Controls.Add(this.txtcorreo);
            this.gbAddUsers.Controls.Add(this.lblApellido);
            this.gbAddUsers.Controls.Add(this.lblNombre);
            this.gbAddUsers.Controls.Add(this.txtapellido);
            this.gbAddUsers.Controls.Add(this.txtnombre);
            this.gbAddUsers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddUsers.Location = new System.Drawing.Point(12, 39);
            this.gbAddUsers.Name = "gbAddUsers";
            this.gbAddUsers.Size = new System.Drawing.Size(737, 229);
            this.gbAddUsers.TabIndex = 39;
            this.gbAddUsers.TabStop = false;
            this.gbAddUsers.Text = "Agregar usuarios";
            this.gbAddUsers.Enter += new System.EventHandler(this.gbAddUsers_Enter);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(300, 103);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(119, 22);
            this.txtClave.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(300, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 22);
            this.txtUsuario.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuario";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(638, 89);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 49);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar Empleado";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(638, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 48);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Eliminar Empleado";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgg
            // 
            this.btnAgg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgg.FlatAppearance.BorderSize = 0;
            this.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgg.Location = new System.Drawing.Point(638, 23);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(93, 49);
            this.btnAgg.TabIndex = 41;
            this.btnAgg.Text = "Agregar Empleado";
            this.btnAgg.UseVisualStyleBackColor = false;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click_1);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(163, 158);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(25, 16);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(166, 108);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(108, 22);
            this.txtDUI.TabIndex = 26;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Admin",
            "Bodeguero",
            "Cajero"});
            this.cmbRol.Location = new System.Drawing.Point(166, 177);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(146, 28);
            this.cmbRol.TabIndex = 0;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.Location = new System.Drawing.Point(163, 89);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(27, 16);
            this.lblDui.TabIndex = 25;
            this.lblDui.Text = "DUI";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(13, 181);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 22);
            this.txtTelefono.TabIndex = 22;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(10, 162);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(57, 16);
            this.lblTel.TabIndex = 21;
            this.lblTel.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(163, 18);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(46, 16);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(166, 37);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(108, 22);
            this.txtcorreo.TabIndex = 18;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(10, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 16);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(13, 104);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(108, 22);
            this.txtapellido.TabIndex = 16;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 37);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(109, 22);
            this.txtnombre.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(681, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 28);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(316, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(109, 30);
            this.lblUsers.TabIndex = 44;
            this.lblUsers.Text = "Usuarios";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 288);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(653, 148);
            this.dgvEmpleados.TabIndex = 45;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.DoubleClick += new System.EventHandler(this.dgvEmpleados_DoubleClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.gbAddUsers);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.gbAddUsers.ResumeLayout(false);
            this.gbAddUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddUsers;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}