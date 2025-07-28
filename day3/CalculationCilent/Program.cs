using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLibrary;
namespace CalculationCilent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            Console.WriteLine("Enter two nums");
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c.Sum(a, b));
            Console.WriteLine(c.Sub(a, b));
            Console.WriteLine(c.Mult(a, b));

        }
    }
}
