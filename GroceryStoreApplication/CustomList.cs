using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public  class CustomList<Type>:IEnumerable,IEnumerator
    {
        // Field
        private  int _capacity;
        private int _count;
        private Type[] _array;
        // property
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        public int Count { get{return _count;} set{_count=value;} }
        // indexer
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        // constructor
        public CustomList()
        {
            _capacity=5;
            _count=0;
            _array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _capacity=size;
            _count=0;
            _array=new Type[_capacity];
        }
        // Add
        public void Add(Type element)
        {
            if(_capacity==_count)
            {
                IncreaseSize();
            }
            _array[_count]=element;
            _count++;
        }
        //IncreaseCount
        public void IncreaseSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
            
        }
        //AddRange Method
        public void AddRange(CustomList<Type> element)
        {
            _capacity=_count+element.Count+4;
            Type[] temp =new Type[_capacity];
            for(int i=0;i<Count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=_count;i<_count+element.Count;i++)
            {
                temp[i]=element[k];
                k++;  
            }
            _array=temp;
            _count=_count+element.Count;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
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