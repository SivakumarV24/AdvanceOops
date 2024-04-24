using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    // Static class
    /// <summary>
    /// Static class to used to create a funtionality of Application. <see cref="Operations"/>
    /// </summary>
    public static class Operations
    {
        // Create a list to store values
        // CustomList
        /// <summary>
        /// UserList is used to store the userDetails
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        /// <summary>
        /// travelList is used to store the TravelDetails
        /// </summary>
        /// <typeparam name="TravelDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<TravelDetails> travelList=new CustomList<TravelDetails>();
        /// <summary>
        /// ticketFairList is used to stire the TicketFairDetials.
        /// </summary>
        /// <typeparam name="TicketFairDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<TicketFairDetails> ticketFairList=new CustomList<TicketFairDetails>();
        //Current User Details
        /// <summary>
        /// current user store the details of currentUser.
        /// </summary>
        static UserDetails currentUser;
        // Main Menu
        /// <summary>
        /// Main Menu method show the mainMenu
        /// </summary>
        public static void MainMenu()
        {
            // Show Title
            Console.WriteLine($"********Metro Card Management******");
            // Run until user choose exit
            bool flag=true;
            do
            {
                // show main menu
                Console.WriteLine($"******Menu Menu*********");
                Console.WriteLine($"1. New User Registration\n2. userLogin\n3. Exit");
                // Ask the user to choose option
                Console.Write($"Enter the Option given Above : ");
                int mainOption=0;
                bool valid=false;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out mainOption);
                    if(!valid)
                    {
                        Console.Write($"Invalid Format Enter Again : ");
                    }
                }
                switch(mainOption)
                {
                    case 1:
                    {
                        // New User Registration
                        Console.WriteLine($"*******Registration*********");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        //User Login
                        Console.WriteLine($"***********Login************");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        // Exit from Application
                        flag=false;
                        Console.WriteLine($"Exit From Application");
                        break;
                    }
                    default:
                    {
                        //Wrong Option
                        Console.Write($"You Enter Wrong Option ");
                        break;
                    }
                }
                
            } while (flag);
        }
        // User Registration
        /// <summary>
        /// Registration method is used to register the new user.
        /// </summary>
        public static void Registration()
        {
            //Ask the user to enter the Details
            Console.Write($"Enter User Name : ");
            string userName=Console.ReadLine();
            Console.Write($"Enter Phone Number : ");
            long phoneNumber=0;
            bool valid=false;
            while (!valid)
            {
                valid=long.TryParse(Console.ReadLine(),out phoneNumber);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
            }
            Console.Write($"Enter Balance (Minimum Balance 100 rs) : ");
            double balance=0;
            valid=false;
            while (!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out balance);
                if(valid && balance<100)
                {
                    Console.Write($"Minimum Balance Required 100rs Enter Amount greater than or Equal to 100rs : ");
                    valid=false;
                }
                else if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
            }
            // create a object for userDetails 
            UserDetails user=new UserDetails(balance,userName,phoneNumber);
            // Added into userList
            userList.Add(user);
            // Show CardNumber
            Console.WriteLine($"Your Card Number is {user.CardNumber}");
        }
        // Login
        /// <summary>
        /// Login method used to validate the cardnumber.
        /// </summary>
        public static void Login()
        {
            int flag=0;
            // Ask the user to enter card Number
            Console.Write($"Enter Card Number : ");
            string cardNumber=Console.ReadLine().ToUpper();
            // validate the CardNumber
            for(int i=0;i<userList.Count;i++)
            {
                if(userList[i].CardNumber.Equals(cardNumber))
                {
                    //If valid store the userDetails into currentuser object and Diplay "Welcome {userName}"
                    flag=1;
                    currentUser=userList[i];
                    Console.WriteLine($"****Welcome {currentUser.UserName}.****");
                    // call SubMenu method.
                    SubMenu();
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"Invalid Card Number");
            }
        }
        //SubMenu
        /// <summary>
        /// SubMenu is used to display the subMenu
        /// </summary>
        public static void SubMenu()
        {
            // run until user choose exit
            bool flag=true;
            do
            {
                // show MainMenu
                Console.WriteLine($"*****SubMenu******");
                Console.WriteLine($"1. Balance Check\n2. Recharge\n3. View Travel Histroy\n4. Travel\n5. Exit");
                //Ask the user to choose option
                Console.Write($"Enter the Option Given Above : ");
                int subOption=0;
                bool valid=false;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out subOption);
                    if(!valid)
                    {
                        Console.Write($"Invalid Format Enter Again : ");
                    }
                }
                switch(subOption)
                {
                    case 1:
                    {
                        // Balance
                        Console.WriteLine($"********Balance*********");
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        // Recharge
                        Console.WriteLine($"********Recharge*********");
                        WalletRecharge();
                        break;
                    }
                    case 3:
                    {
                        // View Travel Details
                        Console.WriteLine($"********View Travel Details*********");
                        ViewTravelDetails();
                        break;
                    }
                    case 4:
                    {
                        // Travel
                        Console.WriteLine($"********Travel*********");
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        // Exit form submenu
                        Console.WriteLine($"********Exit from Submenu*********");
                        flag=false;
                        break;
                    }
                    default:
                    {
                        Console.Write($"You Enter Wrong Option.");
                        break;
                    }
                }
            } while (flag);  
        }
        // Balance Check
        /// <summary>
        /// BalanceCheck method is used to check the current user Balance
        /// </summary>
        public static void BalanceCheck()
        {
            // Show Balance
            Console.WriteLine();
            Console.WriteLine($"Wallet Balance : {currentUser.Balance}");
        }
        //Recharge
        /// <summary>
        /// WalletRecharge Method used to recharge wallet of current user
        /// </summary>
        public static void WalletRecharge()
        {
            // Ask the user to enter amount and check amount>=50.
            Console.Write($"Enter the Amount to Recharge (Minimum 50rs Requird ): ");
            double amount=0;
            bool valid=false;
            while (!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out amount);
                if(valid && amount<=50)
                {
                    Console.Write($"Minimum Recharge Required 50rs Enter Amount greater than or Equal to 50rs : ");
                    valid=false;
                }
                else if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
            }
            // Call the WalletRecharge method from userrDetails
            if(currentUser.WalletRecharge(amount))
            {
                Console.WriteLine($"Rechagre Successfully.");
                
            }
        }
        //View Travel Details
        /// <summary>
        /// TravelHistoryDetails method used to store the userTravelDetails
        /// </summary>
        public static void ViewTravelDetails()
        {
            // Show Current user Travel History
            int flag=0;
            Console.WriteLine($"|{"TravelID",-8}|{"From Location",-15}|{"To Location",-15}|{"Date",-12}|{"TravelCost",-10}|");
            Console.WriteLine($"------------------------------------------------------------------");
            for(int i=0;i<travelList.Count;i++)
            {
                if(currentUser.CardNumber.Equals(travelList[i].CardNumber))
                {
                    flag=1;
                    Console.WriteLine($"|{travelList[i].TravelID,-8}|{travelList[i].FromLocation,-15}|{travelList[i].ToLocation,-15}|{travelList[i].Date.ToString("dd/MM/yyyy"),-12}|{travelList[i].TravelCost,-10}|");
                    Console.WriteLine($"------------------------------------------------------------------");
                     
                }
            }
            if(flag==0)
            {
                // No date Found
                Console.WriteLine($"No Data Found");
            }
        }
        // Travel
        /// <summary>
        /// Travel method is used to Book the ticket.
        /// </summary> 
        public static void Travel()
        {
            // Show the Ticket Fair
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"|{"TicketID",-8}|{"From Location",-15}|{"To Location ",-15}|{"Fair",-4}|");
             Console.WriteLine($"-----------------------------------------------");
            for(int i=0;i<ticketFairList.Count;i++)
            {
                Console.WriteLine($"|{ticketFairList[i].TicketID,-8}|{ticketFairList[i].FromLocation,-15}|{ticketFairList[i].ToLocation,-15}|{ticketFairList[i].TicketPrice,-4}|");
                Console.WriteLine($"-----------------------------------------------");
            }
            // Ask the user to Pick TicketID
            Console.Write($"Enter the TicketID : ");
            string ticketID=Console.ReadLine().ToUpper();
            int flag=0;
            // Validate TicketID
            for(int i=0;i<ticketFairList.Count;i++)
            {
               if(ticketID.Equals(ticketFairList[i].TicketID))
               {
                    flag=1;
                    //If valid ->check Walletbalance to sufficient balance to travel
                    if(ticketFairList[i].TicketPrice<=currentUser.Balance)
                    {
                        // if yes deduce amount from walletbalance create a object
                        if(currentUser.DeductBalance(ticketFairList[i].TicketPrice))
                        {
                            TravelDetails travelDetails=new TravelDetails(currentUser.CardNumber,ticketFairList[i].FromLocation,ticketFairList[i].ToLocation,DateTime.Now,ticketFairList[i].TicketPrice);
                            travelList.Add(travelDetails);
                            Console.WriteLine($"Ticket Booking Successfully. Amount deduct from Your Wallet.Your Travel Id is {travelDetails.TravelID}");
                            Console.WriteLine($"Your Available Balance : {currentUser.Balance}");
                        }
                    }
                    else
                    {
                        //if no ask him to recharge and go ot existing user service menu
                        Console.WriteLine($"Insufficient Balance. Recharge You Wallet Then book Ticket.");
                    }
               }
            }
            if(flag==0)
            {
                Console.WriteLine($"Invalid TicketID");
            }   
        }
        // Add Default Values
        /// <summary>
        /// AddDefaultValues Method used to store the default value to customList
        /// </summary>
        public static void AddDefaultValue()
        {
            //create a object for userDetails 
            UserDetails user1=new UserDetails(1000,"Ravi",9848812345);
            UserDetails user2=new UserDetails(1000,"Baskaran",9948854321);
            //Add UserDetails into userList
            List<UserDetails> list1=new List<UserDetails>{user1,user2};
            userList.AddRange(list1);
            // create a object for TravelDetails
            TravelDetails travel1=new  TravelDetails(user1.CardNumber,"Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2=new  TravelDetails(user1.CardNumber,"Egmore","Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3=new  TravelDetails(user2.CardNumber,"Alandur","Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4=new  TravelDetails(user2.CardNumber,"Egmore","Thirumangalam",new DateTime(2023,11,10),25);
            // Add Travel Details into travelList
            travelList.AddRange(new List<TravelDetails>{travel1,travel2,travel3,travel4});
            // create a object for Ticket Fair Details
            TicketFairDetails ticketFair1=new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticketFair2=new TicketFairDetails("Airport","Koyembedu",25);
            TicketFairDetails ticketFair3=new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticketFair4=new TicketFairDetails("Koyembedu","Egmore",32);
            TicketFairDetails ticketFair5=new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticketFair6=new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticketFair7=new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticketFair8=new TicketFairDetails("Arumbakkam","Koyambedu",16);
            // Add Ticket Fair into ticketFair
            ticketFairList.AddRange(new List<TicketFairDetails>{ticketFair1,ticketFair2,ticketFair3,ticketFair4,ticketFair5,ticketFair6,ticketFair7,ticketFair8});
        }
    }
}