using System;
namespace ProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        PatientInfo patientInfo=new PatientInfo("siva","fatherName",9,"chennai","fever");
        patientInfo.DisplayInfo();
        DoctorInfo doctorInfo=new DoctorInfo("kumar","siva",patientInfo.PatientID,"siva","fatherName",9,"chennai","fever");
        doctorInfo.DisplayInfo();
    }
}