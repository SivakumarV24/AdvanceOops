using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class Filehandling
    {
        /// <summary>
        /// File Handling class used to create,Write and Read from the file
        /// </summary>
        // Create Method
        /// <summary>
        /// Create method used to create a folder and files 
        /// </summary>
        public static void Create()
        {
            // create a folder
            if(!Directory.Exists("QwickFoodz"))
            {
                Directory.CreateDirectory("QwickFoodz");
            }
            // create a CustomerDetails.csv
            if(!File.Exists("QwickFoodz/customerDetails.csv"))
            {
                File.Create("QwickFoodz/customerDetails.csv");
            }
             // create a FoodDetails.csv
            if(!File.Exists("QwickFoodz/foodDetails.csv"))
            {
                File.Create("QwickFoodz/foodDetails.csv");
            }
             // create a itemDetails.csv
            if(!File.Exists("QwickFoodz/itemDetails.csv"))
            {
                File.Create("QwickFoodz/itemDetails.csv");
            }
             // create a orderDetails.csv
            if(!File.Exists("QwickFoodz/orderDetails.csv"))
            {
                File.Create("QwickFoodz/orderDetails.csv");
            }
        }
        //WriteToCsv
        /// <summary>
        /// Writetocsv method used to write a date from list to csv file
        /// </summary>
        public static void WriteToCsv()
        {
            //Write to Customerdetails
            string[] customerDetails=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i]=Operations.customerList[i].CustomerID+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.customerList[i].MailID+","+Operations.customerList[i].Location+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("QwickFoodz/customerDetails.csv",customerDetails);

            //Write to FoodDetails
            string[] foodDetails=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foodDetails[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity+","+Operations.foodList[i].QuantityAvailable;
            }
            File.WriteAllLines("QwickFoodz/foodDetails.csv",foodDetails);

            //Write to ItemDetails
            string[] itemDetails=new string[Operations.itemList.Count];
            for(int i=0;i<Operations.itemList.Count;i++)
            {
                itemDetails[i]=Operations.itemList[i].ItemID+","+Operations.itemList[i].OrderID+","+Operations.itemList[i].FoodID+","+Operations.itemList[i].PurchaseCount+","+Operations.itemList[i].PriceOfOrder;
            }
            File.WriteAllLines("QwickFoodz/itemDetails.csv",itemDetails);

            //Write to OrderDetails
            string[] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].CustomerID+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].DateOfOrder.ToString("dd/MM/yyyy")+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("QwickFoodz/orderDetails.csv",orderDetails);

        }
        //ReadFromCsv
        /// <summary>
        /// ReadFromscv method used to Read data from csv file
        /// </summary>
        public static void ReadFromCsv()
        {
            // readFrom Customerdetails.CSV
            string[] customerRead=File.ReadAllLines("QwickFoodz/customerDetails.csv");
            foreach (string customer in customerRead)
            {
                CustomerDetails customerDetails=new CustomerDetails(customer);
                Operations.customerList.Add(customerDetails);
            }
            // readFrom Fooddetails.CSV
            string[] foodRead=File.ReadAllLines("QwickFoodz/foodDetails.csv");
            foreach (string food in foodRead)
            {
               FoodDetails foodDetails=new FoodDetails(food);
                Operations.foodList.Add(foodDetails);
            }
            // readFrom itemDetails.CSV
            string[] itemRead=File.ReadAllLines("QwickFoodz/itemDetails.csv");
            foreach (string item in itemRead)
            {
                ItemDetails itemDetails=new ItemDetails(item);
                Operations.itemList.Add(itemDetails);
            }
            // readFrom orderDetails.CSV
            string[] orderRead=File.ReadAllLines("QwickFoodz/orderDetails.csv");
            foreach (string order in orderRead)
            {
                OrderDetails orderDetails=new OrderDetails(order);
                Operations.orderList.Add(orderDetails);
            }
        }
    }
}