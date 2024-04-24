using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public sealed class EmployeeInfo
    {
        // Field
        private static  int s_userID=100;
        // Property
        public string UserID { get; set;} // Read Only
        public string Password { get; set; }
        public int KeyInfo {get{return 100;} set{KeyInfo=100;}}
        // constructor
        public EmployeeInfo(string password)
        {
            // Auto increament
            s_userID++;
            // Assigning value to property
            UserID="UID"+s_userID;
            Password=password;
        }
        // Method
        public void UpdateInfo()
        {
           Console.WriteLine($"Updated Successfully");
           
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Info");
            Console.WriteLine($"Employee Name  :  {UserID}");
            Console.WriteLine($"Password : {Password}");
            Console.WriteLine($"KeyInfo : {KeyInfo}"); 
        }

    }
}