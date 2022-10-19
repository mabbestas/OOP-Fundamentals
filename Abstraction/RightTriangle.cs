using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class RightTriangle : GeometricForm
    {
        public double Hipotenus { get; set; }
        public RightTriangle(double width, double height, double hipotenus)
        {
            Width = width;
            Height = height;
            Hipotenus = hipotenus;
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Width * Height / 2}");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {Width + Height + Hipotenus}");
        }
    }
}
