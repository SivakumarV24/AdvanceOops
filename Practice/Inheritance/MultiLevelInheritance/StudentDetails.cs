using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class StudentDetails: PersonalDetails
    {
        //Field
        public static int s_studentID=100;
        //property
        public string StudentID { get;} // ReadOnly
        public string Standard { get; set; }        
        public string YearOfJoining { get; set; }
        // constructor
        public StudentDetails(string userID,string name,string fatherName,Gender gender ,string phoneNumber,string standard,string yearOfJoining):base(userID,name,fatherName,gender,phoneNumber)
        {
            // Auto Increamentation
            s_studentID++;
            // Assigning Value to Property
            StudentID="SID"+s_studentID;
            Standard=standard;
            YearOfJoining=yearOfJoining;
        }
        public StudentDetails(string userID,string name,string fatherName,Gender gender ,string phoneNumber,string studentId,string standard,string yearOfJoining):base(userID,name,fatherName,gender,phoneNumber)
        {
            // Assigning Value to Property
            StudentID=studentId;
            Standard=standard;
            YearOfJoining=yearOfJoining;
            
        }

        
        
        
        
        
        
    }
}