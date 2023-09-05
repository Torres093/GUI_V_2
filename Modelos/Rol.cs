using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos
{
    public class Rol
    {
        public static DataTable Cargar()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "Select * from Roles;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;
        }
    }
}
