using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramOne
{
    public interface ICalculate
    {
        double ProjectMark {get; set;}
        public (double,double) CalculateUG();
    }
}