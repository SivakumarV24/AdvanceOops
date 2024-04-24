using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public  sealed class PatientInfo
    {
        // Field 
        private static int s_patientID=100;
        // property
        public string PatientID { get; } // ReadOnly
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        // constructor
        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        public PatientInfo(string  patientID,string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            PatientID=patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"******PatientInfo********");
            Console.WriteLine($"Patient Info : {PatientID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Bed No : {BedNo}");
            Console.WriteLine($"NativePlace : {NativePlace}");
            Console.WriteLine($"AdmittedFor : {AdmittedFor}");   
            
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}