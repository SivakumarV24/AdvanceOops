using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace GroceryStoreApplication
{
    public class FileHandling
    {
        //Create Folder and File
        public static void Create()
        {
            //Creating Folder
            if (!Directory.Exists("GroceryStoreApplication"))
            {
                Directory.CreateDirectory("GroceryStoreApplication");
            }
            //Creating customerDetails File
            if (!File.Exists("GroceryStoreApplication/customerDetails.csv"))
            {
                File.Create("GroceryStoreApplication/customerDetails.csv").Close();
            }
            //Creating productDetails File
            if (!File.Exists("GroceryStoreApplication/productDetails.csv"))
            {
                File.Create("GroceryStoreApplication/productDetails.csv").Close();
            }
            //Creating bookingDetails File
            if (!File.Exists("GroceryStoreApplication/bookingDetails.csv"))
            {
                File.Create("GroceryStoreApplication/bookingDetails.csv").Close();
            }
            //Creating orderDetails File
            if (!File.Exists("GroceryStoreApplication/orderDetails.csv"))
            {
                File.Create("GroceryStoreApplication/orderDetails.csv").Close();
            }
        }
        // WriteToCsv Method
        public static void WriteToCsv()
        {
            //Write to customerDetails
            string[] customerDetails = new string[Operations.customerList.Count];
            for (int i = 0; i < Operations.customerList.Count; i++)
            {
                customerDetails[i] = Operations.customerList[i].CustomerID+ "," + Operations.customerList[i].Name + "," + Operations.customerList[i].FatherName + "," + Operations.customerList[i].Gender+","+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.customerList[i].MailID+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryStoreApplication/customerDetails.csv", customerDetails);

            // Write to productDetails
            string[] productDetails = new string[Operations.productList.Count];
            for (int i = 0; i < Operations.productList.Count; i++)
            {
                productDetails[i] = Operations.productList[i].ProductID+","+Operations.productList[i].ProductName+","+Operations.productList[i].QuantityAvailable+","+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryStoreApplication/productDetails.csv", productDetails);

            //Write to bookingDetails
            string[] bookingList = new string[Operations.bookingList.Count];
            for (int i = 0; i < Operations.bookingList.Count; i++)
            {
                bookingList[i] = Operations.bookingList[i].BookingID+","+Operations.bookingList[i].CustomerID+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("GroceryStoreApplication/bookingDetails.csv", bookingList);
            //Write to orderDetails
            string[] orderDetails = new string[Operations.orderList.Count];
            for (int i = 0; i <Operations.orderList.Count; i++)
            {
                orderDetails[i] = Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingID+","+Operations.orderList[i].ProductID+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            File.WriteAllLines("GroceryStoreApplication/orderDetails.csv", orderDetails);
            }
        }
        //ReadFromCsv
        public static void ReadFromCsv()
        {
            string[] customerDetails = File.ReadAllLines("GroceryStoreApplication/customerDetails.csv");
            for (int i = 0; i < customerDetails.Length; i++)
            {
                CustomerRegistration customer=new CustomerRegistration(customerDetails[i]);
                Operations.customerList.Add(customer);
            }

            //productDetails
            string[] productDetails = File.ReadAllLines("GroceryStoreApplication/productDetails.csv");
            for (int i = 0; i < productDetails.Length; i++)
            {
                ProductDetails product=new ProductDetails(productDetails[i]);
               Operations.productList.Add(product);
            }

            //bookingDetails
            string[] bookingDetails = File.ReadAllLines("GroceryStoreApplication/bookingDetails.csv");
            for (int i = 0; i < bookingDetails.Length; i++)
            {
                BookingDetails booking=new BookingDetails(bookingDetails[i]);
                Operations.bookingList.Add(booking);
            }

            //orderDetails
            string[] orderDetails = File.ReadAllLines("GroceryStoreApplication/orderDetails.csv");
            for (int i = 0; i < orderDetails.Length; i++)
            {
                OrderDetails order=new OrderDetails(orderDetails[i]);
                Operations.orderList.Add(order);
            }
        }
    }
}