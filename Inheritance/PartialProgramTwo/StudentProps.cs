using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramTwo
{
    //enum
    public  enum Gender{
        Male,Female,Transgender
    }
    public partial class Student
    {
        // Field
        private static  int s_studentID=100;
        //property
        public string StudentID { get;} //Read Only
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
        public double PhysicsMark { get; set; }
        public double ChemistryMark { get; set; }
        public double MathsMark { get; set; }
        
    }
}