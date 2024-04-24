using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalProgramOne
{
    public class StudentInfo:PersonalInfo
    {
        // field
        private static int s_studentID=100;
        // property
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }

        public StudentInfo(string degree,string department,string semster,string name,string fatherName,DateTime dob,string phone,Gender gender,string mail):base(name,fatherName,dob,phone,gender,mail)
        {
            // Auto Increamentation
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semster;
        }
        //Mehtod
        public void ShowDetails()
        {
            Console.WriteLine($"*****StudentInfo*******");
            Console.WriteLine($"Student ID : {StudentID}");
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Date Of Birth : {DOB}");
            Console.WriteLine($"Degree : {Degree}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Semster : {Semester}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"MailId : {Mail}");
            
            
        }
        
        
        
        
        
        
        
        
    }
}