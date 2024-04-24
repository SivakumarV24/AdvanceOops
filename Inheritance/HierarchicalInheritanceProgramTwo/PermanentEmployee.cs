using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceProgramTwo
{
    public class PermanentEmployee:SalaryInfo
    {
        //field
        private static int s_employeeId=1000;
        //property
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }
        //constructor
        public PermanentEmployee(double basicSalary,string month): base(basicSalary,month)
        {
            // AutoIncreamentation
            s_employeeId++;
            EmployeeID="EID"+s_employeeId;
            CalculateTotalSalary();

        }
        //Method
        public void CalculateTotalSalary()
        {
            DA=0.15*BasicSalary/100;
            HRA=0.18*BasicSalary/100;
            PF=0.1*BasicSalary/100;
            TotalSalary=BasicSalary+DA+HRA-PF;            
        }
        public void ShowSalary()
        {
            Console.WriteLine($"Salary : {TotalSalary}");   
        }
        
        
        
        
        
        
        
        
        
        
    }
}