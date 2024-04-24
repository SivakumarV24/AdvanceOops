using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// File Handling class used to create,write,Read from a file <see cref="Filehandling"/>
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Create method used to create a folder and files
        /// </summary>
        public static void Create()
        {
            // create a folder
            if(!Directory.Exists("MedicineStore"))
            {
                Directory.CreateDirectory("MedicineStore");
            }
            // Create a File
            // Create a file for  store userDetails
            if(!File.Exists("MedicineStore/UserDetails"))
            {
                File.Create("MedicineStore/UserDetails").Close();
            }
            // Create a file for store MedicineDetails
            if(!File.Exists("MedicineStore/MedicineDetails"))
            {
                File.Create("MedicineStore/MedicineDetails").Close();
            }
            // Create a file for store OrderDetails
            if(!File.Exists("MedicineStore/OrderDetails"))
            {
                File.Create("MedicineStore/OrderDetails").Close();
            }
        }
        // WriteToCsv
        /// <summary>
        /// Write Method used to write Details to the File.
        /// </summary>
        public static void WriteToCsv()
        {
            // Write to userDetails.csv
            string[] user=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                user[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("MedicineStore/UserDetails",user);
            //Write to MedicineDetails.csv
            string[] medicine=new string[Operations.medicineList.Count];
            for(int i=0;i<Operations.medicineList.Count;i++)
            {
                medicine[i]=Operations.medicineList[i].MedicineID+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvailableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("MedicineStore/MedicineDetails",medicine);
            //Medical store.
            string[] order=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                order[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].MedicineID+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicineStore/OrderDetails",order);
        }
        // ReadFromCsv
        /// <summary>
        /// ReadfromCsv method used to Read Data from the file.
        /// </summary>
        public static void ReadFromCsv()
        {
            // get UserDetails from userDetails.csv
            string[] userDetails=File.ReadAllLines("MedicineStore/UserDetails");
            foreach (string user in userDetails)
            {
                UserDetails userDetail=new UserDetails(user);
                Operations.userList.Add(userDetail);
            }
            // get MedicineDetails from MedicineDetails.csv
            string[] medicineDetails=File.ReadAllLines("MedicineStore/MedicineDetails");
            foreach (string medicine in medicineDetails)
            {
                MedicineDetails medicine1=new MedicineDetails(medicine);
                Operations.medicineList.Add(medicine1);
            }
            //get OrderDetails from OrderDetails.csv
            string[] orderDetail=File.ReadAllLines("MedicineStore/OrderDetails");
            foreach (string order in orderDetail)
            {
                OrderDetails orderDetails=new OrderDetails(order);
                Operations.orderList.Add(orderDetails);
            }
        }
    }
}