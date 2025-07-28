using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Yam:ITraning
    {
        public void Email()
        {
            Console.WriteLine("Email is Yam@gmail.com");
        }
        public void Name()
        {
            Console.WriteLine("hi my name is Yam");
        }
    }
}
