using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    public abstract class Library
    {
        // field
        protected  static int s_serialNumber=1000;
        // property
        public string SerialNumber { get; set; }
        // abstact PRoperty
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public  abstract string Year { get; set; }
        
        
        // abstract Method
        public  abstract void SetBookInfo(string authorName,string bookName,string publisherName,string year);
        public abstract  void DisplayInfo();

        
        
        

        
        
        
        
        
        
    }
}