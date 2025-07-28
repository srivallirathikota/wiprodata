using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class StrExample
    {
        static void Main()
        {
            string str = "Hello world";
            try
            {
                Console.WriteLine(str.Substring(2, 50));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("String is small as range (2 to 50) not possible");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("enter the crt length to get substring ");
            }
        }
    }
}
