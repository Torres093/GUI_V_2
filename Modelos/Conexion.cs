using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelos
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            string servidor = "DESKTOP-STVJ29P\\MSSQLSERVER01";
            string baseDeDatos = "SEFT";
            string cadena = $"Data Source = {servidor}; " +
                $"Initial Catalog = {baseDeDatos}; " +
                $"Integrated Security = true;";

            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }

    }
}
