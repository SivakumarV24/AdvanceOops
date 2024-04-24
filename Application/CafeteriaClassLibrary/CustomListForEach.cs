using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int positon;
        public IEnumerator GetEnumerator()
        {
            positon=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(positon<_count-1)
            {
                positon++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            positon=-1;
        }
        public object Current{get {return _array[positon];}}
    }
}