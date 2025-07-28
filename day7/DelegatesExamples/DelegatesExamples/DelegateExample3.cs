using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateExample3
    {
        public delegate void MyDelegae(int n);

        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial value:" + f);
        }
        public static void PosNeg(int n)
        {
            if(n >= 0)
            {
                Console.WriteLine(" positive");
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
                Console.WriteLine("Even num");
            }
            else
            {
                Console.WriteLine("oDD");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value");
            n=Convert.ToInt32(Console.ReadLine());
            MyDelegae obj = new MyDelegae(PosNeg);
            obj += new MyDelegae(Fact);
            obj += new MyDelegae(EvenOdd);
            obj(n);
        }
        
    }
}
