using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class Operations
    {
        // create a List
        //public static List<UserDetails> userList=new List<UserDetails>();
        //public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        // public static List<OrderDetails> orderList=new List<OrderDetails>();

        //customList for userDetails,MedicineDetails,OrderDetails
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicineList=new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();

        // Declare a object for userDetails to store current user Details
        static UserDetails currentUser;
        //Main Menu
        public static void MainMenu()
        {
            // show the title
            Console.WriteLine($"*********Medical Store******");
            //run until user choose exit
            bool  flag=true;
            do
            {
                // show Main Menu
            
                Console.WriteLine($"********Main Menu**********");
                Console.WriteLine($"1. User Registration\n2. User Login\n3. Exit");
                // need to ask user to Choose Option
                Console.Write($"Enter the option : ");
                bool valid=false;
                int menuOption=0;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out menuOption);
                    if(!valid)
                    {
                        Console.Write($"Invalid Format. Enter Again : ");
                    }
                }
                switch(menuOption)
                {
                    case 1:
                    {
                        //user Registration
                        Console.WriteLine($"******User Registration*******");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        //user Login
                        Console.WriteLine($"********User Login*********");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        //Exit
                        Console.WriteLine($"Exit from application");
                        flag=false;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine($"You Entered Wrong Option.");
                        break;
                    }
                }
                
            } while (flag);            
        }
        //Registration
        public static void UserRegistration()
        {
            // ask user to enter the Details
            Console.Write($"Enter the userName :");
            string userName=Console.ReadLine();
            Console.Write($"Enter Age : ");
            bool valid=false;
            int age=0;
            while (!valid)
            {
                valid=int.TryParse(Console.ReadLine(),out age);
                if(!valid)
                {
                    Console.Write($"Invalid Format. Enter Age Again : ");
                }
            }
            Console.Write($"Enter City : ");
            string city=Console.ReadLine();
            Console.Write($"Enter PhoneNumber : ");
            string PhoneNumber=Console.ReadLine();
            Console.Write($"Enter Balance (Minimum Requried rs100) : ");
            valid=false;
            double balance=0;
            while (!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out balance);
                if(!valid)
                {
                    Console.Write($"Invalid Format. Enter Again : ");
                }
                else if(valid && balance<=100)
                {
                    Console.WriteLine($"Minimum Requried rs100.Enter Balance Again : ");
                    valid=false;
                    
                }
            }
            // create a object for userDetails and added into userList
            UserDetails userDetails=new UserDetails(userName,age,city,PhoneNumber,balance);
            userList.Add(userDetails);
            // show UserID
            Console.WriteLine($"Your UserID is {userDetails.UserID}");
        }
        // Login
        public static void Login()
        {
            int flag=0;
            // Ask the user to enter userID
            Console.Write($"Enter UserName : ");
            string userName=Console.ReadLine().ToUpper();
            // validate userID
            foreach (UserDetails user in userList)
            {
                if(user.UserID.Equals(userName))
                {
                    //if valid show submenu
                    flag=1;
                    currentUser=user;
                    SubMenu();
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"Invalid UserID");
            }
        }
        // SubMenu
        public static void SubMenu()
        {
            //run until user choose exit
            bool flag=true;
            do
            {
                Console.WriteLine($"******SubMenu*******");
                Console.WriteLine($"1. Show Medicine List\n2. Purchase Medicine\n3. Modify purchase\n4. Cancel Purchase\n5. Show Purchase History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit");
                // ask the user to enter option
                Console.Write($"Enter the Option : ");
                bool valid=false;
                int subOption=0;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out subOption);
                    if(!valid)
                    {
                        Console.Write($"Invalid Format. Enter Again : ");
                    }
                }
                switch(subOption)
                {
                    case 1:
                    {
                        // Show Medicine List
                        Console.WriteLine($"Show Medicie List");
                        ShowMedicineList();
                        break;
                    }
                    case 2:
                    {
                        // Purchase Medicine
                        Console.WriteLine($"Purchase Medicine");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        // Modify Purchase
                        Console.WriteLine($"Modify Purchase");
                        ModifyPurchase();
                        break;
                    }
                    case 4:
                    {
                        // cancel Purchase
                        Console.WriteLine($"Cancel Purchase");
                        CancelPurchase();
                        break;
                    }
                    case 5:
                    {
                        // Show Purchase History
                        Console.WriteLine($"Show Purchase History");
                        ShowPurchaseHistory();
                        break;
                    }
                    case 6:
                    {
                        // Recharge Wallet
                        Console.WriteLine($"Recharge Wallet");
                        RechargeWallet();
                        break;
                    }
                    case 7:
                    {
                        // Show Wallet Balance
                        Console.WriteLine($"Show Wallet Balance");
                        ShowWalletBalance();
                        break;
                    }
                    case 8:
                    {
                        // Exit form SubMenu
                        Console.WriteLine($"Exit from SubMenu");
                        flag=false;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine($"You Entered wrong Option");
                        break;
                    }
                }
                
            } while (flag);
           
        }
        // Show Medicine List
        public static void ShowMedicineList()
        {
            //show MedicineList
            Console.WriteLine($"---------------------------------------------------------------");
            Console.WriteLine($"|{"MedicineID",-10}|{"MedicineName",-15}|{"Available Count",-15}|{"Price",-5}|{"DateOfExpiry",-12}|");
            Console.WriteLine($"---------------------------------------------------------------");
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"|{medicine.MedicineID,-10}|{medicine.MedicineName,-15}|{medicine.AvailableCount,-15}|{medicine.Price,-5}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-12}|");
                Console.WriteLine($"---------------------------------------------------------------");
            }
            
        }
        // Purchase Medicine
        public static void PurchaseMedicine()
        {
            // display medicine List
            ShowMedicineList();
            //ask user to  enter medicineId and count
            Console.Write($"Enter Medicine ID : ");
            string medicineID=Console.ReadLine().ToUpper();
            Console.Write($"Enter the Quantity : ");
            bool valid=false;
            int quantity=0;
            while (!valid)
            {
                valid=int.TryParse(Console.ReadLine(),out quantity);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
            }
            int flag=0;
            // validate MedicineID and Quantity
            foreach (MedicineDetails medicine in medicineList)
            {
                if(medicine.MedicineID.Equals(medicineID) && quantity<=medicine.AvailableCount && DateTime.Now<medicine.DateOfExpiry)
                {
                    //if valid, check available Quantity and reduce quantity from medicineDetails 
                    flag=1;
                    double amount=quantity*medicine.Price;
                    if(currentUser.WalletBalance>=quantity)
                    {
                        //if valid, create a object for orderDetails and added into orderList
                        medicine.AvailableCount-=quantity;
                        currentUser.DeductBalance(amount);
                        OrderDetails order=new OrderDetails(currentUser.UserID,medicine.MedicineID,quantity,amount,DateTime.Now,OrderStatus.Purchased);
                        orderList.Add(order);
                        // Display Medicine was Purchased Successfully.
                        Console.WriteLine($"Medicine was Purchased Successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient Balance.Recharge your Wallet then Comeback to Purchase.");
                    }
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"Medicine is Not Available");
                
            }
        }
        //Modify Purchase
        public static void ModifyPurchase()
        {
            // Show Order Details
            int flag=0;
            Console.WriteLine($"-----------------------------------------------------------");
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"MedicineID",-10}|{"Medicine Count",-14}|{"TotalPrice",-10}|{"OrderDate",-13}|{"OrderStatus",-15}|");
            Console.WriteLine($"-----------------------------------------------------------");
            foreach (OrderDetails order in orderList)
            {
                if(currentUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Purchased)
                {
                    flag=1;
                    Console.WriteLine($"|{order.OrderID,-8}|{order.UserID,-8}|{order.MedicineID,-10}|{order.MedicineCount,-14}|{order.TotalPrice,-10}|{order.OrderDate.ToString("dd/MM/yyyy"),-13}|{order.OrderStatus,-15}|");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"No Data Found.");
            }
            else
            {
                // Ask user to pick OrderID
                Console.Write($"Enter OrderID : ");
                string orderID=Console.ReadLine().ToUpper();
                // Validate OrderID
                foreach (OrderDetails order in orderList)
                {
                    if(currentUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Purchased && order.OrderID.Equals(orderID))
                    {
                        flag=2;
                        //if valid ask the user enter quantity
                        Console.Write($"Enter the Quantity :");
                        bool valid=false;
                        int quantity=0;
                        while (!valid)
                        {
                            valid=int.TryParse(Console.ReadLine(),out quantity);
                            if(!valid)
                            {
                                Console.Write($"Invalid Format Enter Again : ");
                            }
                        }
                        // change the Quantity and calculate amount and deduct or refund amount based on quantity
                        foreach (MedicineDetails medicine in medicineList)
                        {
                            if(medicine.MedicineID.Equals(order.MedicineID))
                            {
                                medicine.AvailableCount+=order.MedicineCount;
                                if(medicine.AvailableCount>=quantity)
                                {
                                    double newAmount=medicine.Price*quantity;
                                    double oldAmount=order.TotalPrice;
                                    if(oldAmount>newAmount)
                                    {
                                        currentUser.WalletRecharge(oldAmount-newAmount);
                                    }
                                    else if(newAmount>oldAmount)
                                    {
                                        currentUser.DeductBalance(newAmount-oldAmount);
                                    }
                                    // update count,totalprice in medicineDetails, OrderDetails
                                    medicine.AvailableCount+=order.MedicineCount;
                                    medicine.AvailableCount-=quantity;
                                    order.TotalPrice=newAmount;
                                    order.MedicineCount=quantity;
                                    // Show Modify Successfully
                                    Console.WriteLine($"Medicine Modify Successfully.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Required Quantity Not available.");
                                    
                                }
                                
                            }
                            
                        }
                        break;
                        
                    }
                }
                if(flag==1)
                {
                    Console.WriteLine($"Invalid OrderId.");
                    
                }
            }
        }
        //Cancel Purchase
        public static void CancelPurchase()
        {
            // Show Order Details
            int flag=0;
            Console.WriteLine($"------------------------------------------------------------");
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"MedicineID",-10}|{"Medicine Count",-14}|{"TotalPrice",-10}|{"OrderDate",-13}|{"OrderStatus",-15}|");
            Console.WriteLine($"-----------------------------------------------------------");
            foreach (OrderDetails order in orderList)
            {
                if(currentUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Purchased)
                {
                    flag=1;
                    Console.WriteLine($"|{order.OrderID,-8}|{order.UserID,-8}|{order.MedicineID,-10}|{order.MedicineCount,-14}|{order.TotalPrice,-10}|{order.OrderDate.ToString("dd/MM/yyyy"),-13}|{order.OrderStatus,-15}|");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"No Data Found.");
            }
            else
            {
                // Ask user to pick OrderID
                Console.Write($"Enter OrderID : ");
                string orderID=Console.ReadLine().ToUpper();
                //  validate OrderID
                foreach (OrderDetails order in orderList)
                {
                    if(currentUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Purchased && order.OrderID.Equals(orderID))
                    {
                        flag=2;
                        // if valid,return the quantity to medicineDetails and refund the amount to user
                        foreach (MedicineDetails medicine in medicineList)
                        {
                            if(medicine.MedicineID.Equals(order.MedicineID))
                            {
                                medicine.AvailableCount+=order.MedicineCount;
                                order.OrderStatus=OrderStatus.Cancelled;
                                currentUser.WalletRecharge(order.TotalPrice);
                                Console.WriteLine($"OrderID {order.OrderID} was cancelled  Successfully");
                            }
                        }
                    }
                }
                if(flag==1)
                {
                    Console.WriteLine($"Invalid OrderID");
                }
            }
        }
        //Show Purchase History
        public static void  ShowPurchaseHistory()
        {
            // show OrderDetails
            int flag=0;
            Console.WriteLine($"--------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"MedicineID",-10}|{"Medicine Count",-14}|{"TotalPrice",-10}|{"OrderDate",-13}|{"OrderStatus",-15}|");
            Console.WriteLine($"--------------------------------------------------------------------------------------");
            foreach (OrderDetails order in orderList)
            {
                if(currentUser.UserID.Equals(order.UserID))
                {
                    flag=1;
                    Console.WriteLine($"|{order.OrderID,-8}|{order.UserID,-8}|{order.MedicineID,-10}|{order.MedicineCount,-14}|{order.TotalPrice,-10}|{order.OrderDate.ToString("dd/MM/yyyy"),-13}|{order.OrderStatus,-15}|");
                    Console.WriteLine($"--------------------------------------------------------------------------------------");
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"No Data Found.");
            } 
        }
        //Recharge Wallet
        public static void RechargeWallet()
        {
            // Ask the user to enter Amount
            Console.Write($"Enter the Amount to Recharge : ");
            double amount=0;
            bool valid=false;
            while (!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out amount);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");                   
                }
            }
            currentUser.WalletRecharge(amount);
        }
        //Show Wallet Balance
        public static void ShowWalletBalance()
        {
            // Show the WalletBalance.
            Console.WriteLine($"Wallet Balance : {currentUser.WalletBalance}");
            
        }
        //Add Default Value
        public static void AddDefaultValue()
        {
            //Create a object for Userdetails
            UserDetails userDetails=new UserDetails("Ravi",33,"Theni","9877774440",400);
            UserDetails userDetails1=new UserDetails("Baskaran",33,"Chennai","8847775740",500);
            // Adding userDetails intp userList
            userList.AddRange(new CustomList<UserDetails>{userDetails,userDetails1});
            // create a object ofr Medicine Details
            MedicineDetails medicineDetails=new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
            MedicineDetails medicineDetails1=new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
            MedicineDetails medicineDetails2=new MedicineDetails("Gelucil",3,40,new DateTime(2024,04,30));
            MedicineDetails medicineDetails3=new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30));
            MedicineDetails medicineDetails4=new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));
            // Adding  medicine details into medicineList
            medicineList.AddRange(new CustomList<MedicineDetails>{medicineDetails,medicineDetails1,medicineDetails2,medicineDetails3,medicineDetails4});
            // Create a object for OrderDetails
            OrderDetails orderDetails=new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails orderDetails1=new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,11,13),OrderStatus.Cancelled);
            OrderDetails orderDetails2=new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails orderDetails3=new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,11,15),OrderStatus.Cancelled);
            OrderDetails orderDetails4=new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,11,15),OrderStatus.Purchased);
            OrderDetails orderDetails5=new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,11,15),OrderStatus.Purchased);
            //Adding orderDetails into orderList
            orderList.AddRange(new CustomList<OrderDetails>{orderDetails,orderDetails1,orderDetails2,orderDetails3,orderDetails4,orderDetails5});
        }
    }
}