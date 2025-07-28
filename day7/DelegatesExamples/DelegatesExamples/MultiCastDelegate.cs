using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class MultiCastDelegate
    {
        public delegate void DotnetFsd();
        public static void Proejct()
        {
            Console.WriteLine("Capstone project");
        }
        public static void MileStone1()
        {
            Console.WriteLine("milestone 1");
        }
        public static void MileStone2()
        {
            Console.WriteLine("Mileston 2");
        }
        public static void MileStone3()
        {
            Console.WriteLine("Milestone 3");
        }
        public static void MileStone4()
        {
            Console.WriteLine("Milestone 4");
        }
        static void Main()
        {
            DotnetFsd obj = new DotnetFsd(MileStone1);
            obj += MileStone2;
            obj += MileStone3;
            obj += MileStone4;
            obj += Proejct;
            obj();


        }
    }
}
