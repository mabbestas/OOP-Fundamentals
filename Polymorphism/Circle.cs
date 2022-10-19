using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : GeometricForm
    {
        public Circle(double radius)
        {
            Width = Height = radius;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Math.PI*Math.Pow(Width, 2)} ");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {2*Math.PI* Width}");
        }
    }
}
