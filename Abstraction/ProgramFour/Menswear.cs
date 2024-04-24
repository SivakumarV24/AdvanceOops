using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    // enum
    public enum DressType{
        Ladieswear,Menswear,Childrenswear
    }
    public class Menswear
    {
         // Override Method
        public override void GetDressInfo() // it doesnot overiride this method because we donot inhherit the parent class ('Menswear.GetDressInfo()': no suitable method found to override)
        {
            Console.WriteLine($"Get Dress Info : {GetDressInfo}");
            
        }
        public override void DisplayInfo()   // it doesnot overiride this method because we donot inhherit the parent class.
        {
            double totalPrice=Price*30/100; // doesnot access Price property because we donot inherit the  parent class (The name 'Price' does not exist in the current context)
            Console.WriteLine($"Your Bill : {totalPrice}");
        }
  
    }
}