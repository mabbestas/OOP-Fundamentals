using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.CalculateArea();
            rectangle.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            Square square = new Square(15);
            square.CalculateArea();
            square.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            RightTriangle rightTriangle = new RightTriangle(6,8);
            rightTriangle.CalculateArea();
            rightTriangle.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            Circle circle = new Circle(10);
            circle.CalculateArea();
            circle.CalculateCircumference();

            Console.ReadKey();
        }
    }
}
