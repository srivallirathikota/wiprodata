using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Quiz
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2 };
            int x = 6, y = 0;
            try
            {
                a[2] = x / y;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Size small");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("division by zero impoosible");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
