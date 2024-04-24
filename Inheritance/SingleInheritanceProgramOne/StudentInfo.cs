using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceProgramOne
{
    public class StudentInfo : PersonalInfo
    {
        // Field
        private static int s_registrationID=100;
        /* RegisterNumber, Standard, Branch, AcadamicYear*/
        // Property
        public string RegisterNumber { get; } // ReadOnly
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; } 
        //constructor
        public  StudentInfo(string standard,string branch,int acadamicYear,string name,string fatherName, string phone,string mail,DateTime dob,Gender gender ) : base(name,fatherName,phone,mail,dob,gender)
        {
            // auto increamentation
            s_registrationID++;
            // Assigning the value to property
            RegisterNumber="RID"+s_registrationID;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        } 
         // Method 
        public void ShowStudentDetails()
        {
            Console.WriteLine($"****************Student Details**************");            
            Console.WriteLine($"Registration Number : {RegisterNumber} ");            
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName} ");
            Console.WriteLine($"Phone Number :  {Phone}");
            Console.WriteLine($"Mail Id : {Mail}");
            Console.WriteLine($"Date of Birth : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender : {Gender} ");
            Console.WriteLine($"Branch : {Branch} ");
            Console.WriteLine($"Standard : {Standard}");
            Console.WriteLine($"Academic Year : {AcadamicYear} ");           
        }
    }
   
   
}