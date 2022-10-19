using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rectangle : GeometricForm
    {

        public Rectangle(double shortEdge, double longEdge)
        {
            Width = shortEdge;
            Height = longEdge;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Width * Height}");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {2*(Width + Height)}");
        }
    }
}
