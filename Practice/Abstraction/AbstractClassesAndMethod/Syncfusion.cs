using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethod
{
    public class Syncfusion : Employee
    {
        // Abstract Property Definition
        public override string Name { get {return _name;} set {_name=value;} }
        // Abstract Method Defintion
        public override double Salary(int days)
        {
            Amount=(double)days*500;
            return Amount;
        }

    }
}