using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Jerarquia
{
    public class Operario: Empleado
    {
        public Operario(string nombre): 
            base(nombre)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nOperario"; 
        }
    }
}
