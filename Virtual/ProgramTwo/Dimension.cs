using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class Dimension
    {
        // property
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }
        // Virtual Method
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area :{Math.Round(Value1*Value2,2)}");
        }       
        
    }
}