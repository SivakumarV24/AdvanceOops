using System;
namespace MultiLevelInheritanceProgramOne;
class Program{
    public static void Main(string[] args)
    {
        Console.Write($"Enter Your Name : ");
            string name=Console.ReadLine();
            Console.Write($"Enter Your Father Name : ");
            string fatherName=Console.ReadLine();
            Console.Write($"Enter Your Phone : ");
            string phone=Console.ReadLine();
            Console.Write($"Enter Your Mail : ");
            string mail=Console.ReadLine();
            Console.Write($"Enter Your DOB (dd/MM/yyyy):  ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write($"Enter Your Gender (Male,Female,Transgender): ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write($"Enter Standard : ");
            string standard=Console.ReadLine();
            Console.Write($"Enter Branch : ");
            string branch=Console.ReadLine();
            Console.Write($"Enter Acadamic Year : ");
            int  acadamicyear=int.Parse(Console.ReadLine());
            StudentInfo studentInfo=new StudentInfo(standard,branch,acadamicyear,name,fatherName,phone,mail,dob,gender);
            Console.WriteLine($"*********Get Marks*********");
            Console.Write($"Enter Physics Mark : ");
            int physicsMark=int.Parse(Console.ReadLine());
            Console.Write($"Enter Chemistry mark : ");
            int chemistryMark=int.Parse(Console.ReadLine());
            Console.Write($"Enter Maths Mark : ");      
            int mathsMark=int.Parse(Console.ReadLine());
            HSCDetails hSCDetails=new HSCDetails(physicsMark,chemistryMark,mathsMark,standard,branch,acadamicyear,name,fatherName,phone,mail,dob,gender,studentInfo.RegisterNumber);
        bool flag=true;
        do
        {
            Console.WriteLine($"******Menu********"); 
            Console.WriteLine($"1. Calculate Total");
            Console.WriteLine($"2. Calculate Percentage");
            Console.WriteLine($"3. Show My Details");
            Console.WriteLine($"4. Show Mark Sheet");
            Console.WriteLine($"5. Exit");            
            Console.WriteLine($"Enter the option : ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine($"Total Mark : {hSCDetails.CalculateTotal()} ");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Percentage : {hSCDetails.CalculatePercenatge()}");
                    break;                    
                }
                case 3:
                {
                    hSCDetails.ShowInfo();
                    break;
                }
                case 4:
                {
                    hSCDetails.ShowMarksheet();
                    break;
                }
                case 5:
                {
                    flag=false;
                    break;
                }
            }             
        } while (flag);
    }
}
