using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        // Field
        private double _length;
        private double _breath;
        private double _height;
        // Constructor
        public Box(double length,double breath,double height)
        {
            _breath=breath;
            _height=height;
            _length=length;
        }
        // Method

        public double CalculateVolume()
        {
            return _height*_breath*_length;
        }
        public static Box Add(Box box1,Box box2)
        {
            
            Box box=new Box(0,0,0);
            box._length=box1._length+box2._length;
            box._breath=box1._breath+box2._breath;
            box._height=box1._height+box2._height;  
            return box;
        }
        public static Box operator+(Box box1,Box box2)
        {
            Box box=new Box(0,0,0);
            box._length=box1._length+box2._length;
            box._breath=box1._breath+box2._breath;
            box._height=box1._height+box2._height;
            return box;
        }
    }
}