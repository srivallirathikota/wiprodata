using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayCopy
    {
        public void Show()
        {
            int[] a = new int[] { 1, 5, 3, 66, 8 };
            int[] b = a;
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("ArrayCopy of b: "+b[i]);
            }
        }
        static void Main()
        {
            ArrayCopy arrCopy = new ArrayCopy();
            arrCopy.Show();
        }
    }
}
