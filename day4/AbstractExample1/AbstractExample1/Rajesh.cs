using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Rajesh : Training
    {
        public override void Email()
        {
            Console.WriteLine("email is r@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("hello this is r");
        }
    }
}
