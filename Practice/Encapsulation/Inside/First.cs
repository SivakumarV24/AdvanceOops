using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using outside;

namespace Inside
{
    public class First :Third
    {
        // field
        private int _privateNumber = 10;
        public int PublicNumber=20;
        protected int ProtectedNumber=30;
        public int PrivateOut { get{return _privateNumber;} set{_privateNumber=value;} }
        public int outsideProtected {get{return InternalProtected;} set{InternalProtected=value;}}
    }
}