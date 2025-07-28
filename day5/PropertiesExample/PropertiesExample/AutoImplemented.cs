using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Employ
    {
        public int Empno {  get; set; }
        public string EmployName { get; set; }
        public double Basic {  get; set; }
    }
    internal class AutoImplemented
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.EmployName = "xys";
            employ1.Basic = 56;
            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.EmployName = "hjk";
            employ2.Basic = 789;
            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.EmployName = "yui";
            employ3.Basic = 45;
            Console.WriteLine("First Employee Record(s)  ");
            Console.WriteLine("Employ No  " + employ1.Empno + " Employ Name " + employ1.EmployName + " Employ Basic  " + employ1.Basic);
            Console.WriteLine("Employ No  " + employ2.Empno + " Employ Name " + employ2.EmployName + " Employ Basic  " + employ2.Basic);
            Console.WriteLine("Employ No  " + employ3.Empno + " Employ Name " + employ3.EmployName + " Employ Basic  " + employ3.Basic);

        }
    }
}
