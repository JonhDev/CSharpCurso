using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPolygon
    {
        int SidesNumber { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
