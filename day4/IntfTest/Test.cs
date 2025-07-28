using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfTest
{
    internal class Test:Interface1,Interface2
    {
        public void Shouw()
        {
            Console.WriteLine("Show Method from InterfaceTwo");
        }

        void Interface1.Show()
        {
            Console.WriteLine("Show Method from Interface One...");
        }
    }
}
