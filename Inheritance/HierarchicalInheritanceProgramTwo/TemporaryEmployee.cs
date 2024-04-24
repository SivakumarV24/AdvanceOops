using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceProgramTwo
{
    public class TemporaryEmployee: SalaryInfo
    {
        //field
        private static int s_employeeId=1000;
        //property
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double TotalSalary { get; set; }
        //constructor
        public TemporaryEmployee(double basicSalary,string month): base(basicSalary,month)
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
            HRA=0.13*BasicSalary/100;
            TotalSalary=BasicSalary+DA+HRA;            
        }
        public void ShowSalary()
        {
            Console.WriteLine($"Salary : {TotalSalary}");   
        }
        
    }
}