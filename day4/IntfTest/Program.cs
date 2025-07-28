using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1 obj1 = new Test();
            obj1.Show();
            Interface2 obj2 = new Test();
            obj2.Shouw();
        }
    }
}
