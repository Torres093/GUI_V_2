namespace GUI_V_2
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPaymentArea = new System.Windows.Forms.GroupBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvPagos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPagos = new System.Windows.Forms.Label();
            this.gbPaymentArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(79, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 42);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbPaymentArea
            // 
            this.gbPaymentArea.Controls.Add(this.lblHoras);
            this.gbPaymentArea.Controls.Add(this.txtHoras);
            this.gbPaymentArea.Controls.Add(this.lblDescuento);
            this.gbPaymentArea.Controls.Add(this.txtDescuento);
            this.gbPaymentArea.Controls.Add(this.txtFecha);
            this.gbPaymentArea.Controls.Add(this.lblCliente);
            this.gbPaymentArea.Controls.Add(this.txtCliente);
            this.gbPaymentArea.Controls.Add(this.lbSalario);
            this.gbPaymentArea.Controls.Add(this.lblCantidad);
            this.gbPaymentArea.Controls.Add(this.lblFecha);
            this.gbPaymentArea.Controls.Add(this.lblRol);
            this.gbPaymentArea.Controls.Add(this.txtCantidad);
            this.gbPaymentArea.Controls.Add(this.cboRoles);
            this.gbPaymentArea.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentArea.Location = new System.Drawing.Point(58, 81);
            this.gbPaymentArea.Name = "gbPaymentArea";
            this.gbPaymentArea.Size = new System.Drawing.Size(688, 161);
            this.gbPaymentArea.TabIndex = 27;
            this.gbPaymentArea.TabStop = false;
            this.gbPaymentArea.Text = "Área de pagos";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(535, 85);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(125, 16);
            this.lblHoras.TabIndex = 23;
            this.lblHoras.Text = "Total De Horas Extra";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(537, 117);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(133, 23);
            this.txtHoras.TabIndex = 24;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(411, 85);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(66, 16);
            this.lblDescuento.TabIndex = 22;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(389, 117);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(103, 23);
            this.txtDescuento.TabIndex = 25;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(184, 117);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(145, 23);
            this.txtFecha.TabIndex = 16;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(17, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 16);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(21, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(145, 23);
            this.txtCliente.TabIndex = 12;
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.Location = new System.Drawing.Point(609, 19);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(51, 16);
            this.lbSalario.TabIndex = 11;
            this.lbSalario.Text = "Salario";
            this.lbSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(18, 97);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 16);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(181, 98);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 16);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(181, 28);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(25, 16);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(22, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 23);
            this.txtCantidad.TabIndex = 2;
            // 
            // cboRoles
            // 
            this.cboRoles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "Administrador",
            "Bodeguero",
            "Cajero"});
            this.cboRoles.Location = new System.Drawing.Point(184, 47);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(146, 28);
            this.cboRoles.TabIndex = 0;
            this.cboRoles.SelectedIndexChanged += new System.EventHandler(this.cboRoles_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gray;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(216, 248);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 42);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Añadir Planilla";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvPagos
            // 
            this.lvPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPagos.HideSelection = false;
            this.lvPagos.Location = new System.Drawing.Point(119, 313);
            this.lvPagos.Name = "lvPagos";
            this.lvPagos.Size = new System.Drawing.Size(557, 77);
            this.lvPagos.TabIndex = 24;
            this.lvPagos.UseCompatibleStateImageBehavior = false;
            this.lvPagos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rol";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salario";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descuento";
            this.columnHeader7.Width = 78;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(368, 9);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(85, 30);
            this.lblPagos.TabIndex = 45;
            this.lblPagos.Text = "Pagos";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbPaymentArea);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.gbPaymentArea.ResumeLayout(false);
            this.gbPaymentArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbPaymentArea;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvPagos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblPagos;
    }
}