using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunction
{
    internal class LambdaEx1
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
                {
                new Employ{Empno=1,Name="Rale",Basic=88323},
                new Employ{Empno=2,Name="kata",Basic=91133},
                new Employ{Empno=3,Name="Uday",Basic=80022},
                new Employ{Empno=4,Name="Pali",Basic=90321},
                new Employ{Empno=5,Name="Prai",Basic=78822},
                new Employ{Empno=6,Name="Anu",Basic=78823},
            };

            Console.WriteLine("Employ List");
            var result1 = employList.Select(x => x.Empno);
            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }
            var result2 = employList.Select(x => new { x.Name, x.Basic });
            Console.WriteLine("Projected fields are :");
            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }
            var result3 = employList.Where(x => x.Basic >= 90000);
            Console.WriteLine("salary >90000 record are");
            foreach (var v in result3)
            {
                Console.WriteLine(v);
            }
            var result4 = employList.Where(x => x.Name.StartsWith("P"));
            Console.WriteLine("name starts with p");
            foreach (var v in result4)
            {
                Console.WriteLine(v);
            }

        }

    
        
    }
}
