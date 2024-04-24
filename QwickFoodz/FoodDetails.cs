using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// Food Details class used to create a insatnce for food <see cref="Fooddetails"/>
    /// </summary>
    public class FoodDetails
    {
        //Field
        /// <summary>
        /// Static field s_foodId used to Auto increament the FoodID
        /// </summary>
        private static int s_foodID=2000;
        //property
        /// <summary>
        /// FoodID property used to store FoodID
        /// </summary>
        /// <value></value>
        public string FoodID { get;  } // Read Only
        /// <summary>
        /// FoodName property used to store FoodName
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }
        /// <summary>
        /// PricePerQuantity property used to store PricePerQuantity
        /// </summary>
        /// <value></value>
        public double PricePerQuantity { get; set; }
        /// <summary>
        /// QuantityAvailable property used to store AuantityAvailable
        /// </summary>
        /// <value></value>
        public int QuantityAvailable { get; set; }
        // constructor
        /// <summary>
        /// FoodDetails Constructor used to Assigna Default value to the Property
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="pricePerQuantity"></param>
        /// <param name="quantityAvailable"></param>
        public FoodDetails(string foodName, double pricePerQuantity, int quantityAvailable)
        {
            //Auto incrementation
            s_foodID++;
            // Assigning value to property
            FoodID ="FID"+s_foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
        }
        /// <summary>
        /// FoodDetails Constructor used to Assigna Default value to the Property
        /// </summary>
        /// <param name="food"></param>
        public FoodDetails(string food)
        {
            string[] value=food.Split(",");
            // Assigning value to property
            s_foodID=int.Parse(value[0].Remove(0,3));
            FoodID =value[0];
            FoodName = value[1];
            PricePerQuantity =double.Parse(value[2]);
            QuantityAvailable =int.Parse(value[3]);
        }

        
        
        
        
        
    }
}