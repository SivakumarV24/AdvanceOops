using System;
namespace MultipleInheritanceProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for car
        Car car=new Car("petrol",5,"black","15 Litre",8000);
        // Create aobject for ECO
        Eco eco=new Eco("1234ADV2344","24e46sds","Suzuki","ECO",car.FuelType,car.NumberOfSeats,car.Color,car.TankCapacity,car.NumberOfKmDriven);
        eco.ShowDetails();
        // Create a object for car1
        Car car1=new Car("diesel",6,"White","20 LITRE",10000);
        // Create aobject for ECO
        ShiftDezire shiftDezire=new ShiftDezire("1234sedr34","233445sdf","Suzuki","ShiftDezire",car1.FuelType,car1.NumberOfSeats,car1.Color,car1.TankCapacity,car1.NumberOfKmDriven);
        shiftDezire.ShowDetails();
    }
}