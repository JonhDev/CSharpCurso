using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cuadrado: Polygon 
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
            return SidesNumber * 2;
        }

        public double GetPerimeter()
        {
            return SidesNumber * SideLength;
        }
    }
}
