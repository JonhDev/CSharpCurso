using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Jerarquia
{
    public class Empleado: Object
    {
        public string Nombre { get; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"\n{base.ToString()} {Nombre}" + " \nEmpleado";
        }
    }
}
