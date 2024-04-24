using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceProgramTwo
{
     // enum
    public enum Gender{
        Male,Female,Transgender
    }
    public class PersonalInfo
    {
        /*Name, FatherName, Phone ,Mail, DOB, Gender*/
        //Property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        // constructor
        public PersonalInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender)
        {
            // assigning value to property
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}