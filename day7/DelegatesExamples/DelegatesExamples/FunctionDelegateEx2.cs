using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class FunctionDelegateEx2
    {
        public static int sum(int x,int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
         

        static void Main()
        {
            int a, b;
            Console.WriteLine("enter two numbers");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> obj = sum;
            Console.WriteLine("sum is "+obj(20,5));
        }
    }
}
