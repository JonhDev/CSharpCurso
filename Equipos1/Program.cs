using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos1
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejadorListas mane = new TestListas();
            mane.Agregar("hola");
            if (mane.Consultar(25) != null)
                Console.WriteLine(mane.Consultar(25));
        
            else
                Console.WriteLine("la posicion no ha sido asignada");
            Console.ReadKey();
        }
    }
}
