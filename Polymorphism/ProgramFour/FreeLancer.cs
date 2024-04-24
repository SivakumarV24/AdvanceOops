using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class FreeLancer: PersonDetails
    {
        // property
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }        
        // constructor
        public FreeLancer(string role,int noOfWorkingDays,string name,string fatherName,Gender gender,string qualification) : base(name,fatherName,gender,qualification)
        {
            Role=role;
    
            NoOfWorkingDays=noOfWorkingDays;
            CalculateSalary();
        }
        public virtual void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            Console.WriteLine($"{Math.Round(SalaryAmount,2)}");
        }
        public virtual void Display()
        {
            Console.WriteLine($"EmployeeDetails");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gener : {Gender}");
            Console.WriteLine($"Qualification : {Qualification}");
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine($"SalaryAmount :  {SalaryAmount}"); 
        }

    }
}