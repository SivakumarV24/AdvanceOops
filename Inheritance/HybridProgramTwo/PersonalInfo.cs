using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramTwo
{
    public enum Gender
    {
        Male, Female, Transgender
    }
    public class PersonalInfo
    {
        // property
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        // constructor
        public PersonalInfo(string name, string fatherName, DateTime dob, string phone, Gender gender, string mobile)
        {
            Name = name;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            Mobile = mobile;
        }
    }
}