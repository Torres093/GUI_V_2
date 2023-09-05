namespace GUI_V_2
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVenta = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblSeleccionarProducto = new System.Windows.Forms.Label();
            this.lblMarcar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.cbLugar = new System.Windows.Forms.ComboBox();
            this.gbSellArea = new System.Windows.Forms.GroupBox();
            this.btnAgg1 = new System.Windows.Forms.Button();
            this.txtAggp = new System.Windows.Forms.TextBox();
            this.txtAggpr = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbAddNewProduct = new System.Windows.Forms.GroupBox();
            this.gbSellArea.SuspendLayout();
            this.gbAddNewProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(653, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 28);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Venta";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disponibilidad";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Precio Final";
            this.columnHeader6.Width = 79;
            // 
            // lvVenta
            // 
            this.lvVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVenta.HideSelection = false;
            this.lvVenta.Location = new System.Drawing.Point(80, 317);
            this.lvVenta.Name = "lvVenta";
            this.lvVenta.Size = new System.Drawing.Size(556, 77);
            this.lvVenta.TabIndex = 23;
            this.lvVenta.UseCompatibleStateImageBehavior = false;
            this.lvVenta.View = System.Windows.Forms.View.Details;
            this.lvVenta.SelectedIndexChanged += new System.EventHandler(this.lvVenta_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gray;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(163, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 33);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(80, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 33);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.cboProductos.Location = new System.Drawing.Point(21, 49);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(146, 28);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Disponible",
            "Agotado",
            "En camino"});
            this.cboTipo.Location = new System.Drawing.Point(21, 108);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(146, 28);
            this.cboTipo.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(214, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 23);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblSeleccionarProducto
            // 
            this.lblSeleccionarProducto.AutoSize = true;
            this.lblSeleccionarProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarProducto.Location = new System.Drawing.Point(17, 30);
            this.lblSeleccionarProducto.Name = "lblSeleccionarProducto";
            this.lblSeleccionarProducto.Size = new System.Drawing.Size(122, 16);
            this.lblSeleccionarProducto.TabIndex = 7;
            this.lblSeleccionarProducto.Text = "Seleccione producto";
            // 
            // lblMarcar
            // 
            this.lblMarcar.AutoSize = true;
            this.lblMarcar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcar.Location = new System.Drawing.Point(18, 89);
            this.lblMarcar.Name = "lblMarcar";
            this.lblMarcar.Size = new System.Drawing.Size(47, 16);
            this.lblMarcar.TabIndex = 8;
            this.lblMarcar.Text = "Marcar";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(210, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 16);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(396, 59);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 16);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "lblPrecio";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(211, 89);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(85, 16);
            this.lblTipoVenta.TabIndex = 12;
            this.lblTipoVenta.Text = "Tipo de venta";
            // 
            // cbLugar
            // 
            this.cbLugar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLugar.FormattingEnabled = true;
            this.cbLugar.Items.AddRange(new object[] {
            "Venta Fisica",
            "Venta En Linea"});
            this.cbLugar.Location = new System.Drawing.Point(213, 108);
            this.cbLugar.Name = "cbLugar";
            this.cbLugar.Size = new System.Drawing.Size(146, 28);
            this.cbLugar.TabIndex = 13;
            // 
            // gbSellArea
            // 
            this.gbSellArea.Controls.Add(this.cbLugar);
            this.gbSellArea.Controls.Add(this.lblTipoVenta);
            this.gbSellArea.Controls.Add(this.lblPrecio);
            this.gbSellArea.Controls.Add(this.label6);
            this.gbSellArea.Controls.Add(this.lblCantidad);
            this.gbSellArea.Controls.Add(this.lblMarcar);
            this.gbSellArea.Controls.Add(this.lblSeleccionarProducto);
            this.gbSellArea.Controls.Add(this.txtCantidad);
            this.gbSellArea.Controls.Add(this.cboTipo);
            this.gbSellArea.Controls.Add(this.cboProductos);
            this.gbSellArea.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSellArea.Location = new System.Drawing.Point(83, 128);
            this.gbSellArea.Name = "gbSellArea";
            this.gbSellArea.Size = new System.Drawing.Size(556, 144);
            this.gbSellArea.TabIndex = 19;
            this.gbSellArea.TabStop = false;
            this.gbSellArea.Text = "Area de ventas";
            // 
            // btnAgg1
            // 
            this.btnAgg1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgg1.Location = new System.Drawing.Point(462, 49);
            this.btnAgg1.Name = "btnAgg1";
            this.btnAgg1.Size = new System.Drawing.Size(88, 24);
            this.btnAgg1.TabIndex = 14;
            this.btnAgg1.Text = "Agregar ";
            this.btnAgg1.UseVisualStyleBackColor = true;
            this.btnAgg1.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // txtAggp
            // 
            this.txtAggp.Location = new System.Drawing.Point(20, 37);
            this.txtAggp.Name = "txtAggp";
            this.txtAggp.Size = new System.Drawing.Size(128, 22);
            this.txtAggp.TabIndex = 15;
            this.txtAggp.TextChanged += new System.EventHandler(this.txtAggp_TextChanged);
            // 
            // txtAggpr
            // 
            this.txtAggpr.Location = new System.Drawing.Point(186, 37);
            this.txtAggpr.Name = "txtAggpr";
            this.txtAggpr.Size = new System.Drawing.Size(127, 22);
            this.txtAggpr.TabIndex = 16;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(17, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(57, 16);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "Producto";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(183, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 16);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Precio";
            // 
            // gbAddNewProduct
            // 
            this.gbAddNewProduct.Controls.Add(this.lblPrice);
            this.gbAddNewProduct.Controls.Add(this.lblProducto);
            this.gbAddNewProduct.Controls.Add(this.txtAggpr);
            this.gbAddNewProduct.Controls.Add(this.txtAggp);
            this.gbAddNewProduct.Controls.Add(this.btnAgg1);
            this.gbAddNewProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddNewProduct.Location = new System.Drawing.Point(83, 42);
            this.gbAddNewProduct.Name = "gbAddNewProduct";
            this.gbAddNewProduct.Size = new System.Drawing.Size(556, 80);
            this.gbAddNewProduct.TabIndex = 25;
            this.gbAddNewProduct.TabStop = false;
            this.gbAddNewProduct.Text = "Agregar productos nuevos";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAddNewProduct);
            this.Controls.Add(this.gbSellArea);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.gbSellArea.ResumeLayout(false);
            this.gbSellArea.PerformLayout();
            this.gbAddNewProduct.ResumeLayout(false);
            this.gbAddNewProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvVenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblSeleccionarProducto;
        private System.Windows.Forms.Label lblMarcar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipoVenta;
        private System.Windows.Forms.ComboBox cbLugar;
        private System.Windows.Forms.GroupBox gbSellArea;
        private System.Windows.Forms.Button btnAgg1;
        private System.Windows.Forms.TextBox txtAggp;
        private System.Windows.Forms.TextBox txtAggpr;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbAddNewProduct;
    }
}