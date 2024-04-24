using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PartialProgramOne
{
    public partial class EmployeeInfo
    {
        // constructor
        public EmployeeInfo(string name,Gender gender,DateTime dob,string mobile)
        {
            // Auto increamentation:
            s_employeeID++;
            //Assigning value to property
            EmployeeID="EID"+s_employeeID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;

        }
    }
}