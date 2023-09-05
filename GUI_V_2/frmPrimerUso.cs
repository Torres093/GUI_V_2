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
    public partial class frmPrimerUso : Form
    {
        public frmPrimerUso()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Con este botón, primero se registra al usuario y luego al empleado
                //Es como hacer un INSERT doble

                //Se crea un objeto de tipo usuario y se le da valores a sus atributos
                Usuario u = new Usuario();
                u.Username = txtUsuario.Text;
                u.Id_Rol = 1; //El Rol 1 es Admin. Se pone directamente porque la ventana de primer uso es para crear un administrador.

                //Antes de enviar la clave, ésta pasa por el método Encriptar de la clase Usuario, el cual retorna un String que contiene la clave encriptada por SHA256
                u.Password = u.Encriptar(txtClave.Text);

                //Se crea el usuario. 
                u.Insertar();

                //Ahora se puede proceder a la creación del empleado. Se asignan valores a sus atributos.
                Empleado emp = new Empleado();

                emp.Nombre = txtNombre.Text;
                emp.Apellido = txtApellido.Text;
                emp.Dui = txtDui.Text;
                emp.Correo = txtCorreo.Text;
                emp.Telefono = txtTelefono.Text;
                emp.Username = txtUsuario.Text;

                //Ahora se procede a crear el empleado
                //El empleado depende del usuario, por lo que el usuario debe crearse antes que el empleado
                emp.Insertar();

                //Si todo salió bien, el mensaje de éxito se mostrará
                MessageBox.Show("El usuario ha sido creado con éxito. El programa se reiniciará para que los cambios surtan efecto",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //El programa se reinicia para mostrarle al usuario el inicio de sesión directamente
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
