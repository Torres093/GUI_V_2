using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_V_2
{
    public partial class frmCajero : Form
    {
        public frmCajero()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            try
            {
                double Cantidad = Convert.ToDouble(txtCant.Text);
                string descripción = txtDescripcion.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);
                double total = Cantidad * precio;
                dgvVentas.Rows.Add(descripción, Cantidad, precio, total);
            }
            catch
            {
                MessageBox.Show("Error al ingresar los datos");
            }
            finally
            {

                txtPrecio.Clear();
                txtDescripcion.Focus();
                txtCant.Clear();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.Clear();
            btnEnd.Enabled = true;
            btnRemove.Enabled = true;
            btnAgg.Enabled = true;

            txtCant.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }






        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int posicion = dgvVentas.CurrentRow.Index;
                dgvVentas.Rows.RemoveAt(posicion);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            int x;
            double sub = 0;
            int cantrenglones = dgvVentas.Rows.Count;       

            if (cantrenglones == 0)
            {
                MessageBox.Show("No hay artículos para comprar");
                return;
            }
            for (x = 0; x <= cantrenglones - 1; x++)
            {
                sub = sub + Convert.ToDouble(dgvVentas[3, x].Value);

            }
            double iva = sub * 0.16;
            double total = sub * iva;
            dgvVentas.Rows.Add("", "", "TOTAL:", sub);
            dgvVentas.Rows.Add("", "", "TOTAL:", total);
            btnEnd.Enabled = false;
            btnRemove.Enabled = false;
            btnAgg.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmlogin logg = new frmlogin();
            logg.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cajero_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }
    }
}
