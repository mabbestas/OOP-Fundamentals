using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class GeometricForm
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Metotları abstract olarak işaretledik. Çünkü bu Class'tan miras alacak sınıfların içerisinde gövdesi yazılacak ve her classta farklı şekilde kullanılacak. 

        public abstract void CalculateArea();
        public abstract void CalculateCircumference();
    }
}
