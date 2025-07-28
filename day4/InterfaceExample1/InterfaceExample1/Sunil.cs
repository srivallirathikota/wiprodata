using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Sunil : ITraning
    {
        public void Email()
        {
            Console.WriteLine("Email is s@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Hey this is Sunil");
        }
    }
}
