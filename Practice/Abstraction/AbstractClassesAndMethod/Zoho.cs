using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethod
{
    public class Zoho:Employee
    {
        // Abstarct Property Definition
        public override string Name { get{return _name;} set{_name=value;} }
        // Abstarct Method Definition
        public override double Salary(int days)
        {
            Amount=(double)days*1000;
            return Amount;
        }
    }
}