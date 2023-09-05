using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class frmProductos : Form
    {
        double precio = 0;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debes ingresar un producto antes registrado");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad valida");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debes ingresar un tipo de stock");
            else if (cbLugar.SelectedIndex == -1)
                MessageBox.Show("Debes ingresar un tipo de venta");

            else
            {
                string producto = cboProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;
                string lugar = cbLugar.Text;

                double subtotal = cantidad * precio;
                double precioFinal = subtotal;

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo.ToString());
                fila.SubItems.Add(lugar.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);

            }
         }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            cboProductos.Items.Add(txtAggp.Text);
        }

        private void txtAggp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;

            if (producto.Equals("Mando PS4")) precio = 89;
            if (producto.Equals("Xbox")) precio = 400;
            if (producto.Equals("PlayStation 5")) precio = 1100;
            if (producto.Equals("Nintendo Swich")) precio = 399;

            lblPrecio.Text = precio.ToString("C");
        }
    }

}
