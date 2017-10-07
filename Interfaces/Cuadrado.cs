using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cuadrado : IPolygon
    {
        public int SidesNumber { get; set; }
        public int SideLength { get; set; }

        public Cuadrado(int length)
        {
            SidesNumber = 4;
            SideLength = length;
        }

        public double GetArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public double GetPerimeter()
        {
            return SidesNumber * SideLength;
        }
    }
}
