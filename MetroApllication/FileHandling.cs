using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// File Handling class used to create a folder,files, Read and Write files <see cref="FileHandling"/>
    /// </summary>
    public class FileHandling
    {
        // create Folder and Files
        /// <summary>
        /// Create method used to create a folder and Required Files <see cref="FileHandling"/>
        /// </summary>
        public static void Create()
        {
            // Create Folder
            if(!Directory.Exists("MetroCardApplication"))
            {
                Directory.CreateDirectory("MetroCardApplication");
                Console.WriteLine($"Folder Created");
            }
            else
            {
                Console.WriteLine($"Folder already Exists");
            }
            // Create file for Each class
            // UserDetailsFile
            if(!File.Exists("MetroCardApplication/UserDetails.csv"))
            {
                File.Create("MetroCardApplication/UserDetails.csv").Close();
            }
            else
            {
                Console.WriteLine($"File Already Created");
                
            }
            // Travel Details
            if(!File.Exists("MetroCardApplication/TravelDetails.csv"))
            {
                File.Create("MetroCardApplication/TravelDetails.csv").Close();
            }
            else
            {
                Console.WriteLine($"File Already Created");
                
            }
            // TicketFairDetailsFile
            if(!File.Exists("MetroCardApplication/TicketFairDetails.csv"))
            {
                File.Create("MetroCardApplication/TicketFairDetails.csv").Close();
            }
            else
            {
                Console.WriteLine($"File Already Created");
            }
        }
        /// <summary>
        /// WriteTocsv method used to write a data from list to csv file. <see cref="FileHandling"/>
        /// </summary>
        public static void WriteToCsv()
        {
            // userDetails.csv
            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].CardNumber+","+Operations.userList[i].UserName+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;
            }
            File.WriteAllLines("MetroCardApplication/UserDetails.csv",userDetails);

            // travelDetails.csv
            string[] travelDetails=new string[Operations.travelList.Count];
            for(int i=0;i<Operations.travelList.Count;i++)
            {
                travelDetails[i]=Operations.travelList[i].TravelID+","+Operations.travelList[i].CardNumber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date.ToString("dd/MM/yyyy")+","+Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardApplication/TravelDetails.csv",travelDetails);

            //TicketDetails
            string[] ticketDetails=new string[Operations.ticketFairList.Count];
            for(int i=0;i<Operations.ticketFairList.Count;i++)
            {
                ticketDetails[i]=Operations.ticketFairList[i].TicketID+","+Operations.ticketFairList[i].FromLocation+","+Operations.ticketFairList[i].ToLocation+","+Operations.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardApplication/TicketFairDetails.csv",ticketDetails);
        }
        /// <summary>
        /// ReadFromCsv method used to read Data from the files to respective List <see cref="FileHandling"/>
         /// </summary>
        public static void ReadFromCsv()
        {
            // userDetails.csv
            string[] fileData=File.ReadAllLines("MetroCardApplication/UserDetails.csv");
            foreach (string data in fileData)
            {
                UserDetails userDetails=new UserDetails(data);
                Operations.userList.Add(userDetails);
            }
            // TravelDetails.csv
            string[] travelData=File.ReadAllLines("MetroCardApplication/TravelDetails.csv");
            foreach (string data in travelData)
            {
               TravelDetails travelDetails=new TravelDetails(data);
               Operations.travelList.Add(travelDetails);
            }
            // TicketFairDetails.csv
            string[] ticketFair=File.ReadAllLines("MetroCardApplication/TicketFairDetails.csv");
            foreach (string data in ticketFair)
            {
               TicketFairDetails ticketFairDetails=new TicketFairDetails(data);
               Operations.ticketFairList.Add(ticketFairDetails);
            }
        }
    }
}