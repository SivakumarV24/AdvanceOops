using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramTwo
{
    public partial class Student
    {
        // constructor
        public Student(string name,Gender gender,DateTime dob,string mobile,double physicsMark,double chemistryMark,double mathsMark)
        {
            //Auto increamentation
            s_studentID++;
            //Assigning value to property
            StudentID="SID"+s_studentID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
        }
    }
}