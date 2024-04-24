using System;
namespace MultilevelInheritanceProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // Create aobject for BookInfo
        BookInfo bookInfo=new BookInfo("c#","AAA",200,2,4,"CSE","B.E");
        BookInfo bookInfo1=new BookInfo("c++","BBB",240,3,4,"CSE","B.E");
        BookInfo bookInfo2=new BookInfo("java","CCC",260,4,4,"CSE","B.E");
        Console.WriteLine($"******BOOK 1********");
        bookInfo.DisplayInfo();
        Console.WriteLine($"******BOOK 2********");
        bookInfo1.DisplayInfo();
        Console.WriteLine($"******BOOK 3********");
        bookInfo2.DisplayInfo();
    }
}