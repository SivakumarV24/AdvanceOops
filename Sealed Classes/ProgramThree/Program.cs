using System;
namespace ProgramThree;
class Program{
    public static void Main(string[] args)
    {
        // Create  a on=bject for EmployeeInfo andCall DisplayInfo(), Update()  method
        EmployeeInfo employeeInfo=new EmployeeInfo(new DateTime(2001,2,2),"vairamuthu","Vasantha",1,"Srivilliputtur","Sivakumar","9080745399","siva@gmail.com",Gender.Male);
        employeeInfo.DisplayInfo();
        employeeInfo.Update();
    }
}