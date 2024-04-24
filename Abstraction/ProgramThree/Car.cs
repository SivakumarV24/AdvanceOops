using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramThree
{
    //enum
    public enum EngineType{
        Pertrol,disel,cng

    }
    public enum CarType{
        hatchback,sedan,suv
    }
    public  class Car
    {
        
        // Field
        public int NoOfWheels=4;
        public int NoOfDoors=4;
        // property
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public int Price { get; set; }
        
        
        public CarType CarType { get; set; }
        // Method
        public void ShowWheels()
        {
            Console.WriteLine($"NO of Wheels : {NoOfWheels}");
            
        }
        public void ShowDoors()
        {
            Console.WriteLine($"No of Doors : {NoOfDoors}");
            
        }
        public Car(EngineType  engineType,int noOfSeats,int price,CarType carType)
        {
            EngineType=engineType;
            NoOfSeats=noOfSeats;
            Price=price;
            CarType=carType;
        }
        //AbstractMethod
        public abstract void GetEngineType(); // Non Abstract class  Doesnot contain Abstract Method it shows ("'Car.GetEngineType()' is abstract but it is contained in non-abstract type 'Car")
        public  abstract void  GetNoOfSeat(); // Non Abstract class  Doesnot contain Abstract Method
        public abstract void GetPrice(); // Non Abstract class  Doesnot contain Abstract Method
        public abstract  void GetCarType(); // Non Abstract class  Doesnot contain Abstract Method
        public abstract void DisplayCarDetail(); // Non Abstract class  Doesnot contain Abstract Method

        
        

    }
}