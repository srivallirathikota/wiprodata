using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployProject.Models
{
    [Serializable]
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Gender {  get; set; }
        public string Desig {  get; set; }
        public double Basic { get; set; }
        public string Dept {  get; set; }
        public Employ()
        {

        }
        public Employ(int empno, string name, string gender, string desig, double basic,string dept)
        {
            Empno = empno;
            Name = name;
            Gender = gender;
            Desig = desig;
            Basic = basic;
            dept = dept;
        }
        public override string ToString()
        {
            return "Employ No: " + Empno +
                " Name: " + Name +
                " Gender: " + Gender + " Department: " + Dept + " Designation: " + Desig + " Basis: " + Basic;
        }
    }

}
