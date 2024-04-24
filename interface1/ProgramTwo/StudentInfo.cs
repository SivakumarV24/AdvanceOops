using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class StudentInfo : IDisplayInfo
    {
        // Field
        private static int s_studentID=100;
        // Property
        public string StudentID { get; } // ReadOnly
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        //constructor
        public StudentInfo(string name,string fatherName,string mobile)
        {
            // auto Increamentation
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"********StudentInfo********");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"StudentID ; {StudentID}");            
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"Mobile : {Mobile}");
            Console.WriteLine();            
        }
    }
}