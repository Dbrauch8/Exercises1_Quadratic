using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Enter a numerical value for a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter a numerical value for b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Enter a numerical value for c: ");
            double.TryParse(Console.ReadLine(), out c);
          
            double power = ((b * b) - 4 * a * c); 

            double root = Math.Sqrt(power);

            double x1 = (-b + Math.Sqrt(power)) / (2 * a);
            double x2 = (-b - Math.Sqrt(power)) / (2 * a);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Your solution for + is: " + x1);
            Console.WriteLine("Your solution for - is: " + x2);
            Console.ReadLine();

        }
    }
}
