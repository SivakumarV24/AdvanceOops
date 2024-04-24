using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFive
{
    // enum
    public enum Gender{
        Male,Female,Transgender
    }
    public abstract class PersonalInfo
    {
        // property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        public Gender Gender { get; set; }
        // Abstract Method
        public PersonalInfo(string name,string fatherName,string mobileNumber,Gender gender )
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
        }
        public abstract void Display();  
    }
}