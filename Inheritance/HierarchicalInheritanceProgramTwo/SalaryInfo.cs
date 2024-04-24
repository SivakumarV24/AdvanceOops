using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceProgramTwo
{
    public class SalaryInfo
    {
        //property
        public double BasicSalary { get; set; }
        public string Month { get; set; }
        // constructor
        public SalaryInfo(double basicSalary,string month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }
        
        
        
        
    }
}