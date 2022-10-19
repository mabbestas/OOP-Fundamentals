using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Iron newIron = new Iron();
            Console.WriteLine("Please enter brand of the iron:");
            newIron.Brand = Console.ReadLine();

            Console.WriteLine("Please enter color of the iron:");
            newIron.Color = Console.ReadLine();

            newIron.Temperature = 0;
            Console.WriteLine(new string('#', 20));

            Console.WriteLine("Iron has been created!\nBrand: {0}, Color: {1}, Temperature: {2}", newIron.Brand, newIron.Color, newIron.Temperature);

            Console.Read();
        }
    }
}
