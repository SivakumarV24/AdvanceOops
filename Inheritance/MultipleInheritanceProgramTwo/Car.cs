using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceProgramTwo
{
    public class Car
    {
        //Property
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public string TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        /*FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven*/
        // Method
        // CalcuateMilage Method
        public double CalcuateMilage(double fuel,double numberOfKmDriven)
        {
            
            return numberOfKmDriven/fuel;
        }
        public Car(string fuelType,int numberOFSeats,string color,string tankCapacity,double numberOfKmDriven)
        {
            FuelType=fuelType;
            NumberOfSeats=numberOFSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
        }
    }
}