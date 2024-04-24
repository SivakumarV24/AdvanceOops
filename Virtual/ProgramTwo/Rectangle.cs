using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class Rectangle : Dimension
    {
        // property
        public double Length { get; set; }
        public double Height { get; set; }
        // constructor
        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area : {Math.Round(Length*Height,2)}");
            
        }
        
        
        
        

    }
}