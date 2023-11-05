using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb3_Poly
{
    internal class Square : Geometry
    {
        public double side { get; set; }
        public Square()
        {
            side = 6;

        }
        public override double Area()
        {
            _area = (side * side);
            return _area;
        }
        public override void PrintInfo()
        {
            Area();
            Console.WriteLine("SQUARE\nSquare side = {0}\nSquare area = {1}\n", side, _area);
        }
    }
}
