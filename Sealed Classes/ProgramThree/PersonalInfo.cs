using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    // enum
    public enum Gender{
        Male,Female,Transgender
    }
    public class PersonalInfo
    {
        // property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        
        //constructor
        public  PersonalInfo(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }
        //  Method
        //virtual Method
        public virtual void Update()
        {
            Console.WriteLine($"PersonInfo Update Method Called.");
            
        }
        // normal method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"*****PersonInfo******");
            Console.WriteLine($"Name :  {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"Mobile  : {Mobile}");
            Console.WriteLine($"Gender :  {Gender}");
            Console.WriteLine($"Mail : {Mail}");  
        }
        
        
        
        
        
        
        
        
        
    }
}