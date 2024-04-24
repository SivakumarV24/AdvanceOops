using System;
using MultipleInheritanceProgramOne;
namespace MultiplaeInheritanceProgramOne;
class Program{
    public static void Main(string[] args)
    {
        // calling PersionalInfo 
        Console.WriteLine($"**************Person -1********************");
        
        PersonalInfo personalInfo=new PersonalInfo("sivakumar",Gender.Male,new DateTime(2001,12,24),"9080745399",MaritalDetails.Single);
        personalInfo.ShowInfo();
        Console.WriteLine();        
        RegisterPerson registerPerson=new RegisterPerson(DateTime.Now,"Vairamuthu","Vasantha","62B,Mallapuram Street",1,personalInfo.Name,personalInfo.Gender,personalInfo.DOB,personalInfo.Phone,personalInfo.MaritalDetails);
        registerPerson.ShowInfo();
        Console.WriteLine();
        Console.WriteLine($"********************Person -2******************");
        
        PersonalInfo personalInfo1=new PersonalInfo("Surya",Gender.Male,new DateTime(2001,05,21),"6380496449",MaritalDetails.Single);
        personalInfo1.ShowInfo();
        Console.WriteLine();        
        // calling RegistrationPerson
        RegisterPerson registerPerson1=new RegisterPerson(DateTime.Now,"Sundari","Sundar","34,Mallpuram Stret",1,personalInfo1.Name,personalInfo1.Gender,personalInfo1.DOB,personalInfo1.Phone,personalInfo1.MaritalDetails);
        registerPerson1.ShowInfo();
        Console.WriteLine();
        
    }
}