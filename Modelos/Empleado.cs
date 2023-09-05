using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Modelos
{
    public class Empleado
    {
        private int id_Empleado;
        private string nombre;
        private string apellido;
        private string correo;
        private string dui;
        private string telefono;
        private string username;

        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Username { get => username; set => username = value; }

        public bool Insertar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "insert into Empleado (nombre, apellido, correo, dui, telefono, username) values (@nombre, @apellido, @correo, @dui, @telefono, @username);";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@username", username);

            if(cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Actualizar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "UPDATE Empleado SET nombre = @nombre, apellido = @apellido, correo = @correo, DUI = @dui, telefono = @telefono WHERE ID_Empleado = @id;";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id_Empleado);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@telefono", telefono);

            if(cmd.ExecuteNonQuery() > 0) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "DELETE FROM Empleado WHERE ID_Empleado = @id;";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id_Empleado);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Cargar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "SELECT Empleado.ID_Empleado as ID, Empleado.nombre as Nombre, Empleado.apellido as Apellido, DUI as Dui, Empleado.Correo as Correo, \r\nEmpleado.Telefono as Telefono, Empleado.username as [Nombre de Usuario], Roles.NombreRol as Rol from Empleado\r\nINNER JOIN Usuario on Usuario.username = Empleado.username\r\nINNER JOIN Roles on Usuario.id_Rol = Roles.Id_Rol\r\n";
            SqlCommand cmd = new SqlCommand(comando, con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;
        }

        public Empleado ObtenerInfo()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "SELECT * FROM Empleado WHERE username = @username;";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@username", username);

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Empleado emp = new Empleado();
                emp.Id_Empleado = (int)rd[0];
                emp.Nombre = (string)rd[1];
                emp.Apellido = (string)rd[2];
                emp.Correo = (string)rd[3];
                emp.Dui = (string)rd[4];
                emp.Telefono = (string)rd[5];
                emp.Username = (string)rd[6];

                return emp;
            }
            else
            {
                return null;
            }
        }
    }
}
