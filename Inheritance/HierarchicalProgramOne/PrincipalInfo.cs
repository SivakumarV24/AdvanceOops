using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalProgramOne
{
    public class PrincipalInfo:PersonalInfo
    {
        // field
        private static int s_principalID=100;
        //property
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int  YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        // constructor
        public PrincipalInfo(string qualification,int yearOfExperience,DateTime dateOfJoining,string name,string fatherName,DateTime dob,string phone,Gender gender,string mail): base(name,fatherName,dob,phone,gender,mail)
        {
            // Auto increamentation
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        // Method
        public void ShowDetails()
        {
            Console.WriteLine($"********PrincipalInfo********");
            Console.WriteLine($"PrincipalID : {PrincipalID}");
             Console.WriteLine($"Principal Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Date Of Birth : {DOB}");
            Console.WriteLine($"Qualification : {Qualification}");
            Console.WriteLine($"YearOfExperience : {YearOfExperience}");
            Console.WriteLine($"DateOfJoining : {DateOfJoining}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"MailId : {Mail}");
        }
        
        
        
        
    }
}