using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalProgramOne
{
    public class Teacher : PersonalInfo
    {
        // Field
        private static int s_teacherID=100;
        // property
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        
        //Constructor
        public Teacher(string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining,string name,string fatherName,DateTime dob,string phone,Gender gender,string mail):base(name,fatherName,dob,phone,gender,mail)
        {
            // Auto increamentation
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            // Assigning Value to property
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        //Method
        public void ShowDetails()
        {
            Console.WriteLine($"**********Teacher Info********");
            Console.WriteLine($"Teacher ID : {TeacherID}");
             Console.WriteLine($"Teacher Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Date Of Birth : {DOB}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"SubjectTeaching : {SubjectTeaching}");
            Console.WriteLine($"Qualification : {Qualification}");
            Console.WriteLine($"Year of Experience : {YearOfExperience}");
            Console.WriteLine($"Date Of Joining : {DateOfJoining}"); 
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"MailId : {Mail}");  
        }
        
        
        
        
        
        
        
        
        
        
    }
}