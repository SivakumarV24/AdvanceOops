using System;
namespace ProgramTwo;
class ProgramTwo{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo=new StudentInfo("Siva","Vairamuthu","9080745399");
        EmployeeInfo employeeInfo=new EmployeeInfo("Sivakumar","Vairamuthu","9952241939");
        studentInfo.Display();
        employeeInfo.Display();
    }
}