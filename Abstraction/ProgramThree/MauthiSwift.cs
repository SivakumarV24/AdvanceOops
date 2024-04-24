using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    public class MaruthiSwift : Car
    {
        // constructor
        public MaruthiSwift(EngineType  engineType,int noOfSeats,int price,CarType carType):base(engineType,noOfSeats,price,carType)
        {

        }
        //  override Methods
        public override void GetEngineType()
        {
            Console.WriteLine($"GetEngineType");
            
        }
        public override void GetNoOfSeat()
        {
           Console.WriteLine($"GetNoOfSeat");
           
        }
        public override void GetPrice()
        {
            Console.WriteLine($"GetPrice");
            
        }
        public override void GetCarType()
        {
           Console.WriteLine($"GetCarType");
           
        }
        public override void DisplayCarDetail()
        {
           Console.WriteLine($"*****MaruthiSwift*******");
           Console.WriteLine($"GetEngineType");
           Console.WriteLine($"GetNoOfSeat");
           Console.WriteLine($"GetPrice");
           Console.WriteLine($"GetCarType");
           Console.WriteLine($"NoOfWheels");
           Console.WriteLine($"NoOfDoors");
           
           
           
        }
    }
}