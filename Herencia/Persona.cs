using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public string Sexo { get; set; }

        public override string ToString()
        {
            return base.ToString() + Nombre;
        }
    }
}
