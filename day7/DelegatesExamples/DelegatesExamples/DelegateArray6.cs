using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateArray6
    {
        public delegate void Mydelegate(int n);
        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 0; i < n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("factorial value:"+f);
        }
        public static void PosNeg(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        public static void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter N Value   ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mydelegate[] arr =
            {
                new Mydelegate(PosNeg),
                new Mydelegate(EvenOdd),
               new Mydelegate(Fact)
            };
            foreach (Mydelegate m in arr)
            {
                m(n);
            }
        }
        }
    }
