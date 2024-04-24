using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class EmployeeInfo
    {
        // Field
        private static int s_employeeID=100;
        // Property
        public string EmployeeID { get; } // ReadOnly
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        //constructor
        public EmployeeInfo(string name,string fatherName,string mobile)
        {
            // auto Increamentation
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"********EmployeeInfo********");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"EmployeeID : {EmployeeID}");            
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"Mobile : {Mobile}");
            Console.WriteLine();            
        }
    }
}