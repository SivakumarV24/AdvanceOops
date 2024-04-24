using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramOne
{
    public interface IFamilyInfo : IShowData
    {
        // Property
        string FatherName { get; set; }
        string MotherName { get; set; }
        string HouseAddress { get; set; }
        int NumberOfSiblings { get; set; }  

        // Method Declaration
        
    }
}