using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalProgramOne
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
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string Mail { get; set; }
        // constructor
        public PersonalInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail)
        {
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
        }
    }
}