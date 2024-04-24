using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    // enum
    /// <summary>
    /// OrderStatus enum used to store the fixed value 
    /// </summary>
    public enum OrderStatus{
        Default,Initiated,Ordered,Cancelled
    }
    /// <summary>
    /// OrderDetails class used to create a instance of order <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        // Field
        /// <summary>
        /// Static field s_orderId used to autoincreament of orderId of the instace <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderId=1000;
        // property
        /// <summary>
        /// OrderId used to store OrderID
        /// </summary>
        /// <value></value>
        public string OrderID { get; } //ReadOnly
        /// <summary>
        /// UserID property used to store userID
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// OrderDate property used to orderDate
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// TotalPrice property used to store TotalPrice
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// OrderStatus property used to store orderstatus
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        // constructor
        /// <summary>
        /// OrderDetails Constructor used to assign a initialize value to the property of the instance <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orderDate"></param>
        /// <param name="totalPrice"></param>
        /// <param name="orderStatus"></param>
        public  OrderDetails(string userId,DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            // Auto Increamentation
            s_orderId++;
            //Assigning value to property
            OrderID="OID"+s_orderId;
            UserID=userId;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
    }
}