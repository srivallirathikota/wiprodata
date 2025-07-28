using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the 2 number");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division:" + c);
            }
            catch(OverflowException e) {
                Console.WriteLine("Number is too big");
            }
            catch(FormatException e)
            {
                Console.WriteLine("String cannot be Converted as Integer");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division By Zero Impossible...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program From Wipro Batch...");
            }

        }
    }
}
