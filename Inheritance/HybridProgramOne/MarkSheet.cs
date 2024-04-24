using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramOne
{
    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        // field
        private static int s_markSheetNumber=1345;
        // Property
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double Total { get; set; }
        public double  Percentage { get; set; }
        public double ProjectMark{get; set;}

        public MarkSheet(int[] sem1,int[] sem2,int[] sem3,int[] sem4,string name,string fatherName,DateTime dob,string phone,Gender gender):base(sem1,sem2,sem3,sem4,name,fatherName,dob,phone,gender)
        {
            // Auto Increamentation
            s_markSheetNumber++;
            //Assigning Value to property
            MarkSheetNumber="MID"+s_markSheetNumber;
            DateOfIssue=DateTime.Now;
            (Total,Percentage)=CalculateUG();
        }
        public void ShowUGMarkSheet()
        {
            Console.WriteLine($"UG Mark Sheet");
            Console.WriteLine($"MarkSheetNumber : {MarkSheetNumber,-8}    Date of Issue : {DateOfIssue}");
            Console.WriteLine($"Semster 1 Percentage: {CalculateEachSemster(Sem1)/6}");
            Console.WriteLine($"Semster 2 Percentage: {CalculateEachSemster(Sem2)/6}");
            Console.WriteLine($"Semster 3 Percentage: {CalculateEachSemster(Sem3)/6}");
            Console.WriteLine($"Semster 4 Percentage: {CalculateEachSemster(Sem4)/6}");
            Console.WriteLine($"Over All Percentage : {Percentage}"); 
        }
        public double CalculateEachSemster(int[] sem)
        {
            double total=0;
            for(int i=0;i<sem.Length;i++)
            {
                total+=(double)sem[i];
            }
            return total;
        }
        public (double,double) CalculateUG()
        {
            double total=CalculateEachSemster(Sem1)+CalculateEachSemster(Sem2)+CalculateEachSemster(Sem3)+CalculateEachSemster(Sem4);
            double percentage=total/24;
            return (total,percentage);
        }
        
    }
}