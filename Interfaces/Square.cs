using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Square: Polygon
    {
        public Square(int sideLength)
        {
            base.SidesLength = sidesLength;
            base.SidesNumber = 4;
        }

        public override double GetPerimeter()
        {
            return base.SidesLength * base.SidesNumber;
        }

        public new double GetArea()
        {
            return base.SidesLength * 2;
        }
    }
}
