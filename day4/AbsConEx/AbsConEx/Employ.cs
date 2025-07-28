using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsConEx
{
    internal abstract class Employ
    {
        //private int empo;
        //private string name;
        //private double basic;

        //Employ(int empo, string name,double basic)
        //{
        //    this.empo=empo;
        //    this.name=name;
        //    this.basic = basic;
        //}
        //public override string ToString()
        //{
        //    return "Employe No" + this.empo + "Employe Name" + this.name + "Basic" + this.basic;
        //}
        private int empno;
        private string name;
        private double basic;

        public Employ(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return "Employ No  " + this.empno + " Employ Name " + this.name + " Basic " + this.basic;
        }
    }
}
