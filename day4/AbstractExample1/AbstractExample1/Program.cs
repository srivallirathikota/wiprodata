using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Training[] arrTraining = new Training[]
            {
                new Rajesh(),
                new Venkat(),
                new Rani()
            };

            foreach (Training t in arrTraining)
            {
                t.Company();
                t.Email();
                t.Name();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
