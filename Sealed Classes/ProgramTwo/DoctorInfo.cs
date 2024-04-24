using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class DoctorInfo : PatientInfo // 'DoctorInfo': cannot derive from sealed type 'PatientInfo'
    {
        // Field 
        private static int s_doctorID=100;
        // property
        public string DoctorID { get; } // ReadOnly
        public string Name { get; set; }
        public string FatherName { get; set; }
        // constructor
        public DoctorInfo(string name,string fatherName,string patientId,string patientName,string patientFatherName,int bedNo,string nativePlace,string admittedFor):base (patientId,patientName,patientFatherName,bedNo,nativePlace,admittedFor)//'object' does not contain a constructor that takes 6 argument
        {
            s_doctorID++;
            DoctorID="DID"+s_doctorID;
            Name=name;
            FatherName=fatherName;
        }
        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"******PatientInfo********");
            Console.WriteLine($"Doctor ID : {DoctorID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            
        }
        
    }
}