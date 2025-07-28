using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class StaticClassEx1
    {
        static class Demo
        {
            public static void show()
            {
                Console.WriteLine("show method from demo class");
            }
            public static string Trainee()
            {
                return "Trainee is valli";
            }
        }
        static void Main()
        {
            Demo.show();
            Console.WriteLine(Demo.Trainee());
        }
    }
}
