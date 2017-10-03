using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    public class Persona
    {
        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public string Sexo { get; set; }
        
        public void Correr()
        {
            ImprimeMensaje("Estoy corriendo");
        }

        private void ImprimeMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
