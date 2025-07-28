using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Vendor
    {
        int vendorId;
        string vendorName;

        public int VendorId
        {
            set { vendorId = value; }
    }
        public string VendorName
        {
            set { vendorName = value; }
        }
        public override string ToString()
        {
            return "Vendor Id" + vendorId + "vendor Name" + vendorName;
        }


        internal class WriteOnly
        {
            static void Main()
            {
                Vendor vendor = new Vendor();
                vendor.vendorId = 1;
                vendor.vendorName = "xyz";
                Console.WriteLine(vendor);
                if(vendor.vendorId == 1)
                {
                 vendor.vendorName="valli";

                }
                Console.WriteLine(vendor);
            }
        }   
    }
}
