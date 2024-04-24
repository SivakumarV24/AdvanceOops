using System;
namespace SingleInheritanceProgramOne;
class Program{
    public static void Main(string[] args)
    {
        // create a object for StudetInfo and HSCInfo
        StudentInfo student=new StudentInfo("11","CS",2022,"siva","kumar","9080745399","siva@gmail.com",new DateTime(2001,12,24),Gender.Male);
        StudentInfo student1=new StudentInfo("12","CS",2021,"kumar","siva","9953342457","kumar@gmail.com",new DateTime(2001,05,21),Gender.Male);
        Console.WriteLine($"******STUDENT 1********");
        student.ShowStudentDetails();   
        Console.WriteLine($"******STUDENT 2********");
        student1.ShowStudentDetails();
    }
}
