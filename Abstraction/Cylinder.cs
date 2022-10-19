using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Cylinder : GeometricForm
    {
        public Cylinder(double radius, double height)
        {
            Width = radius;
            Height = height;
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area of Base: {Math.PI*Math.Pow(Width,2)}");
            Console.WriteLine($"Surface Area: {(2 * Math.PI * Width * Height)+(2*(Math.PI * Math.Pow(Width, 2)))}");
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine($"Circumference of Base: {2*Math.PI*Width}");
            Console.WriteLine($"Side Surface Circumference: {(2*(2 * Math.PI * Width))*Height}");
        }
    }
}
