using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramSix
{
    public class HDFC:Bank
    {
        public override double GetInterestInfo()
        {
            return 7.5;
        }
    }
}