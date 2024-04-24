using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        //field
        private int _capacity;
        int position;
        private int _count;
        private Type[] _array;
        //property
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        public int Count { get{return _count;} } // Read Only
        //indexers
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        //constructor
        public CustomList()
        {
            _capacity=10;
            _count=0;
            _array=new Type[_capacity];
        }
        // Method
        //Add
        public void Add(Type element)
        {
            if(_capacity==_count)
            {
                increaseSize();
            }
            _array[_count]=element;
            _count++;
        }
        public void increaseSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }
        public void AddRange(CustomList<Type> element)
        {
            _capacity=_capacity+element.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=_count;i<_count+element.Count;i++)
            {
                temp[i]=element[j];
                j++;
            }
            _array=temp;
            _count=_count+element.Count;

        }
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }
        public object Current{get{return _array[position];}}   
    }
}