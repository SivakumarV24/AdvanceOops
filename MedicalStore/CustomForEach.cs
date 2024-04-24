using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
        //field
        /// <summary>
        /// position property used to define the index the _array
        /// </summary>
        int position;
        // property
        /// <summary>
        /// cuurent property used to Store Current Proeprty
        /// </summary>
        /// <value></value>
        public object Current{get{return _array[position];}}
        //GetEnumerator
        /// <summary>
        /// GetEnumerator return the value of the current postion of the _array
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        //MoveNext()
        /// <summary>
        /// MoveNext() method used to increament the position
        /// </summary>
        /// <returns></returns>
        public bool  MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        //Reset()
        /// <summary>
        /// Reset Method used to set a postion=-1 when the MoveNext() return false.
        /// </summary>
        public void Reset()
        {
            position=-1;
        }

    }
}