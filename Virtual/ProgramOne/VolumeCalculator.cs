using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class VolumeCalculator:AreaCalculator
    {
        // property
        public double Height { get; set; }
        // Virtual Method
        public override void Calculate()
        {
            Console.WriteLine($"Volume : {Math.Round(3.14*Radius*Radius*Height,2)}");            
        }
    }
}