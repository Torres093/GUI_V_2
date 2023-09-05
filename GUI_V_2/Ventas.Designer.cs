namespace GUI_V_2
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.gbRegisterSells = new System.Windows.Forms.GroupBox();
            this.btnDeleteRegister = new System.Windows.Forms.Button();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAggpr = new System.Windows.Forms.TextBox();
            this.lvVenta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRegister = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRegisterSells.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegisterSells
            // 
            this.gbRegisterSells.Controls.Add(this.btnDeleteRegister);
            this.gbRegisterSells.Controls.Add(this.btnAddRegister);
            this.gbRegisterSells.Controls.Add(this.cboProductos);
            this.gbRegisterSells.Controls.Add(this.lblEmpresa);
            this.gbRegisterSells.Controls.Add(this.txtEmpresa);
            this.gbRegisterSells.Controls.Add(this.cbMetodoPago);
            this.gbRegisterSells.Controls.Add(this.label1);
            this.gbRegisterSells.Controls.Add(this.label10);
            this.gbRegisterSells.Controls.Add(this.label9);
            this.gbRegisterSells.Controls.Add(this.txtAggpr);
            this.gbRegisterSells.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegisterSells.Location = new System.Drawing.Point(136, 61);
            this.gbRegisterSells.Name = "gbRegisterSells";
            this.gbRegisterSells.Size = new System.Drawing.Size(470, 156);
            this.gbRegisterSells.TabIndex = 21;
            this.gbRegisterSells.TabStop = false;
            this.gbRegisterSells.Text = "registrar ventas";
            // 
            // btnDeleteRegister
            // 
            this.btnDeleteRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteRegister.FlatAppearance.BorderSize = 0;
            this.btnDeleteRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRegister.Location = new System.Drawing.Point(202, 103);
            this.btnDeleteRegister.Name = "btnDeleteRegister";
            this.btnDeleteRegister.Size = new System.Drawing.Size(121, 42);
            this.btnDeleteRegister.TabIndex = 27;
            this.btnDeleteRegister.Text = "Borrar Registro";
            this.btnDeleteRegister.UseVisualStyleBackColor = false;
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddRegister.FlatAppearance.BorderSize = 0;
            this.btnAddRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRegister.Location = new System.Drawing.Point(329, 103);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(121, 42);
            this.btnAddRegister.TabIndex = 25;
            this.btnAddRegister.Text = "Agregar Registro";
            this.btnAddRegister.UseVisualStyleBackColor = false;
            this.btnAddRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Items.AddRange(new object[] {
            "Mando PS4",
            "Xbox",
            "PlayStation 5",
            "Nintendo Swich"});
            this.cboProductos.Location = new System.Drawing.Point(20, 34);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(130, 28);
            this.cboProductos.TabIndex = 24;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(20, 84);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(57, 16);
            this.lblEmpresa.TabIndex = 23;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(23, 103);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(127, 22);
            this.txtEmpresa.TabIndex = 22;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "credito"});
            this.cbMetodoPago.Location = new System.Drawing.Point(329, 38);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(121, 22);
            this.cbMetodoPago.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = " Metodo de pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Producto";
            // 
            // txtAggpr
            // 
            this.txtAggpr.Location = new System.Drawing.Point(172, 37);
            this.txtAggpr.Name = "txtAggpr";
            this.txtAggpr.Size = new System.Drawing.Size(127, 22);
            this.txtAggpr.TabIndex = 16;
            // 
            // lvVenta
            // 
            this.lvVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVenta.HideSelection = false;
            this.lvVenta.Location = new System.Drawing.Point(118, 271);
            this.lvVenta.Name = "lvVenta";
            this.lvVenta.Size = new System.Drawing.Size(525, 126);
            this.lvVenta.TabIndex = 20;
            this.lvVenta.UseCompatibleStateImageBehavior = false;
            this.lvVenta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Metodo de Pago";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Empresa";
            this.columnHeader4.Width = 93;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(260, 9);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(258, 30);
            this.lblRegister.TabIndex = 19;
            this.lblRegister.Text = "Registro de compras";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subtotal";
            this.columnHeader5.Width = 76;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.gbRegisterSells);
            this.Controls.Add(this.lvVenta);
            this.Controls.Add(this.lblRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.gbRegisterSells.ResumeLayout(false);
            this.gbRegisterSells.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegisterSells;
        private System.Windows.Forms.Button btnDeleteRegister;
        private System.Windows.Forms.Button btnAddRegister;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAggpr;
        private System.Windows.Forms.ListView lvVenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}