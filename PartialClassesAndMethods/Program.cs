using System;
using PartialClassesAndMethods;
namespace PartialClassesAndMethod;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails personal=new PersonalDetails();
        personal.DOB=new DateTime(2001,12,24);
        personal.CalculateAge();
    }
}