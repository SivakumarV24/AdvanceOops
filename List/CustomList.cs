using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace List
{
    public partial class CustomList<Type>
    {
        // Field
        private int _count;
        private int _capacity;
        private Type[] _array; // Generic type
        // property
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        // Indexer
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}

        }
        // Constructor
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _capacity=size;
        }
        //ADD METHOD
        public void Add(Type element)
        {
            if(Count==Capacity)
            {
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }
        //growSize
        void GrowSize()
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
            // asssign temp address to  array
            _array=temp;
            _count=_count+element.Count;
        }
        // Contains Method
        public bool Contains(Type element)
        {
            bool temp=false;
            foreach (Type data in _array)
            {
                if(data.Equals(element))
                {
                    temp=true;
                    break;
                }
            }
            return temp;
        }
        // IndexOf Method
        public int IndexOf(Type element)
        {
            int index=-1;
            for(int i=0;i<_count;i++)
            {
                if(element.Equals(_array[i]))
                {
                    index=i;
                    break;
                }
            }
            return index;
        }
        // Insert Method
        public void Insert(Type element,int index)
        {
            _capacity=_capacity+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count+1;i++)
            {
                if(i==index)
                {
                    temp[i]=element;
                }
                else if(i<index)
                {
                    temp[i]=_array[i];
                }
                else{
                    temp[i]=_array[i-1];
                }
            }
            _count++;
            _array=temp;
        }
        // RemoveAt Method
        public void RemoveAt(int index)
        {
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count-1;i++)
            {
                if(i>=index)
                {
                    _array[i]=_array[i+1];
                }
            }
            _count--;
        }
        // Remove Method
        public bool Remove(Type element)
        {
            int position=IndexOf(element);
            if(position>0)
            {
                RemoveAt(position);
                return true;
            }
            return  false;
        }
        // Reverse Method
        public void Reverse()
        {
            Type [] temp=new Type[_capacity];
            int j=0;
            for(int i=Count-1;i>=0;i--)
            {
                temp[j]=_array[i];
                j++;
            }
            _array=temp;
        }
        // InsertRange Method
        public void InsertRange(int index,List<Type> elements)
        {
            _capacity=_count+elements.Count+4;
            Type [] temp=new Type[_capacity];
            for(int i=0;i<index;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=index;i<elements.Count;i++)
            {
                temp[i]=elements[j];
                j++;
            }
            int k=index;
            for(int i=elements.Count;i<_count+elements.Count;i++)
            {
                temp[i]=_array[k];
                k++;
            }
            _array=temp;
        }
        // Sort Mehtod
        public void Sort() // bubble sort;
        {
            for(int i=0;i<_count-1;i++)
            {
                for(int j=0;j<_count-1;j++)
                {
                    if(IsGreater(_array[j],_array[j+1]))
                    {
                        Type temp=_array[j+1];
                        _array[j+1]=_array[j];
                        _array[j]=temp;
                    }
                }
            }
        }
        // Compare Two Type Method
        public bool IsGreater(Type value ,Type value1)
        {
            int result=Comparer<Type>.Default.Compare(value,value1);
            // value is greater 1
            // Value is less -1
            // Equal =0
            if(result>=0)
            {
                return true;
            }
            return false;
        }

    }
}