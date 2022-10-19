using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class RightTriangle : GeometricForm
    {
        public RightTriangle(double baseline, double height)
        {
            Width = baseline;
            Height = height;
        }
      
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {(Width * Height) /2}");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {Width + Height + Math.Sqrt((Math.Pow(Width, 2))+(Height * Height))}");
        }

    }
}
