using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class EEEdepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override string Year { get; set; }
        // methods
        public override void SetBookInfo(string authorName,string bookName,string publisherName,string year)
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Serial Number : {SerialNumber}");
            Console.WriteLine($"AuthorName : {AuthorName}");
            Console.WriteLine($"Book Name : {BookName}");
            Console.WriteLine($"Publisher Name : {PublisherName}");
            Console.WriteLine($"Year :  {Year}"); 
        }
    }
}