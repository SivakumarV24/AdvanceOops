using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace MultiLevelInheritanceProgramOne
{
    public class HSCDetails:StudentInfo
    {
        //Field
        private static int s_hScMarksheetNumber=100;

        //property
        public string HSCMarksheetNumber { get; } // Read Only
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public int PercentageMarks { get; set; }
        public HSCDetails(int physics,int chemistry,int maths,string standard,string branch,int acadamicyear,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string registrationNumber):base(registrationNumber,standard,branch,acadamicyear,name,fatherName,phone,mail,dob,gender)
        {
            s_hScMarksheetNumber++;
            // Assigning The value
            HSCMarksheetNumber="MID"+s_hScMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            CalculatePercenatge();
        }
        // Method
        // Getmarks
        public int CalculateTotal()
        {
            return Physics+Chemistry+Maths;
        }
        public int CalculatePercenatge()
        {
            int total=CalculateTotal();
            Total=total;
            int percentage=total/3;
            PercentageMarks=percentage;
            return percentage;
        }
        public void ShowMarksheet()
        {
            Console.WriteLine($"******Mark Sheet******");
            Console.WriteLine($"Name : {Name,-16} RegisterNumber: {RegisterNumber,-19} Branch : {Branch,-10} AcademicYear : {AcadamicYear,-16}");
            Console.WriteLine();
            Console.WriteLine($"Physics : {Physics}");
            Console.WriteLine($"Chemistry : {Chemistry}");
            Console.WriteLine($"Maths : {Maths}");
            Console.WriteLine($"Total : {Total}");
            Console.WriteLine($"Percentage Marks : {PercentageMarks}");   
        }
        
        
        
        
        
        
        
        
        
        
        
    }
}