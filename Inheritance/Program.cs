using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricForm geometricForm = new GeometricForm();
            geometricForm.Width = 10;
            geometricForm.Depth = 20;
            geometricForm.CalculateArea();
            geometricForm.CalculateCircumference();

            Console.WriteLine(new string('*',20));

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 12;
            rectangle.Depth = 15;
            rectangle.CalculateArea();
            rectangle.CalculateCircumference();

            Console.WriteLine(new string('*', 20));

            Square square = new Square();
            square.Width = 14;
            square.Depth = 14;
            square.CalculateArea();
            square.CalculateCircumference();

            Console.ReadLine();
        }
    }
}
