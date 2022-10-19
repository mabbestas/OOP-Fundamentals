using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : GeometricForm
    {
        public Rectangle(double width, double height)
        {
            Console.WriteLine("Rectangle has been created.");
            Width = width;
            Height = height;
        }
    }
}
