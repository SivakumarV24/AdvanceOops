using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceProgramTwo
{
    public class BookInfo : RackInfo
    {
        private static  int s_bookID=100;
        // property
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        //  constructor
        public BookInfo(string bookName,string authorName,int price,int rackNumber,int columnNumber,string departmentName,string degree):base(rackNumber,columnNumber,departmentName,degree)
        {
            // Auto Increament
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"**********BookInfoDetails***********");
            Console.WriteLine($"Book ID : {BookID}");
            Console.WriteLine($"BOOK Name : {BookName}");
            Console.WriteLine($"AuthorName : {AuthorName}");
            Console.WriteLine($"Department Name : {DepartmentName}");
            Console.WriteLine($"Degree : {Degree}");
            Console.WriteLine($"RackNumber : {RackNumber}");
            Console.WriteLine($"ColumnNumber : {ColumnNumber}");
            Console.WriteLine($"Price : {Price}");
        }  
    }
}