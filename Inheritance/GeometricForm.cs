using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GeometricForm
    {
        public double Width { get; set; }
        public double Depth { get; set; }

        public GeometricForm()
        {
            Console.WriteLine("Geometric form has been created.");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area: {Width*Depth}");
        }

        public void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {2*(Width+Depth)}");
        }
    }
}
