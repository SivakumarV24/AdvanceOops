using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    // static class
    public static class Operations
    {
        // Create a static customList
        public static CustomList<CustomerDetails> customerList=new CustomList<CustomerDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        public static  CustomList<ItemDetails> itemList=new CustomList<ItemDetails>();
        public static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();
       
        //public static List<CustomerDetails> customerList = new List<CustomerDetails>();
        //public static List<OrderDetails> orderList = new List<OrderDetails>();
        //public static List<ItemDetails> itemList = new List<ItemDetails>();
        //public static List<FoodDetails> foodList = new List<FoodDetails>();
        //CurrentUser
        static CustomerDetails currentUser;
        //Main Menu
        public static void MainMenu()
        {
            //Display Application name
            Console.WriteLine($"******Qwick Foodz******");
            // Run until user Choose to Exit
            bool flag = true;
            do
            {
                //show MainMenu
                Console.WriteLine($"******Main Menu********");
                Console.WriteLine($"1. CustomerRegistration\n2. Customer Login\n3. Exit");
                // Ask the user to enter the option
                Console.WriteLine($"Enter the Option Given Above");
                int mainOption = 0;
                bool valid=false;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out mainOption);
                    if(!valid)
                    {
                        Console.WriteLine($"Invalid Format.Enter Again : ");
                        
                    }
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine($"******Customer Registration*****");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"*********Customer Login***********");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exit form application");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid Format.Enter Again : ");
                            break;
                        }
                }
            } while (flag);
        }
        // Customer Registration
        public static void CustomerRegistration()
        {
            //Ask the user to Enter the Details
            Console.Write($"Enter Your Name  :");
            string name = Console.ReadLine();
            Console.Write($"Enter Your FatherName : ");
            string fatherName = Console.ReadLine();
            Console.Write($"Enter Gender (Male,Female,Transgender) : ");
            bool valid=false;
            Gender gender =Gender.Select;
            while(!valid)
            {
                valid=Enum.TryParse<Gender>(Console.ReadLine(),true, out gender);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again (Male,Female,Transgender) : ");
                }
            }             
            Console.Write($"Enter Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            Console.Write($"Enter Date Of Birth (dd/MM/yyyy) : ");
            DateTime dOB =new DateTime();
            valid=false;
            while(!valid)
            {
                valid=DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dOB);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again (dd/MM/yyyy) : ");
                }
            } 
            Console.Write($"Enter Your MaiID : ");
            string mailID = Console.ReadLine();
            Console.Write($"Enter Your Location : ");
            string location = Console.ReadLine();
            Console.Write($"Enter Balance (Minimum Required rs100): ");
            double balance = 0;
            valid=false;
            while(!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out balance);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
                else if(valid && balance<=100)
                {
                    valid=false;
                    Console.WriteLine($"Minimum Required rs100. Enter Balance Again : ");    
                }
            } 
            //Create a objct for customerRegistration
            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobileNumber, dOB, mailID, location, balance);
            // Added into customerList
            customerList.Add(customer);
            //Show CustomerID
            Console.WriteLine($"Registration Successfully. Your CustomerID : {customer.CustomerID}");

        }
        //CustomerLogin
        public static void Login()
        {
            int flag = 0;
            //Ask the user to enter the customerID
            Console.Write($"Enter the CustomerID : ");
            string customerID = Console.ReadLine().ToUpper();
            foreach (CustomerDetails list in customerList)
            {
                if (customerID.Equals(list.CustomerID))
                {
                    flag = 1;
                    currentUser = list;
                    SubMenu();
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"Invalid CustomerID.");
            }
        }
        //SubMenu
        public static void SubMenu()
        {
            //Run until user enter exit
            bool flag = true;
            do
            {
                Console.WriteLine($"*******SubMenu********");
                Console.WriteLine($"1. Show Profile\n2. Order Food\n3. Cancel Order\n4. Modify Order\n5. Order History\n6. Recharger Wallet\n7. Show Wallet Balance\n8. Exit");
                // Ask the user to enter option
                Console.WriteLine($"Enter the Option : ");
                int subOption = 0;
                bool valid=false;
                while (!valid)
                {
                    valid=int.TryParse(Console.ReadLine(),out subOption);
                    if(!valid)
                    {
                        Console.WriteLine($"Invalid Format.Enter Again : ");
                        
                    }
                }
                switch (subOption)
                {
                    case 1:
                        {
                            //Show Profile
                            Console.WriteLine($"****Show Profile*****");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            //OrderFood
                            Console.WriteLine($"*******OrderFood*******");
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            //CancelOrder
                            Console.WriteLine($"******Cancel Order******");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            //Modify Order
                            Console.WriteLine($"*********Modify Order********");
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            // Order History
                            Console.WriteLine($"***********Order History********");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            // Recharge Wallet
                            Console.WriteLine($"*********Recharge Wallet*********");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            //Show Wallet Balance
                            Console.WriteLine($"******Show Wallet Balance*********");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            // Exit from SubMenu
                            flag = false;
                            Console.WriteLine($"***Exit from SubMenu****");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid Option.");
                            break;
                        }
                }
            } while (flag);
        }
        //Show Profile
        public static void ShowProfile()
        {
            //  Display profile
            Console.WriteLine($"*****Profile*********");
            Console.WriteLine($"CustomerID : {currentUser.CustomerID}");
            Console.WriteLine($"Name : {currentUser.Name}");
            Console.WriteLine($"Father Name : {currentUser.FatherName}");
            Console.WriteLine($"Gender : {currentUser.Gender}");
            Console.WriteLine($"DOB : {currentUser.DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile Number : {currentUser.Mobile}");
            Console.WriteLine($"Mail ID : {currentUser.MailID}");
            Console.WriteLine($"Balance :  {currentUser.WalletBalance}");
        }
        // Order Food
        public static void OrderFood()
        {
            //Create a object for order details. and create a temporary list for ItemDetails
            OrderDetails order = new OrderDetails(currentUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();
            bool flag = true;
            // run until user choose to NO.
            do
            {
                // Show Food Details
                int value = 0;
                Console.WriteLine($"|{"FoodID",-8}|{"FoodName",-24}|{"PricePerQuantity",-16}|{"QuantityAvailable",-18}|");
                Console.WriteLine($"------------------------------------------------------------------------------------");
                foreach (FoodDetails food in foodList)
                {
                    
                    value = 1;
                    Console.WriteLine($"|{food.FoodID,-8}|{food.FoodName,-24}|{food.PricePerQuantity,-16}|{food.QuantityAvailable,-18}|");
                    Console.WriteLine($"------------------------------------------------------------------------------------------");

                }
                if (value == 0)
                {
                    Console.WriteLine($"Foods Are Not Available.");
                }
                else
                {
                    // Ask the user to enter FoodID and orderQuantity;
                    Console.WriteLine($"Enter the Food ID : ");
                    string foodID = Console.ReadLine().ToUpper();
                    Console.WriteLine($"Enter the Quantity : ");
                    int quantity = int.Parse(Console.ReadLine());
                    int valid = 0;
                    // Validate foodID and OrderQuantity
                    foreach (FoodDetails food in foodList)
                    {
                        if (foodID.Equals(food.FoodID))
                        {
                            valid = 1;
                            if (food.QuantityAvailable >= quantity)
                            {
                                //if valid store into temporary itemList.and reduce the count
                                double totalPrice = quantity * food.PricePerQuantity;
                                ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, quantity, totalPrice);
                                localItemList.Add(item);
                                food.QuantityAvailable -= quantity;
                                order.TotalPrice = 0;
                                foreach (ItemDetails itemList in localItemList)
                                {
                                    order.TotalPrice += itemList.PriceOfOrder;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Food Quantity unavailabale.");
                            }
                        }
                    }
                    if (valid == 0)
                    {
                        Console.WriteLine($"Invalid FoodID");
                    }
                }
                // Ask user wheather continue or not
                Console.WriteLine($"Do you Want to continue Purchase? yes/No : ");
                bool cont = true;
                while (cont)
                {
                    string response = Console.ReadLine().ToUpper();
                    if ("YES".Equals(response))
                    {
                        cont = false;
                    }
                    else if ("NO".Equals(response))
                    {
                        cont = false;
                        bool confirm = true;
                        //if no, ask user to confirm purchase.
                        Console.WriteLine($"Do you Want to confirm Purchase ? Yes/No : ");
                        while (confirm)
                        {
                            string answer = Console.ReadLine().ToUpper();
                            if ("YES".Equals(answer))
                            {
                                // If yes,check the user balance and deduce amount from wallet. update the orderStatus,added into orderList.temporary itemlist are store in itemlist
                                confirm = false;
                                if (currentUser.WalletBalance >= order.TotalPrice)
                                {
                                    currentUser.DeductBalance(order.TotalPrice);
                                    order.OrderStatus = OrderStatus.Ordered;
                                    itemList.AddRange(localItemList);
                                    orderList.Add(order);
                                    Console.WriteLine($"Order Successfull. Your Order ID : {order.OrderID}");
                                    flag=false;
                                }
                                else
                                {
                                    flag=false;
                                    //If no, show insufficent balance and ask user to rechagre or not
                                    Console.WriteLine($"Insufficient Balance");
                                    Console.WriteLine($"Do you Want to recharge Your Wallet : ");
                                    bool recharge = true;
                                    while (recharge)
                                    {
                                        recharge = false;
                                        string respon = Console.ReadLine().ToUpper();
                                        if ("YES".Equals(respon))
                                        {
                                            // if yes means calculate required amount and ask the user to enter amount
                                            Console.WriteLine($"Required Amount {order.TotalPrice - currentUser.WalletBalance} Enter the amount : ");
                                            bool valid = false;
                                            double amount = 0;
                                            while (!valid)
                                            {
                                                valid = double.TryParse(Console.ReadLine(), out amount);
                                                if (valid && amount >= order.TotalPrice - currentUser.WalletBalance)
                                                {
                                                    Console.WriteLine($"Required Amount {order.TotalPrice - currentUser.WalletBalance} Enter the amount :  ");
                                                    valid = false;

                                                }
                                                else if (!valid)
                                                {
                                                    Console.WriteLine($"Invalid Format Enter Again : ");
                                                }
                                            }
                                            // if recharged, amount deducted from walletbalance. and update the status anded into list..temporary itemlist are store in itemlist
                                            currentUser.DeductBalance(order.TotalPrice);
                                            order.OrderStatus = OrderStatus.Ordered;
                                            itemList.AddRange(localItemList);
                                            orderList.Add(order);
                                            Console.WriteLine($"Order Successfull. Your Order ID : {order.OrderID}");
                                            flag=false;
                                        }
                                        else if ("NO".Equals(respon))
                                        {
                                            foreach (ItemDetails local in localItemList)
                                            {
                                                foreach (FoodDetails food in foodList)
                                                {
                                                    if (local.FoodID.Equals(food.FoodID))
                                                    {
                                                        food.QuantityAvailable += local.PurchaseCount;
                                                    }
                                                }
                                            }
                                            flag=false;

                                        }
                                    }


                                }
                            }
                            else if ("NO".Equals(answer))
                            {
                                //If no, return the itemlist to foodlist
                                confirm = false;
                                foreach (ItemDetails local in localItemList)
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (local.FoodID.Equals(food.FoodID))
                                        {
                                            food.QuantityAvailable += local.PurchaseCount;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid. Do you Want to confirm Purchase ? Yes/No :  ");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid. Do you Want to continue Purchase? yes/No :  ");
                    }
                }


            } while (flag);
        }
        //Cancel Order 
        public static void CancelOrder()
        {
            // Show OrerDetails of current user
            Console.WriteLine($"------------------------------------------------------------");
            Console.WriteLine($"|{"OrderID",-8}|{"TotalPrice",-8}|{"DateOfOrder",-12}|{"OrderStatus",-10}|");
            Console.WriteLine($"-----------------------------------------------------------------");
            int flag = 0;
            foreach (OrderDetails list in orderList)
            {
                if (list.CustomerID.Equals(currentUser.CustomerID) && list.OrderStatus == OrderStatus.Ordered)
                {
                    flag = 1;
                    Console.WriteLine($"|{list.OrderID,-8}|{list.TotalPrice,-8}|{list.DateOfOrder.ToString("dd/MM/yyyy"),-12}|{list.OrderStatus,-10}|");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"No Data Found.");

            }
            else
            {
                //Ask the user to pick OrderID.
                Console.WriteLine($"Enter the OrderID : ");
                string orderID = Console.ReadLine().ToUpper();
                int valid = 0;
                // Validate orderID
                foreach (OrderDetails list in orderList)
                {
                    if (list.OrderID.Equals(orderID) && currentUser.CustomerID.Equals(list.CustomerID))
                    {
                        // if valid, refund the amount to user and upfdate the orderStatus=cancelled
                        valid = 1;
                        list.OrderStatus = OrderStatus.Cancelled;
                        currentUser.WalletRecharge(list.TotalPrice);
                        foreach (ItemDetails item in itemList)
                        {
                            if (list.OrderID.Equals(item.OrderID))
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        food.QuantityAvailable += item.PurchaseCount;
                                    }
                                }
                            }
                        }
                    }
                }
                if (valid == 0)
                {
                    Console.WriteLine($"Invalid OrderID");
                }
                else
                {
                    Console.WriteLine($"Order Cancelled Successfully");
                }
            }

        }
        // Modify Order
        public static void ModifyOrder()
        {
            // Show OrderDetails of current user.
            Console.WriteLine($"------------------------------------------------------------");
            Console.WriteLine($"|{"OrderID",-8}|{"TotalPrice",-8}|{"DateOfOrder",-12}|{"OrderStatus",-10}|");
            Console.WriteLine($"-----------------------------------------------------------------");

            foreach (OrderDetails list in orderList)
            {
                if (list.CustomerID.Equals(currentUser.CustomerID) && list.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"|{list.OrderID,-8}|{list.TotalPrice,-8}|{list.DateOfOrder.ToString("dd/MM/yyyy"),-12}|{list.OrderStatus,-10}|");

                }
            }
            // Ask the user to enter orderID
            Console.WriteLine($"Enter the OrderID :");
            string orderID = Console.ReadLine().ToUpper();
            int valid = 0;
            foreach (OrderDetails list in orderList)
            {
                // if valid show itemDetails of orderId.
                if (list.OrderID.Equals(orderID))
                {
                    valid = 1;
                    Console.WriteLine($"-------------------------------------------------------");
                    Console.WriteLine($"|{"ItemID",-8}|{"OrderID",-8}|{"FoodID",-8}|{"PurchaseCount",-13}|{"PrceOfOrder",-13}|");
                    Console.WriteLine($"-----------------------------------------------------------------");
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OrderID.Equals(list.OrderID))
                        {

                            Console.WriteLine($"|{item.ItemID,-8}|{item.OrderID,-8}|{item.FoodID,-8}|{item.PurchaseCount,-13}|{item.PriceOfOrder,-13}|");
                        }
                    }
                    // ask the user to enter itemList
                    Console.WriteLine($"Enter the ItemID : ");
                    string itemID = Console.ReadLine().ToUpper();
                    int present = 0;
                    // validate itemId.
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OrderID.Equals(list.OrderID))
                        {
                            if (item.ItemID.Equals(itemID))
                            {
                                present = 1;
                                //if valid, Ask the new Quantity
                                Console.WriteLine($"Enter the new Quantity : ");
                                int newQuantity = int.Parse(Console.ReadLine());
                                foreach (FoodDetails food in foodList)
                                {
                                    if (food.FoodID.Equals(item.FoodID))
                                    {
                                        // update the availablequantity and amount
                                        food.QuantityAvailable += item.PurchaseCount;
                                        food.QuantityAvailable -= newQuantity;
                                        double newAmount = newQuantity * food.PricePerQuantity;
                                        double oldAmount = item.PriceOfOrder;
                                        item.PurchaseCount = newQuantity;
                                        item.PriceOfOrder = newAmount;
                                        // based on newamount and oldAmount refund or deduct from the user walletbalance
                                        if (newAmount > oldAmount)
                                        {
                                            if (currentUser.WalletBalance >= newAmount - oldAmount)
                                            {
                                                currentUser.DeductBalance(newAmount - oldAmount);
                                                foreach(OrderDetails order in orderList)
                                                {
                                                    if(order.CustomerID.Equals(currentUser.CustomerID) && order.OrderID.Equals(item.OrderID))
                                                    {
                                                        order.TotalPrice+=(newAmount-oldAmount);
                                                    }
                                                }
                                                // Display modified successfully
                                                Console.WriteLine($"Order ID {item.OrderID} modified Successfully");
                                                

                                            }
                                            else
                                            {
                                                Console.WriteLine($"Insufficient Balance.Rechagre and Then procced Modify Order.");
                                                break;
                                            }
                                        }
                                        else if (oldAmount > newAmount)
                                        {
                                            currentUser.WalletRecharge(oldAmount - newAmount);
                                             foreach(OrderDetails order in orderList)
                                                {
                                                    if(order.CustomerID.Equals(currentUser.CustomerID) && order.OrderID.Equals(item.OrderID))
                                                    {
                                                        order.TotalPrice-=(oldAmount-newAmount);
                                                    }
                                                }
                                            Console.WriteLine($"Order ID {item.OrderID} modified Successfully");
                                        }
                                    }
                                }

                            }
                        }
                    }
                    if (present == 0)
                    {
                        Console.WriteLine($"Invalid ItemID");
                    }
                }
            }
            if (valid == 0)
            {
                Console.WriteLine($"invalid OrderID");

            }

        }
        // OrderHistory
        public static void OrderHistory()
        {
            // show OrderHistory
            Console.WriteLine($"|{"OrderID",-8}|{"TotalPrice",-8}|{"DateOfOrder",-12}|{"OrderStatus",-10}|");
            Console.WriteLine($"-----------------------------------------------------------------");
            int flag = 0;
            foreach (OrderDetails list in orderList)
            {
                if (list.CustomerID.Equals(currentUser.CustomerID))
                {
                    flag = 1;
                    Console.WriteLine($"|{list.OrderID,-8}|{list.TotalPrice,-8}|{list.DateOfOrder.ToString("dd/MM/yyyy"),-12}|{list.OrderStatus,-10}|");
                    Console.WriteLine($"--------------------------------------------------------------------------------------");

                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"No Data Found");
            }

        }
        // Recharge Wallet
        public static void RechargeWallet()
        {
            // ask the user to enter amount;
            Console.Write($"Enter Amount (Minimum Recharge rs100): ");
            double balance = 0;
            bool valid=false;
            while(!valid)
            {
                valid=double.TryParse(Console.ReadLine(),out balance);
                if(!valid)
                {
                    Console.Write($"Invalid Format Enter Again : ");
                }
                else if(valid && balance<=100)
                {
                    valid=false;
                    Console.WriteLine($"Minimum Recharge rs100. Enter Balance Again : ");    
                }
            } 
            double amount = double.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge Successfully");
        }
        // Show Wallet Balance
        public static void ShowWalletBalance()
        {
            // Display Show WalletBalance
            Console.WriteLine($" Wallet Balance : {currentUser.WalletBalance}");

        }
        // Add Default value
        public static void AddDefaultValue()
        {
            //create a object for customerDetails
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gamil.com", "Chennai", 10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "Baskaran@gamil.com", "Chennai", 15000);
            // Added into customerList
            CustomList<CustomerDetails> customer=new CustomList<CustomerDetails>(){ customer1, customer2 };
            customerList.AddRange(customer);
            //Create a object for Fooddetails
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
            // Added into foodList
            CustomList<FoodDetails> food=new CustomList<FoodDetails>(){ food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11 };
            foodList.AddRange(food);
            // Create a object for OrderDetails
            OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            //Added into orderList
            CustomList<OrderDetails> order=new CustomList<OrderDetails>(){order1, order2, order3};
            orderList.AddRange(order);
            // create a objecct for ItemDetails
            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2001", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
            // Addded into itemList
            CustomList<ItemDetails> item=new CustomList<ItemDetails>(){ item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };
            itemList.AddRange(item);
        }
    }
}