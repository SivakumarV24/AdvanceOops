using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    public class CSEDepartment:Library
     {
        // Property
        public override string AuthorName {  get; set;  }
        public override string BookName { get; set;  }
        public override string PublisherName { get; set;  }
        public override string Year { get; set; }


        //  overridden methos
        public override void SetBookInfo(string authorName, string bookName, string publisherName, string year)
        {
            // auto incrementation
            s_serialNumber++;
            // Assigning Value tp property
            SerialNumber = "LIB" + s_serialNumber;
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"CSE Department");
            Console.WriteLine($"Seral Number : {SerialNumber}");
            Console.WriteLine($"Author Name : {AuthorName}");
            Console.WriteLine($"Book Name : {BookName}");
            Console.WriteLine($"Publisher Name : {PublisherName}");
            Console.WriteLine($"Year :  {Year}");
        }
    }
}