using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class Dress
    {
        
        // abstarct Property
        public abstract DressType DressType { get; set; } //Abstarct Property doesnot contains in Normal  Class ('Dress.DressType.get' is abstract but it is contained in non-abstract type 'Dress')
        public abstract string DressName { get; set; } //Abstarct Property doesnot contains in Normal  Class 
        public abstract int Price { get; set; } //Abstarct Property doesnot contains in Normal  Class 
        public abstract int  TotalPrice { get; set; } //Abstarct Property doesnot contains in Normal  Class 

        // abstract Method
        public abstract void GetDressInfo(); //Abstarct Method doesnot contains in Normal Class ('Dress.GetDressInfo()' is abstract but it is contained in non-abstract type 'Dress')
        public abstract void DisplaYInfo(); //Abstarct Method doesnot contains in Normal Class 
    }
}