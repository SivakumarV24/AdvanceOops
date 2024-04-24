using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFive
{
    public class SalaryInfo:EmployeeInfo
    {
        // property
        public int NumberOfDaysWorked { get; set; }
        // constructor
        public SalaryInfo(int numberOFDaysWorked,string name,string fatherName,string mobileNumber,Gender gender ): base(name,fatherName,mobileNumber,gender)
        {
            NumberOfDaysWorked=numberOFDaysWorked;
        }
        // Methods
        public override void Display()
        {

            Console.WriteLine($"Salary : {NumberOfDaysWorked*500}");
        }
    }
}