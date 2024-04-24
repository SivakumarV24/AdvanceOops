using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class Syncfusion :FreeLancer
    {
        // field
        private static  int s_employeeId=100;
        // property
        public string EmployeeID { get; } // readOnly
        public string WorkLocation { get; set; }
        // constructor
        public Syncfusion(string workLocation,string role,int noOfWorkingDays,string name,string fatherName,Gender gender,string qualification) : base(role,noOfWorkingDays,name,fatherName,gender,qualification)
        {
            s_employeeId++;
            EmployeeID="EID"+s_employeeId;
            WorkLocation=workLocation;
        }
        // override methods
        public override void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            Console.WriteLine($"{Math.Round(SalaryAmount,2)}");
        }
        public override void Display()
        {
             Console.WriteLine($"EmployeeDetails");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gener : {Gender}");
            Console.WriteLine($"Qualification : {Qualification}");
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine($"Work Location : {WorkLocation}");            
            Console.WriteLine($"SalaryAmount :  {SalaryAmount}");
        }
    }
}