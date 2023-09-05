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
    public partial class frmPagos : Form
    {
        double Salario = 0;
        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboRoles.SelectedIndex == -1)
                MessageBox.Show("Debes ingresar un producto antes registrado");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad valida");

            else
            {
                string cliente = txtCliente.Text;
                string producto = cboRoles.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string fecha = txtFecha.Text;

                double subtotal = cantidad * Salario;
                double total = subtotal;

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cliente.ToString());
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(fecha.ToString());
                fila.SubItems.Add(total.ToString());


                lvPagos.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Roles = cboRoles.Text;

            if (Roles.Equals("Administrador")) Salario = 1200;
            if (Roles.Equals("Bodeguero")) Salario = 1000;
            if (Roles.Equals("Cajero")) Salario = 800;

            lbSalario.Text = Salario.ToString("c");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmPagos_Load(object sender, EventArgs e)
        {

        }
    }
}
