using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramOne
{
    // enum
    public enum Gender{
        Male,Female,Transgender
    }
    public partial class EmployeeInfo
    {
        //Field
        private static int s_employeeID=100;
        // peoperty
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string Mobile  { get; set; }
        
        
        
        
        
        
        
        
        
    }
}