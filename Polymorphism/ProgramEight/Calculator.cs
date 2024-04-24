using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ProgramEight
{
    public class Calculator
    {
        // property
        public int[] Sem { get; set; }
        public int TotalMark { get; set; }
        public double Percentage { get; set; }
        // constructor
        public Calculator(int[] sem)
        {
            Sem=sem;
            CalculateTotalMarkAndPercentage();
        }
        public void  CalculateTotalMarkAndPercentage()
        {
            for(int i=0;i<6;i++)
            {
                TotalMark+=Sem[i];
            }
            Percentage=(double)TotalMark/6;
        }
        public static Calculator operator+(Calculator sem1,Calculator sem2)
        {
            Calculator semster=new Calculator(new int[]{0,0,0,0,0,0});
            semster.TotalMark=sem1.TotalMark+sem2.TotalMark;
            return semster;
        }
    }
}