using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class AreaCalculator
    {
        // property
        public double Radius { get; set; }
        // Virtual Method
        public virtual void Calculate()
        {
            Console.WriteLine($"Area : {Math.Round(3.14*Radius*Radius,2)}");            
        }
        
        
    }
}