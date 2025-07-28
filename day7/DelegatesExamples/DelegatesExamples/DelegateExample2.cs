using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateExample2
    {
        public delegate void DelegateExamples(string s);
        public static void Show(string s)
        {
            Console.WriteLine("welcome to delegates");
        }
        static void Main()
        {
            DelegateExamples dele = new DelegateExamples(Show);
            dele("v");
        }
    }
}
