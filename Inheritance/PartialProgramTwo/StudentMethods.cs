using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramTwo
{
    public partial class Student
    {
        // Methods
        public void CalculateTotalAndPercentage()
        {
            double total=PhysicsMark+ChemistryMark+MathsMark;
            double percentage=total/3;
            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"Percentage : {Math.Round(percentage,2)}");
        }
        public void Display()
        {
            Console.WriteLine($"********Student Details********");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Student ID : {StudentID}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile : {Mobile}");
            Console.WriteLine($"PhysicsMark : {PhysicsMark}");
            Console.WriteLine($"Chemistry Mark : {ChemistryMark}");
            Console.WriteLine($"Maths Mark : {MathsMark}");
        }
    }
}