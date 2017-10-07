using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class AbstractPolygon
    {
        public int SidesNumber { get; set; }
        public int SideLength { get; set; }

        public AbstractPolygon(int sides, int length)
        {
            SideLength = length;
            SidesNumber = sides;
        }

        public double GetPerimeter()
        {
            return SidesNumber * SideLength;
        }

        public abstract double GetArea();
    }
}
