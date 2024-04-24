using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFive
{
    public class EmployeeInfo :PersonalInfo
    {
        // Field
        private static int s_employeeID=100;
        // property
        public string EmployeeID { get; } // ReadOnly
        //constructor
        public EmployeeInfo(string name,string fatherName,string mobileNumber,Gender gender ):  base(name,fatherName,mobileNumber,gender)
        {
            // auto Increamentation
            s_employeeID++;
            // assigning value to property
            EmployeeID="EID"+s_employeeID;
        }
        // Override Method
        public override void Display()
        {
            Console.WriteLine($"***EmployeeDetails***");
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name :  {FatherName}");
            Console.WriteLine($"MobileNumber : {MobileNumber}");
            Console.WriteLine($"Gender : {Gender}");
        }



    }
}