using System;
namespace ProgramFive;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo employeeInfo=new EmployeeInfo("siva","vairamuthu","9080745399",Gender.Male);
        employeeInfo.Display();
        Console.WriteLine();
        PersonalInfo  salaryInfo=new SalaryInfo(24,"sivakumar","vairamuthu","9080745399",Gender.Male);
        salaryInfo.Display();
    }
}