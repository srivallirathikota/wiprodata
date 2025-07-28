using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class StaticMethods
    {
        class Data
        {
            public void Show()
            {
                Console.WriteLine( "By using class, cannot be display and only displya for object creation");
            }
            public static void Display()
            {
                Console.WriteLine("displayed with the help of ClassName");
            }
        }
        static void Main(string[] args)
        {
            Data.Display();
            new Data().Show();
        }
    }
}
