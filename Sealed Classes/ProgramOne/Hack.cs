using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class Hack :EmployeeInfo // 'Hack': cannot derive from sealed type 'EmployeeInfo'
    {
        // Field
        private static  int s_storeUserID=100;
        // Property
        public string StoreUserID { get; } // Read Only
        public string StorePassword { get; set; }
        // Method
        public void ShowKeyInfo()
        {
            Console.WriteLine($"KeyInfo : {KeyInfo}"); // The name 'KeyInfo' does not exist in the current context
        }
        public void GetUserInfo()
        {
            Console.WriteLine($"GetUserInfo");
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Employee Info");
            Console.WriteLine($"Employee Name  :  {UserID}");
            Console.WriteLine($"Password : {Password}");
            Console.WriteLine($"KeyInfo : {KeyInfo}")
        }

        
        
        
    }
}