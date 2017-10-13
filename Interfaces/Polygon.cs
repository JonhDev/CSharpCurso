using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Polygon
    {
        public int SidesNumber { get; set; }
        public int SidesLength { get; set; }

        public virtual double GetPerimeter()
        {
            Console.WriteLine("Perimetro");
        }
        public double GetArea()
        {
            return SidesLength * 2;
        }
    }
}
