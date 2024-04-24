using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Second : First
    {
        internal protected int internalProtected=50;
        public int ProtectedNumberOut {get{return ProtectedNumber;} set{ProtectedNumber=value;}}
    }
}