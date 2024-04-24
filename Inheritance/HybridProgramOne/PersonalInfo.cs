using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramOne
{
    public enum Gender{
        Male,Female,Transgender
    }
    public class PersonalInfo
    {
        //field
        private static int s_registrationNumber=100;
        //property
        public string RegistrationNumber {get;set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set;}
        // constructor
        public PersonalInfo(string name,string fatherName,DateTime dob,string phone,Gender gender)
        {
            s_registrationNumber++;
            RegistrationNumber="RID"+s_registrationNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
        }
              
        
    }
}