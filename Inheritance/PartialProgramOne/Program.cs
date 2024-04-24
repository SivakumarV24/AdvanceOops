using System;
namespace PartialProgramOne;
class Program{
    public static void Main(string[] args)
    {
        // create a object
        EmployeeInfo employeeInfo=new EmployeeInfo("Sivakumar",Gender.Male,new DateTime(2001,12,24),"9080745399");
        employeeInfo.Update();
        employeeInfo.Display();
    }
}