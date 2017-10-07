using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPolygon t = new Triangulo(5);
            Console.WriteLine($"{t.GetPerimeter()}  {t.GetArea()}");
            Console.ReadKey();
        }
    }
}
