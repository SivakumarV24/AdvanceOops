using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    /// <summary>
    /// CartItem Class used to create a instance for user <see cref="CartItem"/>
    /// </summary>
    public class CartItem
    {
        // Field
        /// <summary>
        /// static Field s_itemID used to autoincreament ItemID  of the instance of <see cref="CartItem"/
        /// </summary>
        private static int s_itemID=100;
        //property
        /// <summary>
        /// ItemID property used to store itemID
        /// </summary>
        /// <value></value>
        public string ItemID { get;} // ReadOnly 
        /// <summary>
        /// OrderID property used to store OrderID
        /// </summary>
        /// <value></value>    
        public string OrderID { get; set; }
        /// <summary>
        /// FoodID property used to store FoodID
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }
        /// <summary>
        /// OrderPrice property used to store OrderPrice
        /// </summary>
        /// <value></value>
        public double OrderPrice { get; set; }
        /// <summary>
        /// OrderQuantity property used to store OrderQuantity
        /// </summary>
        /// <value></value>
        public int OrderQuantity { get; set; }
        /// <summary>
        /// ItemID property used to store itemID
        /// </summary>
        /// <value></value>
        //constructor
        /// <summary>
        /// CartItem Constructor used to initialize default values to its Properties. <see cref="CartItem"/>
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="orderPrice"></param>
        /// <param name="orderQuantity"></param>
        public CartItem(string orderID,string foodID,double orderPrice,int orderQuantity)
        {
            // Auto Increamentation
            s_itemID++;
            //Assigning value to property
            ItemID="ITI"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
    }
}