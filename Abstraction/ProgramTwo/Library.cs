using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public abstract class Library
    {
        // Field
        public static int s_serialNumber=1000;
        // normal property
        public string SerialNumber { get; set; }
        //Abstract property
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract string Year { get; set; }
        // Abstract Method
        public abstract void SetBookInfo(string authorName,string bookName,string publisherName,string year);
        public abstract void DisplayInfo();
        
        
        
        
        
        
        
        
        
    }
}