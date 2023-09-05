using Modelos;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MSGerror(string msg)
        {
            lblErrorMessage.Text = "   " + msg;
            lblErrorMessage.Visible = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Username = txtuser.Text;
            u.Password = u.Encriptar(txtpass.Text);

            try
            {
                u = u.IniciarSesion();

                if (u == null)
                {
                    MessageBox.Show("Credenciales Invalidas");
                }

                else
                {
                    Menu ds = new Menu();
                    Hide();

                    ds.ShowDialog();

                    LimpiarCampos();
                    Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
                txtuser.UseSystemPasswordChar = false;
            }
        }

       

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Silver;
                txtuser.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtpass.Clear();
            txtuser.Clear();
        }
    }
}
