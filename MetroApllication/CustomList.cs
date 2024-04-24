using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    public class CustomList<Type>
    {
        // Field
        private int _capacity;
        private int _count;
        private Type[] _array;
        //property
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        public int Count { get{return _count;} }

        // Indexers
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        // constructor
        public CustomList()
        {
            _capacity=10;
            _count=0;
            _array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _capacity=size;
            _count=0;
            _array=new Type[size];
        }
        // Method
        //Add
        public void Add(Type element)
        {
            if(_capacity==_count)
            {
                IncreaseSize();
            }
            _array[_count]=element;
            _count++;
        }
        //IncreaseSize
        public void IncreaseSize()
        {
            _capacity=_capacity*3;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        //AddRange
        public void AddRange(List<Type> element)
        {
            _capacity=_count+element.Count;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=_count;i<_capacity;i++)
            {
                temp[i]=element[j];
                j++;
            }
            _count=_capacity;
            _array=temp;
        }
        public int postion=-1;
    }
}