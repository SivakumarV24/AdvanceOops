using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    // enum
    /// <summary>
    /// OrderStatus Datatype used to store OrderStatus
    /// </summary>
    public enum OrderStatus{
        Default,Initiated,Ordered,Cancelled
    }
    /// <summary>
    /// OrderDetsils class used to create a instance of the Order <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        //field
        /// <summary>
        /// static field s_orderID used to auto increamentation of the OrderID
        /// </summary>
        private static int s_orderID=3000;
        //property
        /// <summary>
        /// OrderID property used to store OrderID
        /// </summary>
        /// <value></value>
        public string OrderID { get; } //Read Only
        /// <summary>
        /// CustomerID property used to store CustomerID
        /// </summary>
        /// <value></value>
        public string CustomerID { get;  } // Read Only
        /// <summary>
        /// TotalPrice property used to store TotalPrice
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// DateOfOrder Property used to store DateOfOrder
        /// </summary>
        /// <value></value>
        public DateTime DateOfOrder { get; set; }
        /// <summary>
        /// OrderStatuc property used to store OrderStatus
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        //constructor
        /// <summary>
        /// OrderDetails constructor used to assign a default value to the property.
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="totalPrice"></param>
        /// <param name="dateOfOrder"></param>
        /// <param name="orderStatus"></param>
        public OrderDetails( string customerID, double totalPrice, DateTime dateOfOrder, OrderStatus orderStatus)
        {
            //auto increamentation
            s_orderID++;
            //Assigning value to property
            OrderID = "OID"+s_orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }
        /// <summary>
        /// OrderDetails constructor used to assign a default value to the property.
        /// </summary>
        /// <param name="order"></param>
        public OrderDetails( string order)
        {
            string[] value=order.Split(",");
            //Assigning value to property
            s_orderID=int.Parse(value[0].Remove(0,3));
            OrderID = value[0];
            CustomerID = value[1];
            TotalPrice = double.Parse(value[2]);
            DateOfOrder = DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            OrderStatus = Enum.Parse<OrderStatus>(value[4]);
        }    
    }
}