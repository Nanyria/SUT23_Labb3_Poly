using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb3_Poly
{
    internal class Rectangle : Geometry
    {

        public double length { get; set; }
        public double width { get; set; }
        public Rectangle()
        {
            length = 6;
            width = 4;
        }
        public override double Area()
        {
            _area = (length * width);
            return _area;
        }
        public override void PrintInfo()
        {
            Area();
            Console.WriteLine("RECTANGLE\nRectangle side = {0} \nRectangle width = {1}\nRectangle area = {2}\n", length, width, _area);
        }
    }
}
