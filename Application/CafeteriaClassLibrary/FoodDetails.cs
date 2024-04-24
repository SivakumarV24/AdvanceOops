using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    /// <summary>
    /// FoodItem Class used to create a instance for foodDetails <see cref="FoodItem"/>
    /// </summary>
    public class FoodDetails
    {
        // Field
        /// <summary>
        /// static field s_foodId used to autoincreament of FoodId of the instance <see cref="FoodDetails"/>
        /// </summary>
        private static int s_foodID=100;
        //Property
        /// <summary>
        /// FoodID Property used to store FoodID
        /// </summary>
        /// <value></value>
        public string FoodID { get;  } // Read Only
        /// <summary>
        /// FoodName property used to store FoodName
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }
        /// <summary>
        /// FoodPrice property used to store FoodPrice
        /// </summary>
        /// <value></value>
        public double FoodPrice { get; set; }
        /// <summary>
        /// AvailableQuantity property used to store AvailableQuantity
        /// </summary>
        /// <value></value>
        public int AvailableQuantity { get; set; }
        // Constructor
        /// <summary>
        /// FoodDetails constructor used to store a initialize value of the instance <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodPrice"></param>
        /// <param name="availableQuantity"></param>
        public FoodDetails(string foodName,double foodPrice,int availableQuantity)
        {
            // Auto Increamentation
            s_foodID++;
            //Assigning value to property
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
        }   
    }
}