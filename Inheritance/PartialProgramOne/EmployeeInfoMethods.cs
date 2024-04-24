using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramOne
{
    public partial class EmployeeInfo
    {
        //Methods
        public void Update()
        {
            Console.WriteLine($"Update Mehtod Called.");
        }
        public void Display()
        {
            Console.WriteLine($"********Employee Details*******");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB :  {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile : {Mobile}");  
        }   
    }
}