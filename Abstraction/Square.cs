using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : GeometricForm
    {
        public Square(double edge)
        {
            Width = Height = edge;
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Math.Pow(Width, 2)}");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: { Width * 4}");
        }
    }
}
