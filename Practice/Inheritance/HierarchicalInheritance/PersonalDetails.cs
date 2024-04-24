using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    //Enum
    public enum Gender{
        Male,Female,Transgender
    }
    public class PersonalDetails 
    {
        //Field
        public static int s_userID=100;
        // Property
        public string UserID { get;  }     //Read Only  
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        //constructor
        public PersonalDetails(string name,string fatherName,Gender gender,string phoneNumber)
        {
            //Auto Increamentation
            s_userID++;
            // Assining value to property
            UserID="PID"+s_userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }
        public PersonalDetails(string userID,string name,string fatherName,Gender gender,string phoneNumber)
        {
            // Assining value to property
            UserID=userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }
        
        
        
        
        
        
        
        
    }
}