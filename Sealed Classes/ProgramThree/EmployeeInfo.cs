using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    public class EmployeeInfo: FamilyInfo
    {
        // field
        private static int s_employeeID=100;
        // Property
        public string EmployeeID { get;  } // read Only
        public DateTime DateOfJoining { get; set; }
        // constructor
        public  EmployeeInfo(DateTime dateOfJoining,string fatherName,string motherName,int noOfSibilings,string nativePlace,string name,string mobile,string mail,Gender gender): base(fatherName,motherName,noOfSibilings,nativePlace,name,mobile,mail,gender)
        {
            // Auto increamentation
            s_employeeID++;
            //  Assigning value to property
            EmployeeID="EID"+s_employeeID;
            DateOfJoining=DateOfJoining;
        }
        // overideMethod
        public override void Update() // 'EmployeeInfo.Update()': cannot override inherited member 'FamilyInfo.Update()' because it is sealed
        {
            Console.WriteLine($"EmployeeID update successfully.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"EmployeeID DisplayInfo ");
            
        }
        
        
        
    }
}