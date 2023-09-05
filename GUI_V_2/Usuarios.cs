using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using System.Data.SqlClient;

namespace GUI_V_2
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {

        }

        private void CargarRoles()
        {
            try
            {
                cmbRol.DataSource = null;
                cmbRol.DataSource = Rol.Cargar();
                cmbRol.ValueMember = "id_Rol";
                cmbRol.DisplayMember = "nombreRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
               dgvEmpleados.DataSource = null;
               dgvEmpleados.DataSource = Empleado.Cargar();

                dgvEmpleados.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarRoles();
        }

        private void btnAgg_Click_1(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Username = txtUsuario.Text;
            u.Id_Rol = (int)cmbRol.SelectedIndex;
            u.Password = u.Encriptar(txtClave.Text);
            u.Insertar();

            Empleado emp = new Empleado();

            emp.Nombre = txtnombre.Text;
            emp.Apellido = txtapellido.Text;
            emp.Correo = txtcorreo.Text;
            emp.Dui = txtDUI.Text;
            emp.Telefono = txtTelefono.Text;
            emp.Username = txtUsuario.Text;
            emp.Insertar();

            CargarEmpleados();
            CargarRoles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = (int)dgvEmpleados.CurrentRow.Cells[0].Value;
                string username = (string)dgvEmpleados.CurrentRow.Cells[3].Value;

                Empleado emp = new Empleado();
                emp.Id_Empleado = idEmpleado;
                emp.Eliminar();

                Usuario u = new Usuario();
                u.Username = username;
                u.Eliminar();

                CargarEmpleados();
                CargarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void gbAddUsers_Enter(object sender, EventArgs e)
        {

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = (int)dgvEmpleados.CurrentRow.Cells[0].Value;
                string usernameOriginal = (string)dgvEmpleados.CurrentRow.Cells[3].Value;

                Usuario u = new Usuario();
                u.Username = txtUsuario.Text;
                u.Password = u.Encriptar(txtClave.Text);
                u.Id_Rol = (int)cmbRol.SelectedValue;
                u.Actualizar(usernameOriginal);

                Empleado emp = new Empleado();
                emp.Id_Empleado = idEmpleado;
                emp.Nombre = txtnombre.Text;
                emp.Apellido = txtapellido.Text;
                emp.Dui = txtDUI.Text;
                emp.Correo = txtcorreo.Text;
                emp.Telefono = txtTelefono.Text;
                emp.Username = txtUsuario.Text;
                emp.Actualizar();

                CargarEmpleados();
                CargarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string nombre = (string)dgvEmpleados.CurrentRow.Cells[1].Value;
                string apellido = (string)dgvEmpleados.CurrentRow.Cells[2].Value;
                string correo = (string)dgvEmpleados.CurrentRow.Cells[3].Value;
                string dui = (string)dgvEmpleados.CurrentRow.Cells[4].Value;
                string telefono = (string)dgvEmpleados.CurrentRow.Cells[5].Value;
                string usuario = (string)dgvEmpleados.CurrentRow.Cells[6].Value;
                int tipoUsuario = (int)dgvEmpleados.CurrentRow.Cells[7].Value;

                txtnombre.Text = nombre;
                txtapellido.Text = apellido;
                txtcorreo.Text = correo;
                txtDUI.Text = dui;
                txtTelefono.Text = telefono;
                txtUsuario.Text = usuario;
                cmbRol.SelectedValue = tipoUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
