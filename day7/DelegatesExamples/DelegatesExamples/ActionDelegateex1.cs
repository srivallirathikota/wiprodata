using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class ActionDelegateex1
    {
        public delegate void MyDelegate(string str);
        public static void Greeting(string s)
        {
            Console.WriteLine("Good Mrng");
        }
        static void Main()
        {
            MyDelegate obj = Greeting;
            obj("valli");
        }

    }
}
