using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class CircleCalculator : Calculator
    {
        // sealed Method
        public sealed override void Area(double radius)
        {
            Console.WriteLine($"Circle Area : {Math.Round(3.14 *radius*radius,2)}");    
        }
    }
}