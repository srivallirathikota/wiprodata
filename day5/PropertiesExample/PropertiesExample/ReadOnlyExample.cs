using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{

    class Bank
    {
        public int AccountNo { get; } = 12;
        public string BranchName { get; } = "ECII";
        public string BankName { get; } = "ICICI";

    }



    internal class ReadOnlyExample
    {
      
       
            static void Main()
            {
            Bank bank = new Bank();
            Console.WriteLine("Account no" + bank.AccountNo);
            Console.WriteLine("Bank Name"+bank.BankName);
            Console.WriteLine("Branch Name"+bank.BranchName);
            
            }

     }
    
}
