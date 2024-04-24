using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramSeven
{
    public class Attendance
    {
        // property
        public int TotalWorkingDaysInMonth { get; set; }
        public int NumberOfLeavesTaken { get; set; }
        public int NumberOfPermissionsTaken { get; set; }
        // constructor
        public Attendance(int totalWorkingDaysInMonth,int numberOfLeavesTaken,int  numberOfPermissionsTaken)
        {
            TotalWorkingDaysInMonth=totalWorkingDaysInMonth;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissionsTaken=numberOfPermissionsTaken;
        }
        public static Attendance Add(Attendance attendance1,Attendance attendance2,Attendance attendance3)
        {
            Attendance totalAttendance=new Attendance(0,0,0);
            totalAttendance.TotalWorkingDaysInMonth=attendance1.TotalWorkingDaysInMonth+attendance2.TotalWorkingDaysInMonth+attendance3.TotalWorkingDaysInMonth;
            totalAttendance.NumberOfLeavesTaken=attendance1.NumberOfLeavesTaken+attendance2.NumberOfLeavesTaken+attendance3.NumberOfLeavesTaken;
            totalAttendance.NumberOfPermissionsTaken=attendance1.NumberOfPermissionsTaken+attendance2.NumberOfPermissionsTaken+attendance3.NumberOfPermissionsTaken;
            return totalAttendance;
        }
        public void CalculateSalary(Attendance attendance)
        {
            int numberOfDaysWorked=attendance.TotalWorkingDaysInMonth-attendance.NumberOfLeavesTaken-attendance.NumberOfPermissionsTaken;
            Console.WriteLine($"Total Salary : {numberOfDaysWorked*500}");
        }
    }
}