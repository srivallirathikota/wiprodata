using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Rani : Training
    {
        public override void Email()
        {
            Console.WriteLine("email is ra@gmail.com");

        }

        public override void Name()
        {
            Console.WriteLine("this is rani");
        }
    }
}
