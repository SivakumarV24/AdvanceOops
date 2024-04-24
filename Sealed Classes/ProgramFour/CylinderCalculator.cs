using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class CylinderCalculator:Calculator
    {
        // override method
        public override void Area(double radius)
        {
             Console.WriteLine($"Circle Area : {Math.Round(3.14 *radius*radius,2)}"); 
        }
        public override void Volume()
        {
            Console.WriteLine($"CylinderCalculator volume Called.");
            
        }
    }
}