using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10,15);
            rectangle.CalculateArea();
            rectangle.CalculateCircumference();

            Console.WriteLine(new string('*',20));

            Square square = new Square(20);
            square.CalculateArea();
            square.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            RightTriangle rightTriangle = new RightTriangle(12,13,15);
            rightTriangle.CalculateArea();
            rightTriangle.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            Circle circle = new Circle(25);
            circle.CalculateArea();
            circle.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            Cylinder cylinder = new Cylinder(10,20);
            cylinder.CalculateArea();
            cylinder.CalculateCircumference();

            Console.ReadLine();
        }
    }
}
