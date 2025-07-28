using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age < 18)
            {
                throw new VotingException("you're not Eligible for voting");
            }
            Console.WriteLine("you're eligible to vote");
        }
        static void Main()
        {
            Console.WriteLine("Enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            try
            {
                voting.Check(age);
            }
            catch (VotingException v)
            {
                Console.WriteLine(v.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           

        }
    }
}
