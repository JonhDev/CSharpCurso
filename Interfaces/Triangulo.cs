using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangulo : AbstractPolygon
    {
        public Triangulo(int length): 
            base(3, length)
        {

        }

        public override double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(base.SideLength, 2);
        }

        public void TestMethod()
        {
            Console.WriteLine("Testing");
        }
    }
}
