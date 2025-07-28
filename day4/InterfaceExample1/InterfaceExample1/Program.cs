using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITraning[] arr= new ITraning[]
            {
              new Sunil(),
                    new Yam()
            };
            foreach(ITraning i in arr)
            {
                i.Name();
                i.Email();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
