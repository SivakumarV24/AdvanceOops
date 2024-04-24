using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    // enum
    public enum Gender{
        Male,Female,Transgender
    }
    public class PersonDetails
    {
        // proeprty
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Qualification { get; set; }
        // Constructor
        public PersonDetails(string name,string fatherName,Gender gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}