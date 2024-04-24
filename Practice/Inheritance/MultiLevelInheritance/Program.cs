using System;
namespace MultiLevelInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Default Value passing to personDetails
            PersonalDetails personalDetails=new PersonalDetails("Sivakumar","Vairamuthu",Gender.Male,"9080745399");
            // Printing Details
            // Console.WriteLine($"Personal ID : {personalDetails.UserID}");
            // Console.WriteLine($"Name : {personalDetails.Name}");
            // Console.WriteLine($"Father Name : {personalDetails.FatherName}");
            // Console.WriteLine($"Gender : {personalDetails.Gender}");
            // Console.WriteLine($"Phone Number : {personalDetails.PhoneNumber}");

            //Create a object for StudentDetails
            StudentDetails student=new StudentDetails(personalDetails.UserID,personalDetails.Name,personalDetails.FatherName,personalDetails.Gender,personalDetails.PhoneNumber,"12th","10/04/2024");
            
            // Create a objecct for EmployeeDetails
            EmployeeDetails employeeDetails=new EmployeeDetails(student.UserID,student.Name,student.FatherName,student.Gender,student.PhoneNumber,student.StudentID,student.Standard,student.YearOfJoining,"Software Engineer");
            
            
        }
    }
}
