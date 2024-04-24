using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramOne
{
    public class RegisterPerson: PersonalInfo,IShowData,IFamilyInfo
    {
        // Field
        private static int s_registrationNumber=1000;
        // property
        public string RegistrationNumber { get; } // Read Only
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NumberOfSiblings { get; set; }

        // ShowInfo
        public RegisterPerson(DateTime dateOfRegistration,string fatherName,string mothername,string houseAddress,int numberOfSiblings,string name,Gender gender,DateTime dob,string phone,MaritalDetails maritalDetails): base(name,gender,dob,phone,maritalDetails)
        {
            // Auto Increamentation
            s_registrationNumber++;
            // Assigning Value to Property
            RegistrationNumber="RID"+s_registrationNumber;
            DateOfRegistration=dateOfRegistration;
            FatherName=fatherName;
            MotherName=mothername;
            HouseAddress=houseAddress;
            NumberOfSiblings=numberOfSiblings;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"RegistrationNumber :  {RegistrationNumber}");            
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name  : {FatherName}");
            Console.WriteLine($"Mother Name : {MotherName}");           
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"Marital Details : {MaritalDetails}");   
            Console.WriteLine($"House Address : {HouseAddress}");
            Console.WriteLine($"NumberOfSiblings : {NumberOfSiblings}");
            
                       
        }
        
        
        
        
        
        
        



        
        
        
        

    }
}