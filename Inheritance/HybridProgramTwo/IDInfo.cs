using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridProgramTwo
{
    public class IDInfo:PersonalInfo
    {
        // property
        public string VoterID { get; }
        public string AadharID { get; }
        public string PANNumber { get; }
        // constructor
        public IDInfo(string voterID,string aadharID,string panNumber,string name, string fatherName, DateTime dob, string phone, Gender gender, string mobile):base(name,fatherName,dob,phone,gender,mobile)
        {
            VoterID=voterID;
            AadharID=aadharID;
            PANNumber=panNumber;
        }
        
    }
}