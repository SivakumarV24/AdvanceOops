using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public partial class CustomList<Type>
    {
        /// <summary>
        /// private field _capacity used to store the _arrya capacity
        /// </summary>
        /// //Field
        private int _capacity;
         /// <summary>
        /// private field _count used to count of the element prsent in _arry
        /// </summary>
        private int _count;
        /// <summary>
        /// Type[] _array used to store the element
        /// </summary>
        private Type[] _array;
        //Property
        /// <summary>
        /// Capacity property used to store the Capacity
        /// </summary>
        /// <value></value>
        public int Capacity { get{return _capacity;} set{_capacity=value;} }
        /// <summary>
        /// Count Property used to store the Count
        /// </summary>
        /// <value></value>
        public int Count { get{return _count;}}
        //Indexers
        /// <summary>
        /// this[] it return the value of the index position of array
        /// </summary>
        /// <value></value>
        public Type this[int index]{
            get{return _array[index];} set{_array[index]=value;}
        }
        // constructor'
        /// <summary>
        /// CustomeList contructor used to assign a default value to the user
        /// </summary>
        public CustomList()
        {
           _capacity=5;
           _count=0;
           _array=new Type[_capacity];
        }
        //Add
        /// <summary>
        /// Aadd method used to add element into the _array
        /// </summary>
        /// <param name="elemet"></param>
        public void Add(Type elemet)
        {
            if(_capacity==_count)
            {
                IncreaseSize();
            }
            _array[_count]=elemet;
            _count++;
        }
        //IncreaseSize
        /// <summary>
        /// Increase Size method used to increase the _capacity of the _array
        /// </summary>
        public void IncreaseSize()
        {
            _capacity=_capacity*_capacity;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        //AddRange
        /// <summary>
        /// Addrange method used to add customlist into the _array.
        /// </summary>
        /// <param name="element"></param>
        public void AddRange(CustomList<Type> element)
        {
            _capacity=_count+element.Count+5;
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
    }
}