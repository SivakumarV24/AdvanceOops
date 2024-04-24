using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    public class FamilyInfo : PersonalInfo
    {
        // property
        public string FstherName { get; set; }
        
        
        public string MotherName { get; set; }
        public int NoOfSibilings { get; set; }
        public string NativePlace { get; set; }
        // constructor
        public FamilyInfo(string fatherName,string motherName,int noOfSibilings,string nativePlace,string name,string mobile,string mail,Gender gender): base(name,fatherName,mobile,mail,gender)
        {
            FatherName=fatherName;
            MotherName=motherName;
            NoOfSibilings=noOfSibilings;
            NativePlace=nativePlace;
        }

        // sealed Overide method
        public sealed override void Update()
        {
            Console.WriteLine($"Enter Name : ");
            string name=Console.ReadLine();
            Console.WriteLine($"Enter FatherName :");
            string fatherName=Console.ReadLine();
            Console.WriteLine($"Enter Mother Name :");
            string motherName=Console.ReadLine();
            Console.WriteLine($"Enter Your Native Place : ");
            string native=Console.ReadLine();
            Name=name;
            FatherName=fatherName;
            MotherName=motherName;
            NativePlace=native;
            Console.WriteLine($"Updated Successfully.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"EmployeeID DisplayInfo ");
            
        }
    }
}