using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb3_Poly
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public double Pi = 3.14;
        public Circle()
        {
            Radius = 6;
        }
        public override double Area()
        {
            _area = (Pi * (Radius * Radius));
            return _area;
        }
        public override void PrintInfo()
        {
            Area();
            Console.WriteLine("CIRCLE\nCircle radius: {0} \nCircle area ≈ {1}\n", Radius, _area);
        }
    }
}
