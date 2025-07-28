using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Ladder
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi I am v...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi I am j...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi I am Neha...");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hi am Yam...");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Hi I am Devi...");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter Your Choice  ");
            choice = Convert.ToInt32(Console.ReadLine());
            Ladder ladder = new Ladder();
            ladder.Show(choice);
        }
    }
}
