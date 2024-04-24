using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    // Enum
    /// <summary>
    /// enum OrderStatus DataType used to store the OrderStatus
    /// </summary>
    public enum OrderStatus{
        Purchased,Cancelled
    }
    /// <summary>
    /// Orderdetails class used to create a instance for order <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        // Field
        /// <summary>
        /// static field s_orderID used to autoincrementation of the orderId
        /// </summary>
        private static int s_orderID=2000;
        // Property
        /// <summary>
        /// OrderID property used to store OrderID
        /// </summary>
        /// <value></value>
        public string OrderID { get; } // ReadOnly
        /// <summary>
        /// UserID Property used to UserID
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// MedicineId property used to store MedicineID
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// MedicineCount property used to store MedicineCount
        /// </summary>
        /// <value></value>
        public int MedicineCount { get; set; }
        /// <summary>
        /// TotalPrice property used to store TotalPrice
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// OrderDate property used to store OrderDate
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// OrderStatus property used to store OrderStatus
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        // Constructor
        /// <summary>
        /// OrderDetails construtor used to assign default value to the Property
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="medicineID"></param>
        /// <param name="medicineCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="orderDate"></param>
        /// <param name="orderStatus"></param>
        public OrderDetails(string userID, string medicineID, int medicineCount, double totalPrice, DateTime orderDate, OrderStatus orderStatus)
        {
            // Auto Increamentation
            s_orderID++;
            // Assigning value to property
            OrderID="OID"+s_orderID;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        /// <summary>
        /// OrderDetails construtor used to assign default value to the Property
        /// </summary>
        /// <param name="order"></param>
        public OrderDetails(string order)
        {
            string[] value=order.Split(",");
            // Assigning value to property
            s_orderID=int.Parse(value[0].Remove(0,3));
            OrderID=value[0];
            UserID = value[1];
            MedicineID = value[2];;
            MedicineCount = int.Parse(value[3]);
            TotalPrice = double.Parse(value[4]);
            OrderDate = DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            OrderStatus =Enum.Parse<OrderStatus>(value[6],true);
        }
    }
}