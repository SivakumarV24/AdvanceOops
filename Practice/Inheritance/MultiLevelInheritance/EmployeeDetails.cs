using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails: StudentDetails
    {
        // Field
        private static int s_employeeID=100;
        // property
        public string EmployeeID { get; } // ReadOnly
        public string Designation { get; set; }
        //constructor
        public EmployeeDetails(string userID,string name,string fatherName,Gender gender ,string phoneNumber,string studentId,string standard,string yearOfJoining,string designation): base(userID,name,fatherName,gender,phoneNumber,standard,yearOfJoining)
        {
            //Auto Increamentation
            s_employeeID++;
            //Assigning value to property
            Designation=designation;
        }
        
        
        
        
    }
}