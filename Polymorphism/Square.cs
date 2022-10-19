using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : GeometricForm
    {
        public Square(double edge)
        {
            Width = Height = edge;
            Console.WriteLine("Rectangle has been created");
        }
    }
}
