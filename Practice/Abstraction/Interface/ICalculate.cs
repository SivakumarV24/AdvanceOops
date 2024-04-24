using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        // No Field ,No constructor
        //Property
        int Number { get; set; } // Declaration Only
        int Calculate(); // Method - declaration
        
        
    }
}