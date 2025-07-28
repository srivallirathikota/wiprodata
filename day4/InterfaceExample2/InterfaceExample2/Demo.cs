using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    internal class Demo:InterfaceOne,InterfaceTwo
    {
        public void Name()
        {
            Console.WriteLine("Valli ");
        }
        public void Email()
        {
            Console.WriteLine("Email is w@gmail.com");
        }
    }
}
