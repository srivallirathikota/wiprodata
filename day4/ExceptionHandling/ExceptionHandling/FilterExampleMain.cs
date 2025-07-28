using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FilterExampleMain
    {
        static void RaiseSeverity(String severity)
        {
            if (severity.Equals("low"))
            {
                throw new FilterExampleException(" low severity you can leave for time");
            }
            else if (severity.Equals("medium"))
            {
                throw new FilterExampleException("medium severity");
            }
            else if (severity.Equals("high"))
            {
                throw new FilterExampleException("high severity");
            }else if (severity.Equals("critical"))
            {
                throw new FilterExampleException("critical severity");
            }
            else
            {
                throw new FilterExampleException("No error occured");
            }
        }
        static void Main()
        {
            string severity;
            Console.WriteLine("Enter the severity (low/medium/high/critical)");
            severity = Console.ReadLine();
            try
            {
                RaiseSeverity(severity);
            }
            catch (FilterExampleException e) when (e.Message.Contains("low"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("high"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("critical"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
