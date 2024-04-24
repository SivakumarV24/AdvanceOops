using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        //Field
        private int _capacity;
        private int _count;
        int positon;
        private Type[] _array;
        //property
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        public Object Current{get{return _array[positon];}} //Read Only
        public int  Count { get{return _count;} } //Read Only
        //indexers
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        //construtor
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
        //Method
        //Add
        public void Add(Type element)
        {
            if(_capacity==_count)
            {
                IncreaseSize();
            }
            for(int i=_count;i>0;i--)
            {
                _array[i]=_array[i-1];
            }
            _array[0]=element;
            _count++;
        }
        //AddRange
        public void AddRange(CustomList<Type> element)
        {
            _capacity=_count+element.Count+4;
            Type[] temp=new Type[_capacity];
            int j=0;
            for(int i=element.Count-1;i>=0;i--)
            {
                temp[j]=element[i];
                j++;
            }
            j=element.Count;
            for(int i=0;i<_count;i++)
            {
                temp[j]=_array[i];
                j++;
            }
            _count=_count+element.Count;
            _array=temp;
        }
        // IncreaseSize()
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
        
        // getEnummerator
        public IEnumerator GetEnumerator()
        {
            positon=-1;
            return (IEnumerator)this;
        }
        //MoveNext()
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
        //Reset();
        public void Reset()
        {
            positon=-1;
        }
        
        
    }
}