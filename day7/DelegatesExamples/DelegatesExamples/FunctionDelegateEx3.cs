using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class FunctionDelegateEx3
    {
        public static  string Display(int n)
        {
            return "Hello" + n;
        }
        public static int Compare(string s1, string s2)
        {
            return s1.CompareTo(s2);
        }
        public static bool Status(int mstat)
        {
            if (mstat == 0) { return true; }
            else
            {
                return false;
            }
        
        }
        public static string Show(int n)
        {
            if (n == 1)
            {
                return "venky";
            }
            else
            {
                return "raj";
            }
            return "Unkown";
        }
        static void Main()
        {
            Func<string, string, int> obj1 = Compare;
            Console.WriteLine(obj1("venky","raj"));
            Func<int, string> obj2 = Show;
            obj2 += Display;
            Console.WriteLine(obj2 (2));
            Func<int,bool> obj3=Status;
            Console.WriteLine(obj3 (1));

        }

    }
}
