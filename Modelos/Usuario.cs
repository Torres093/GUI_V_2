using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 
using System.Security.Cryptography;

namespace Modelos
{
    public class Usuario
    {
        private string username;
        private string password;
        private int id_Rol;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
       public int Id_Rol { get => id_Rol; set => id_Rol = value; }

        public static DataTable Cargar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "SELECT * FROM Usuario;";
            SqlCommand cmd = new SqlCommand(comando, con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;
        }

        public string Encriptar(string claveSinEncriptar)
        {
            SHA256 s = SHA256.Create();
            byte[] bytes = s.ComputeHash(Encoding.UTF8.GetBytes(claveSinEncriptar));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {

                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public bool Insertar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "INSERT INTO Usuario (username, password, id_Rol) VALUES (@username, @password, @id_Rol);";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id_Rol", id_Rol);

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

        public bool Actualizar(string usernameOriginal)
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "UPDATE Usuario SET username = @username, password = @password, id_Rol = @id_Rol WHERE username = @usernameOriginal;";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id_Rol", id_Rol);
            cmd.Parameters.AddWithValue("@usernameOriginal", usernameOriginal);

            if (cmd.ExecuteNonQuery() > 0)
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
            string comando = "DELETE FROM Usuario WHERE username = @username;";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@username", username);

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public Usuario IniciarSesion()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "SELECT * FROM Usuario where username = @username and password = @password;";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader rd = cmd.ExecuteReader();

            if(rd.Read())
            {
                Usuario u = new Usuario();

                u.username = (string)rd[0];

                u.id_Rol= (int)rd[2];

                return u;
            }

            else
            {
                return null;
            }
        }

        public static bool VerificarUsuarios()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(comando, con);

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
