using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// ItemDetails class is used to Create a  instance of a Item <see cref="QwickFoodzk"/>
    /// </summary>
    public class ItemDetails
    {
        //Field
        /// <summary>
        /// static field s_itemId is used to AutoIncreamentation of the ItemID
        /// </summary>
        private static int s_itemID=4000;
        //property
        /// <summary>
        /// ItemID  Proeprty  used to Store the ItemID
        /// </summary>
        /// <value></value>
        public string ItemID { get; } // Read Only
        /// <summary>
        /// OrderId Proeprty  used to Store the OrderID
        /// </summary>
        /// <value></value>
        public string OrderID { get; } // Read Only
        /// <summary>
        /// FoodID Proeprty  used to Store the FoodID
        /// </summary>
        /// <value></value>
        public string FoodID { get; } // Read Only
        /// <summary>
        /// PurchaseCount Property used to Store the ItemID
        /// </summary>
        /// <value></value>
        public int PurchaseCount { get; set; }
        /// <summary>
        /// PriceOrder Proeprty used to Store the ItemID
        /// </summary>
        /// <value></value>
        public double PriceOfOrder { get; set; }
        // constructor
        /// <summary>
        /// ItemDetails construtor used to Assign a Defaukt value to the  property
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="purchaseCount"></param>
        /// <param name="priceOfOrder"></param>
        public ItemDetails(string orderID, string foodID, int purchaseCount, double priceOfOrder)
        {
            //Auto increamentation
            s_itemID++;
            // Assigning value to property
            ItemID="ITID"+s_itemID;
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        /// <summary>
        /// ItemDetails construtor used to Assign a Defaukt value to the  property
        /// </summary>
        /// <param name="item"></param>
        public ItemDetails(string item)
        {
            string[] value=item.Split(",");
            s_itemID=int.Parse(value[0].Remove(0,4));
            // Assigning value to property
            ItemID=value[0];
            OrderID = value[1];
            FoodID = value[2];
            PurchaseCount =int.Parse(value[3]);
            PriceOfOrder = double.Parse(value[4]);
        }

        
        
        
        
        
        
        
    }
}