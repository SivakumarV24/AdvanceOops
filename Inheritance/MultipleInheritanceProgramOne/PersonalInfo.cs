using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramOne
{
    //Enum
    public enum Gender{
        Male,Female,Transgender
    }
    public enum  MaritalDetails{
        Married,Single
    }
    public class PersonalInfo : IShowData
    {
        // Property
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public MaritalDetails MaritalDetails { get; set; }

        // Method Definition
        public PersonalInfo(string name,Gender gender,DateTime dob,string phone,MaritalDetails maritalDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MaritalDetails=maritalDetails;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"Marital Details : {MaritalDetails}");              
        }
        
        
        
        
        
        
        
        
        
        
        
        

    }
}