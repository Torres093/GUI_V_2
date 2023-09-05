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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MnMenuVertical.Width == 250)
            {
                MnMenuVertical.Width = 70;
            }
            else
                MnMenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
     
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
          
            
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
         
            if (this.frmMenu.Controls.Count > 0)
            {
                this.frmMenu.Controls.RemoveAt(0);

                Form p = new frmProductos();
                p.TopLevel = false;
                p.Dock = DockStyle.Fill;
                this.frmMenu.Controls.Add(p);
                this.frmMenu.Tag = p;
                p.Show();
            }


        }
       
        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongDateString();
          
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            if (this.frmMenu.Controls.Count > 0)
            {
                this.frmMenu.Controls.RemoveAt(0);

                Form v = new frmVentas();
                v.TopLevel = false;
                v.Dock = DockStyle.Fill;
                this.frmMenu.Controls.Add(v);
                this.frmMenu.Tag = v;
                v.Show();
            }

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {

            if (this.frmMenu.Controls.Count > 0)
            {
                this.frmMenu.Controls.RemoveAt(0);

                Form u = new frmUsuarios();
                u.TopLevel = false;
                u.Dock = DockStyle.Fill;
                this.frmMenu.Controls.Add(u);
                this.frmMenu.Tag = u;
                u.Show();
            }


        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (this.frmMenu.Controls.Count > 0)
            {
                this.frmMenu.Controls.RemoveAt(0);

                Form p = new frmPagos();
                p.TopLevel = false;
                p.Dock = DockStyle.Fill;
                this.frmMenu.Controls.Add(p);
                this.frmMenu.Tag = p;
                p.Show();
            }
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            if (this.frmMenu.Controls.Count > 0)
            {
                this.frmMenu.Controls.RemoveAt(0);

                Form c = new frmCompras();
                c.TopLevel = false;
                c.Dock = DockStyle.Fill;
                this.frmMenu.Controls.Add(c);
                this.frmMenu.Tag = c;
                c.Show();
            }
        }

        private void lbllog_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin log = new frmlogin();
            log.Show();
            this.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
