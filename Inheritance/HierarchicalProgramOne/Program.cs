using System;
namespace HierarchicalProgramOne;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for classes
        StudentInfo studentInfo=new StudentInfo("B.E","Mechanical","6","Sivakuamr","vairamuthu",new DateTime(2001,12,24),"9080745399",Gender.Male,"Siva@gmail.com");
        Teacher teacher=new Teacher("ComputerScience","OOps","M.E-CSE",2,new DateTime(2021,5,24),"Kumar","Siva",new DateTime(1992,3,4),"9952241939",Gender.Male,"Kumar@gmail.com");
        PrincipalInfo principalInfo=new PrincipalInfo("B.Ed",10,new DateTime(2006,3,4),"Siva","Kumar",new DateTime(1989,3,2),"9546748398",Gender.Male,"siva12@gmail.com");
        // calling Methods
        Console.WriteLine();
        studentInfo.ShowDetails();
        Console.WriteLine();
        teacher.ShowDetails();
        Console.WriteLine();
        principalInfo.ShowDetails();
    }
}
