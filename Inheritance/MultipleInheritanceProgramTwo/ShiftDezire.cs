using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramTwo
{
    public class ShiftDezire : Car,IBrand
    {
        //Field
        public static  int s_makingID=100;
        /*MakingID(Auto), EngineNumber, ChasisNumber*/
        // property
        public string MakingID { get; }// Read only
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        
        
        
        
        // constructor
        public ShiftDezire(string engineNumber,string chasisNumber,string brandName,string modelName,string fuelType,int numberOFSeats,string color,string tankCapacity,double numberOfKmDriven): base(fuelType,numberOFSeats,color,tankCapacity,numberOfKmDriven)
        {
            // Auto Increamentation
            s_makingID++;
            // Assigning Value to Property
            MakingID="MID"+s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }
        //Method
        public void ShowDetails()
        {
            Console.WriteLine($"*********ShiftDezire*************");
            Console.WriteLine($"Brand Name : {BrandName}");
            Console.WriteLine($"Model Name : {ModelName}");
            Console.WriteLine($"Engine Number : {EngineNumber}");
            Console.WriteLine($"Chasis Number : {ChasisNumber}");
            Console.WriteLine($"Fuel Type : {FuelType}");
            Console.WriteLine($"Number OF Seats : {NumberOfSeats}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Tank Capacity : {TankCapacity}");
            Console.WriteLine($"Number Of Driven : {TankCapacity}");   
        }
    }
}