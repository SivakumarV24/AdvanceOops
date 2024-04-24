using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramTwo
{
    public interface IBrand
    {
        /*BrandName, ModelName*/
        string BrandName {get; set;}
        string ModelName {get; set;}
        void ShowDetails(); // Method Declaration
    }
}