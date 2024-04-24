using System;
namespace SingleInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Default Value passing to personDetails
            PersonalDetails personalDetails=new PersonalDetails("Sivakumar","Vairamuthu",Gender.Male,"9080745399");
            // Printing Details
            Console.WriteLine($"Personal ID : {personalDetails.UserID}");
            Console.WriteLine($"Name : {personalDetails.Name}");
            Console.WriteLine($"Father Name : {personalDetails.FatherName}");
            Console.WriteLine($"Gender : {personalDetails.Gender}");
            Console.WriteLine($"Phone Number : {personalDetails.PhoneNumber}");

            //Create a object for StudentDetails
            StudentDetails student=new StudentDetails(personalDetails.UserID,personalDetails.Name,personalDetails.FatherName,personalDetails.Gender,personalDetails.PhoneNumber,"12th","10/04/2024");
            // Printing Details
            Console.WriteLine($"{student.Name}");
            Console.WriteLine($"{student.FatherName}");
            
            
        }
    }
}
