using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramTwo
{
    public interface ICalculate
    {
        public void Deposit();
        public void Withdraw();
        public void BalanceCheck();
    }
}