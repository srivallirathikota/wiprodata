using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegatesExample1
    {
        public delegate void MyDelegate();
        public static void Show()
        {
            Console.WriteLine("welcome to delegates");
        }
    
    static void Main()
        {
            MyDelegate obj = new MyDelegate(Show);
            obj();
        }
    }
}
