using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb3_Poly
{
    internal class Geometry
    {
        public double _area;
        public virtual double Area(double area)
        {
            _area = area;
            return area;
        }
    }
}
