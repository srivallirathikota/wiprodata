using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class CaseEx2
    {
        public void Show(string dayName)
        {
            switch (dayName.ToUpper())
            {
                case "SUN":
                    Console.WriteLine(" Sunday...");
                    break;
                case "MON":
                    Console.WriteLine(" Monday...");
                    break;
                case "TUE":
                    Console.WriteLine("Tuesday...");
                    break;
                case "WED":
                    Console.WriteLine(" Wednesday...");
                    break;
                case "THU":
                    Console.WriteLine(" Thursday...");
                    break;
                case "FRI":
                    Console.WriteLine(" Friday...");
                    break;
                case "SAT":
                    Console.WriteLine("Saturday...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }
        static void Main()
        {
            string dayName;
            Console.WriteLine("Enter 3 chars of Day Name  ");
            dayName = Console.ReadLine();
            CaseEx2 caseEx2 = new CaseEx2();
            caseEx2.Show(dayName);
        }
    }
}
