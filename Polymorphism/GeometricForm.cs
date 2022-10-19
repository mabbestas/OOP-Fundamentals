using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class GeometricForm
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public virtual void CalculateArea()
        {
            Console.WriteLine($"Area: {Width * Height}");
        }

        public virtual void CalculateCircumference()
        {
            Console.WriteLine($"Circumference: {2*(Width + Height)}");
        }

    }
}
