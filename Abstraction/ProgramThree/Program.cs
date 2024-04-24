using System;
namespace ProgramThree;
class  Progam{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthiSwift=new MaruthiSwift(EngineType.Pertrol,5,400000,CarType.suv);
        maruthiSwift.DisplayCarDetail();
        SuzukiCiaz suzukiCiaz=new SuzukiCiaz(EngineType.disel,7,1000000,CarType.hatchback);
        suzukiCiaz.DisplayCarDetail();
    }
}
