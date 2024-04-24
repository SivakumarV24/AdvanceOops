using System;
namespace List;
class Program{
    public static void Main(string[] args)
    {
        CustomList<int> customList=new CustomList<int>();
        // Add number in _arry
        customList.Add(20);
        customList.Add(89);
        customList.Add(90);
        customList.Add(79);
        customList.Add(59);
        Console.Write($"Before Added List :");
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i]}  ");
            
        }
        Console.WriteLine();
        
        CustomList<int> customList1=new CustomList<int>();
        customList.Add(80);
        customList.Add(90);
        customList.AddRange(customList1);
        customList.RemoveAt(2);
        Console.Write($"After Added List :");
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i]}  ");
            
        }
        Console.WriteLine();
        customList.Insert(3,3);
        Console.Write($"After insert Element :");
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i]}  ");
            
        }
        Console.WriteLine();
        customList.RemoveAt(0);
        Console.Write($"After Remove Element : ");
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i]}  ");
            
        }
        Console.WriteLine();
        customList.Sort();
        Console.Write($"Sorting :");        
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i]}  ");
            
        }
        Console.WriteLine();
        customList.Reverse();
        Console.Write($" Reverse:");
        
        for(int i=0;i<customList.Count;i++)
        {
            Console.Write($"{customList[i] }  ");
            
        }
        Console.WriteLine();
        Console.WriteLine($"Index Of {customList.IndexOf(3)}");
        Console.WriteLine($"Contains {customList.Contains(90)}");
        Console.WriteLine($"Contains {customList.Contains(100)}");
    }
}