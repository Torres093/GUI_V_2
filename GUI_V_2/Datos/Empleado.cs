using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Datos
{
    public class Empleado
    {
        public string Name { get; private set;}
        public string Apellido { get; private set;}
        public string Email { get; private set;}
        public int Telefono { get; private set;}
        public string Direccion {get; private set;}


        public Empleado(string name, string apellido, string email, int telefono, string direccion)
        {
            this.Apellido = apellido;
            this.Email = email; 
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Name = name;
        }
    }
   
}
