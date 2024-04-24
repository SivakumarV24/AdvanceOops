using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceProgramOne
{
    public class StudentInfo : PersonalInfo
    {
        // Field
        private static int s_registrationNumber=100;
        // property
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }
        // constructor
        public StudentInfo(string registrationNumber,string standard,string branch,int acadamicyear,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(name,fatherName,phone,mail,dob,gender)
        {
            // Assigning value to property
            RegisterNumber=registrationNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicyear;
        }
        public StudentInfo(string standard,string branch,int acadamicyear,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(name,fatherName,phone,mail,dob,gender)
        {
            // Auto Increamentation
            s_registrationNumber++;
            // Assigning Value to Property
            RegisterNumber="RID"+s_registrationNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicyear;
        }        
        // Method
        // ShowInfo
        public void ShowInfo()
        {
            Console.WriteLine($"**********StudentInfo***********");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"RegisterNumber : {RegisterNumber}");            
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Mail : {Mail}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Standard : {Standard}");
            Console.WriteLine($"Branch : {Branch}");
            Console.WriteLine($"Acadamic Year : {AcadamicYear}");      
        }    
    }
}