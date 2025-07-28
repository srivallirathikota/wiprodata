using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class StaticEx
    {
         int count;
        public  void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("count is:"+count);
        }
        static void Main()
        {
         StaticEx obj1= new StaticEx();
         StaticEx obj2= new StaticEx();
            StaticEx obj3= new StaticEx();
                            // static    without int
        obj1.Increment(); 
            obj1.Show();   // 1              1
            obj2.Increment();
            obj2.Show();  // 2               1
            obj3.Increment();
            obj3.Show(); // 3                1
        }
    }
}
