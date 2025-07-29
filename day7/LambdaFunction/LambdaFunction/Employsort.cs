using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunction
{
    internal class Employsort
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
            {
                new Employ{Empno=12,Name="Rajesh",Basic=88323},
                new Employ{Empno=2,Name="Venkata",Basic=91133},
                new Employ{Empno=33,Name="Uday",Basic=80022},
                new Employ{Empno=14,Name="Pallavi",Basic=90321},
                new Employ{Empno=25,Name="Pralavi",Basic=78822},
                new Employ{Empno=6,Name="Anusha",Basic=78823},
            };
            employList.Sort();
            Console.WriteLine("sorted data w.r.t empno");
            var result1 = employList.Select(x => x);
            foreach(var v in result1)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("sort by name wise");
            employList.Sort(new NameComparer());
            var result2= employList.Select(x => x);
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("sort by Basic wise");
            employList.Sort(new BasicComparer());
            var result3 = employList.Select(x => x);
            foreach (var v in result3)
            {
                Console.WriteLine(v);
            }

        }
    }
}
