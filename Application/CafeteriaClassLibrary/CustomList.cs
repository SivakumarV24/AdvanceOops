using System.Collections;
namespace CafeteriaClassLibrary;

public partial class CustomList<Type>
{
    // field
    private int _capacity;
    private int _count;
    private Type[] _array; //Generic Type
    // property
    public int Capacity { get{return _capacity;} set{_capacity=value;} }
    public int  Count { get{return _count;}} // ReadOnly
    // Indexer
    public Type this[int index]
    {
        get{return _array[index];}
        set{_array[index]=value;}
    }
    // Constructor
    public  CustomList()
    {
        _count=0;
        _capacity=5;
        _array=new Type[_capacity];
    }
    public CustomList(int size)
    {
        _capacity=size;
        _array=new Type[_capacity];
    }
    // Methods
    // Add Method
    public void Add(Type element)
    {
        if(_count==_capacity)
        {
            IncreaseSize();
        }
        _array[_count]=element;
        _count++;
    }
    // IncreaseSize
    public void  IncreaseSize()
    {
        _capacity=_capacity*2;
        Type[] temp=new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=_array[i];
        }
        _array=temp;
    }
    // AddRange
    public void AddRange(CustomList<Type> elements)
    {
        _capacity=_capacity+elements.Count+5;
        Type[] temp=new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=_array[i];
        }
        int j=0;
        for(int i=_count;i<_count+elements.Count;i++)
        {
            temp[i]=elements[j];
            j++;
        }
        _array=temp;
        _count=_count+elements.Count;
    }
}
