using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsConEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] arrEmploy = new Employ[] 
            { 
            new Uday(1,"uday",678),
            new Anusha(2,"anusha",67),
            new Madhu(3,"madhu",699)
            };
            foreach(Employ employ in arrEmploy)
            {
                Console.WriteLine(employ);
            }
        }
    }
}
