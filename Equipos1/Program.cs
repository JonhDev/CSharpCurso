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
            mane.Agregar("12");
            Console.WriteLine(mane.Consultar(0).ToString());
            Console.ReadKey();
        }
    }
}
