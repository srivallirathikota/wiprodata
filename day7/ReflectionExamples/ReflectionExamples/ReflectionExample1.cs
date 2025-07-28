using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample1
    {
        static void Main()
        {
            Type typeObj = typeof(Test);
            Console.WriteLine("Methods Avaliable");
            foreach (MethodInfo mi in typeObj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variable avaliable in the class");
            foreach (FieldInfo fi in typeObj.GetFields())
            {
                Console.WriteLine(fi.Name);

            }
        }

    }
}
