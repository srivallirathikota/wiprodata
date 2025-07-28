using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample5
    {
        [Obsolete("Deprecated Method",false)]
        public static void TestMethod()
        {
            Console.WriteLine("Demo Method");
        }
        static void Main() { }
    }
}
