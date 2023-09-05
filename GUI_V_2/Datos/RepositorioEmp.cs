using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Datos
{
    public class AñadirEmp
    {
        public static List<Empleado> Empleados { get; private set; }

        public static void InicializarRepositorio()
        {
            Empleados = new List<Empleado>();
        }

        public static void AddEmp(Empleado empleado)
        {
            Empleados.Add(empleado);
        }


        public static void EliminarEmp(string name)
        {
            Empleados.RemoveAll(e => e.Name.Equals(name));
        }

        public static void ActualizarEmp(string name, Empleado empleadoModificado)
        {
            int IndiceEmpleadoOriginal = Empleados.FindIndex(e => e.Name == name);
            if (IndiceEmpleadoOriginal != -1)
            {
                Empleados[IndiceEmpleadoOriginal] = empleadoModificado; 
            }
        }
   
    
    }

}
