using System;
using System.Security.Cryptography.X509Certificates;
namespace  ProgramSeven;
class Program{
    public static void Main(string[] args)
    {
        // create a three  object for attendance
        Attendance may=new Attendance(24,2,1);
        Attendance june=new Attendance(23,0,1);
        Attendance july=new Attendance(24,0,0);
        // Adding three Objecct
        Attendance result=Attendance.Add(may,june,july);
        Console.WriteLine($"Number ofWorking Days :  {result.TotalWorkingDaysInMonth}");
        Console.WriteLine($"Number of Levae Taken : {result.NumberOfLeavesTaken}");
        Console.WriteLine($"Number of Permission Taken : {result.NumberOfPermissionsTaken}");
        // calculate Salary
        result.CalculateSalary(result);
    }
}