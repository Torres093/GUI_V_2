using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Usuario.VerificarUsuarios() == true)
            {
                //Si hay usuarios creados, se abre el Login
                Application.Run(new frmlogin());
            }
            else
            {
                //Si no hay usuarios creados, se abre la ventana de primer uso
                Application.Run(new frmPrimerUso());
            }
        }
    }
}
