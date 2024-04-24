using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
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
        //  Constructor
        public PersonalInfo(string name,string fathername,string mobile,string mail,Gender gender)
        {
            Name=name;
            FatherName=fathername;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }
        // Methods
        public void UpdateInfo()
        {
           Console.WriteLine($"Updated Successfully");
           
        }

        
        
        
        
        
        
        
        
        
        
    }
}