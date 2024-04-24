using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramOne
{
    public class TheoryExamMarks:PersonalInfo
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
        // constructor
        public TheoryExamMarks(int[] sem1,int[] sem2,int[] sem3,int[] sem4,string name,string fatherName,DateTime dob,string phone,Gender gender):base(name,fatherName,dob,phone,gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
    }
}