using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeteriaClassLibrary;

namespace CafeteriaCardManagement
{
    // Static Class
    /// <summary>
    /// Static class used to call a method without creating the instance <see cref="Operations"/>
    /// </summary>
    public static class Operations
    {
        // CustomList
        /// <summary>
        /// userList used to store the userDetails object.
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        /// <summary>
        /// OrderList used to store the OrderDetails Object
        /// </summary>
        /// <typeparam name="OrderDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        /// <summary>
        /// Cartlist used to store the CartItem Object
        /// </summary>
        /// <typeparam name="CartItem"></typeparam>
        /// <returns></returns>
        public static CustomList<CartItem> cartList = new CustomList<CartItem>();
        /// <summary>
        /// foodList used to store the carList.
        /// </summary>
        /// <typeparam name="FoodDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        // create a object for to store current userDetails
        /// <summary>
        /// UserDetails object used to store current user Details.
        /// </summary>
        static UserDetails currentUser;
        // Main Menu
        /// <summary>
        /// MainMenu method display the mainmenu
        /// </summary>
        public static void MainMenu()
        {
            bool flag = true;
            // Need to Display the Title
            Console.WriteLine($"**************Cafeteria Card Management************");
            Console.WriteLine();
            // run untill user choose exit
            do
            {
                // Need to Display Main Menu
                Console.WriteLine($"******Main Menu******");
                Console.WriteLine();
                Console.WriteLine($"1. User Registration");
                Console.WriteLine($"2. User Login");
                Console.WriteLine($"3. Exit");
                // ASk User to Choose Option
                Console.Write($"Enter the Option Given Above : ");
                bool valid = false;
                int mainOption = 0;
                while (!valid)
                {
                    valid = int.TryParse(Console.ReadLine(), out mainOption);
                    if (!valid)
                    {
                        Console.Write($"You Entered Invalid Format Enter Again : ");
                    }
                }
                // Based on Option Call method
                switch (mainOption)
                {
                    case 1:
                        {
                            // UserRegistration
                            Console.WriteLine($"*******User Registration********");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            // UserLogin
                            Console.WriteLine($"*********User Login*********");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            // Exit
                            Console.WriteLine($"**********Exit From Application***********");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            // User Entered Wrong Option
                            Console.WriteLine($"You Enter Wrong Option. Enter Again :  ");
                            break;
                        }
                }
            } while (flag);

        }//Main Menu Ends
        // UserRegistration Method.
        /// <summary>
        /// UserRegistration Method used to registration of new user
        /// </summary>
        public static void UserRegistration()
        {
            // Need To Ask User Details
            Console.Write($"Enter UserName:  ");
            string userName = Console.ReadLine();
            Console.Write($"Enter Father Name : ");
            string fatherName = Console.ReadLine();
            Console.Write($"Enter Mobile Number : ");
            long mobileNumber = 0;
            bool valid = false;
            while (!valid)
            {
                valid = long.TryParse(Console.ReadLine(), out mobileNumber);
                if (!valid)
                {
                    Console.Write($"You Entered Invalid Format. Enter Mobile Number Again : ");
                }
            }
            Console.Write($"Enter MailID : ");
            string mailID = "";
            valid = false;
            while (!valid)
            {
                mailID = Console.ReadLine();
                if (mailID.Contains("@gmail.com"))
                {
                    valid = true;
                }
                else
                {
                    Console.Write($"You Entered Invalid Format. Enter MailID Again : ");
                }
            }
            Console.Write($"Enter Gender : ");
            Gender gender = Gender.Male;
            valid = false;
            while (!valid)
            {
                valid = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
                if (!valid)
                {
                    Console.Write($"You Entered Invalid Format. Enter Gender Again : ");
                }
            }
            Console.Write($"Enter WorkStation Number ex:(WS101) : ");
            string workStationNumber = "";
            valid = false;
            while (!valid)
            {
                workStationNumber = Console.ReadLine().ToUpper();
                if (workStationNumber.Contains("WS"))
                {
                    valid = true;
                }
                else
                {
                    Console.Write($"You Entered Invalid Format. Enter MailID Again : ");
                }
            }

            Console.Write($"Enter Balance : ");
            double balance = 0;
            valid = false;
            while (!valid)
            {
                valid = double.TryParse(Console.ReadLine(), out balance);
                if (balance >= 100 && valid == true)
                {
                    valid = true;
                }
                else
                {
                    Console.Write($"Minimum Balance 100rs. Enter Amount more than or  Equal to 100 : ");
                }

            }
            // Create a object for userDetails
            UserDetails userDetails = new UserDetails(userName, fatherName, gender, mobileNumber, mailID, workStationNumber, balance);
            // Adding UserDetails in userList
            userList.Add(userDetails);
            // Show USerID
            Console.WriteLine($"Registration Successfully. Your Used Id : {userDetails.UserID}");
        }
        // UserLogin
        /// <summary>
        /// Validate the user Using login method
        /// </summary>
        public static void UserLogin()
        {
            int flag = 0;
            // Need to Ask UserId from user.
            Console.WriteLine($"Enter User ID : ");
            string userID = Console.ReadLine().ToUpper();
            // validate the userID
            foreach (UserDetails user in userList)
            {
                if (user.UserID.Equals(userID))
                {
                    // if valid then show Sub menu.
                    flag = 1;
                    currentUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"Invalid UserID");
            }
        }
        // SubMenu Method
        /// <summary>
        /// Display SubMenu
        /// </summary>
        public static void SubMenu()
        {
            // Need to Display sub menu
            // run untill User choose exit
            bool flag = true;
            do
            {
                Console.WriteLine($"*********Sub Menu*********");
                Console.WriteLine();
                Console.WriteLine($"1. Show My Profile\n2. Food Order\n3. Modify Order\n4. Cancel Order\n5. Order History\n6. Wallet Recharge\n7. ShowBalance\n8. Exit");
                // Ask usesr to choose option
                Console.Write($"Enter the Option : ");
                int subOption = 0;
                bool valid = false;
                while (!valid)
                {
                    valid = int.TryParse(Console.ReadLine(), out subOption);
                    if (!valid)
                    {
                        Console.Write($"You Enter Invalid Format. Enter Again  : ");
                    }
                }
                //based on suboption call methods
                switch (subOption)
                {
                    case 1:
                        {
                            // Show my profile
                            Console.WriteLine($"********Show My Profile********");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            // Food Order
                            Console.WriteLine($"***********Food Order************");
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            // Modify Order
                            Console.WriteLine($"**************Modify Order***********");
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            // Cancel Order
                            Console.WriteLine($"*************Cancel Order************");
                            CancelOrder();
                            break;
                        }
                    case 5:
                        {
                            // Order History
                            Console.WriteLine($"**************Order History**************");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            // Wallet Recharge
                            Console.WriteLine($"**************Wallet Recharge**************");
                            WalletRecharge();
                            Console.WriteLine();
                            break;
                        }
                    case 7:
                        {
                            // Show Wallet Balance
                            Console.WriteLine($"**************Wallet Balance************");
                            Console.WriteLine($"Walet Balance : {currentUser.WalletBalance}");
                            Console.WriteLine();
                            break;
                        }
                    case 8:
                        {
                            // Exit from Submenu
                            flag = false;
                            Console.WriteLine($"*******Exit From SubMenu*******");
                            break;
                        }
                    default:
                        {
                            // invalid input
                            Console.Write($"You Enter Wrong Option. Enter Again :  ");
                            break;
                        }
                }

            } while (flag);
        }
        // Show Profile
        /// <summary>
        /// Display current user Profile
        /// </summary>
        public static void ShowProfile()
        {
            // Display Currentuser Detail
            Console.WriteLine($"Your UserID : {currentUser.UserID}");
            Console.WriteLine($"Your Name : {currentUser.Name}");
            Console.WriteLine($"Your Father Name : {currentUser.FatherName}");
            Console.WriteLine($"Your Gender : {currentUser.Gender}");
            Console.WriteLine($"Your Mobile Number : {currentUser.Mobile}");
            Console.WriteLine($"Your MailID : {currentUser.MailID}");
            Console.WriteLine($"Your Workstation Number : {currentUser.WorkStationNumber}");
            Console.WriteLine($"Your Wallet Balance : {currentUser.WalletBalance}");
            Console.WriteLine();
        }
        // Food Order
        /// <summary>
        /// Food Order 
        /// </summary>
        public static void FoodOrder()
        {
            // need to create temporary cartItemList
            CustomList<CartItem> cartItemList = new CustomList<CartItem>();
            // need to create a object for orderDetails
            OrderDetails order = new OrderDetails(currentUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            bool flag = true;
            // run until user said no.
            do
            {
                //  Show Food Details
                Console.WriteLine();
                Console.WriteLine($"|{"FoodID",-8}|{"FoodName",-10}|{"Price",-6}|{"AvailableQuantity",-18}");
                Console.WriteLine($"---------------------------------------------------------------------------");
                foreach (FoodDetails foodList in foodList)
                {
                    Console.WriteLine($"|{foodList.FoodID,-8}|{foodList.FoodName,-10}|{foodList.FoodPrice,-6}|{foodList.AvailableQuantity,-18}");
                }
                Console.WriteLine($"---------------------------------------------------------------------------");
                // Ask user to  enter foodid and quantity
                Console.Write($"Enter The FoodID : ");
                string foodID = Console.ReadLine().ToUpper();
                Console.Write($"Enter the Quantity : ");
                int quantity = int.Parse(Console.ReadLine());
                int valid = 0;
                // check wheather foodid and quantity are valid.
                foreach (FoodDetails list in foodList)
                {
                    if (list.FoodID.Equals(foodID))
                    {
                        valid = 1;
                        if (list.AvailableQuantity >= quantity)
                        {
                            // if valid create a objecct for cartItem and store in cartItemList.
                            list.AvailableQuantity -= quantity;
                            double totalPrice = list.FoodPrice * quantity;
                            CartItem cartItem = new CartItem(order.OrderID, foodID, totalPrice, quantity);
                            cartItemList.Add(cartItem);
                            Console.WriteLine($"FoodDetails Added To  CartList");

                        }
                        else
                        {
                            Console.WriteLine($"Your required quantity is greater than available quantity. AvailableQuantity : {list.AvailableQuantity}");
                        }
                    }
                }
                if (valid == 0)
                {
                    Console.WriteLine($"Invalid FoodID");
                }
                // Ask the user want to continue or not.
                Console.Write($"Do you Want To Pick another Product ? Yes/No : ");
                string answer = "";
                bool response = true;
                while (response)
                {
                    answer = Console.ReadLine().ToUpper();
                    if ("YES".Equals(answer))
                    {
                        // if "yes" means continue the process.
                        response = false;
                    }
                    else if ("NO".Equals(answer))
                    {
                        // if "No" means ask the user to confirm the wish list to purchase.
                        bool confirm = true;
                        string purchase = "";
                        while (confirm)
                        {
                            Console.Write($"Do you Want to Confirm the wish lsit to purchase ? Yes/ No : ");
                            purchase = Console.ReadLine().ToUpper();
                            if (purchase.Equals("YES"))
                            {
                                // if "yes" means calculate totalamount and deduct amount from user Wallet
                                double totalAmount = 0;
                                foreach (CartItem list in cartItemList)
                                {
                                    totalAmount += list.OrderPrice;
                                }
                                if (totalAmount <= currentUser.WalletBalance)
                                {
                                    // deduct amount then add cartItemlist to cartList (globally) and update the orderstatus to "ordered". added to the OrderList.
                                    bool deduct = currentUser.DeductAmount(totalAmount);
                                    cartList.AddRange(cartItemList);
                                    order.TotalPrice = totalAmount;
                                    order.OrderStatus = OrderStatus.Ordered;
                                    orderList.Add(order);
                                    // show the OrderId
                                    Console.WriteLine($"Order Placed successfully and Order Id is {order.OrderID}.");
                                    confirm=false;
                                    response=false;
                                    flag=false;
                                }
                                else
                                {
                                    // if Insufficient balance to purchase . then ask the user to recharge the wallent
                                    Console.WriteLine($"Insufficient balance to purchase.");
                                    bool recharge = true;
                                    string walletRecharge = "";
                                    while (recharge)
                                    {
                                        Console.Write($"Are you willing to  recharge ? Yes/No :");
                                        walletRecharge = Console.ReadLine().ToUpper();
                                        if ("YES".Equals(walletRecharge))
                                        {
                                            // if "yes" means recharge the wallent and deduct amount then add cartItemlist to cartList (globally) and update the orderstatus to "ordered". added to the OrderList.
                                            response = false;
                                            recharge = false;
                                            confirm = false;
                                            flag = false;
                                            bool rechargeValid = false;
                                            double amount = 0;
                                            while (!rechargeValid)
                                            {
                                                Console.Write($"Enter The Amount to Recharge (required Amount {totalAmount - currentUser.WalletBalance}) : ");
                                                rechargeValid = double.TryParse(Console.ReadLine(), out amount);
                                                if (rechargeValid && amount >= totalAmount - currentUser.WalletBalance)
                                                {
                                                    rechargeValid = true;
                                                }
                                                else
                                                {
                                                    Console.Write($"Invalid input.");
                                                }
                                            }
                                            bool deduct = currentUser.DeductAmount(totalAmount);
                                            cartList.AddRange(cartItemList);
                                            order.TotalPrice = totalAmount;
                                            order.OrderStatus = OrderStatus.Ordered;
                                            orderList.Add(order);
                                             // show the OrderId
                                            Console.WriteLine($"Order Placed successfully and Order Id is {order.OrderID}.");
                                            
                                        }
                                        else if ("NO".Equals(walletRecharge))
                                        {
                                            // if no means show "Exiting without Order due to insufficient balance" return the items form cartItems to fooditems
                                            response = false;
                                            recharge = false;
                                            confirm = false;
                                            flag = false;
                                            Console.WriteLine($"Exiting without Order due to insufficient balance");
                                            foreach (CartItem list in cartItemList)
                                            {
                                                foreach (FoodDetails foodList in foodList)
                                                {
                                                    if (list.FoodID.Equals(foodList.FoodID))
                                                    {
                                                        foodList.AvailableQuantity += list.OrderQuantity;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.Write($"Invalid Response.");
                                        }
                                    }

                                }
                            }
                            else if (purchase.Equals("NO"))
                            {
                                // if no means return the items form cartItems to fooditems
                                response = false;
                                confirm = false;
                                flag = false;
                                foreach (CartItem list in cartItemList)
                                {
                                    foreach (FoodDetails foodList in foodList)
                                    {
                                        if (list.FoodID.Equals(foodList.FoodID))
                                        {
                                            foodList.AvailableQuantity += list.OrderQuantity;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.Write($"You Enter Wrong Response.");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine($"You Enter Wrong Response.Do you Want To Pick another Product ? Yes/No : ");
                    }
                }
            } while (flag);
        }
        // Modify Order
        /// <summary>
        /// Edit the order using Modify Order Method
        /// </summary>
        public static void ModifyOrder()
        {
            // show the orderDetails of currentUser where orderStatus =ordered.
            Console.WriteLine();
            int flag = 0;
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"Order Date",-12}|{"TotalPrice",-11}|{"Order Status",-13}");
            Console.WriteLine($"---------------------------------------------------");
            foreach (OrderDetails list in orderList)
            {
                if (currentUser.UserID.Equals(list.UserID) && list.OrderStatus == OrderStatus.Ordered)
                {
                    flag = 1;
                    Console.WriteLine($"|{list.OrderID,-8}|{list.UserID,-8}|{list.OrderDate.ToString("dd/MM/yyyy"),-12}|{list.TotalPrice,-11}|{list.OrderStatus,-13}");
                    Console.WriteLine($"---------------------------------------------------");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"No data Found");
            }
            else
            {
                // ask the user to enter the orderID to modify.
                Console.Write($"Enter the OrerID : ");
                string orderID = Console.ReadLine().ToUpper();
                int valid = 0;
                // validate the orderID.
                foreach (OrderDetails list in orderList)
                {
                    if (currentUser.UserID.Equals(list.UserID) && list.OrderStatus == OrderStatus.Ordered && orderID.Equals(list.OrderID))
                    {
                        // if valid show cart Items.
                        valid = 1;
                        System.Console.WriteLine();
                        Console.WriteLine($"|{"ItemID",-8}|{"OrderID",-8}|{"FoodID",-8}|{"OrderPrice",-10}|{"OrderQuantity",-13}|");
                        Console.WriteLine($"---------------------------------------");
                        foreach (CartItem item in cartList)
                        {
                            if (list.OrderID.Equals(item.OrderID))
                            {
                                Console.WriteLine($"|{item.ItemID,-8}|{item.OrderID,-8}|{item.FoodID,-8}|{item.OrderPrice,-10}|{item.OrderQuantity,-13}|");
                            }
                        }
                        Console.WriteLine($"---------------------------------------");
                        //  ask the user to enter ItemID
                        Console.Write($"Enter The ItemId : ");
                        string itemID = Console.ReadLine().ToUpper();
                        // Validate itemID
                        foreach (CartItem item in cartList)
                        {
                            if (list.OrderID.Equals(item.OrderID) && item.ItemID.Equals(itemID))
                            {
                                // if validate then ask the user enter new Quantity.
                                double totalAmount = item.OrderPrice;
                                Console.Write($"Enter the new Quantity of the Food : ");
                                int quantity = int.Parse(Console.ReadLine());
                                // check the available quantity is greater than new quantity 
                                int validItem=0;
                                foreach (FoodDetails fList in foodList)
                                {
                                    if (fList.FoodID.Equals(item.FoodID))
                                    {
                                        validItem=1;
                                        // if "yes" calculate the amount if old quantity is greater than new quantity. add amount to wallet else deduct amount update orderDetails. 
                                        fList.AvailableQuantity += item.OrderQuantity;
                                        if (quantity <= fList.AvailableQuantity)
                                        {
                                            fList.AvailableQuantity -= quantity;
                                            double newTotalAmount = quantity * fList.FoodPrice;
                                            if (newTotalAmount > totalAmount)
                                            {
                                                bool deduct = currentUser.DeductAmount(newTotalAmount - totalAmount);
                                            }
                                            else if (newTotalAmount < totalAmount)
                                            {
                                                currentUser.WalletBalance += totalAmount - newTotalAmount;
                                            }
                                            list.TotalPrice = newTotalAmount;
                                            Console.WriteLine($"Order Modified Successfully.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Your required Quantity is greater than available quantity. Available Quantity : {fList.AvailableQuantity}");

                                        }
                                    }
                                }
                                if(validItem==0)
                                {
                                    Console.WriteLine($"Invaild ItemID");
                                }
                            }
                        }


                    }
                }
                if (valid == 0)
                {
                    Console.WriteLine($"Invalid OrderID");
                }
            }

        }
        // Cancel Order
        /// <summary>
        /// Cancel the order using CancelOrder Method
        /// </summary>
        public static void CancelOrder()
        {
            //  show orderDetails.
            Console.WriteLine();
            int flag = 0;
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"Order Date",-12}|{"TotalPrice",-11}|{"Order Status",-13}");
            Console.WriteLine($"---------------------------------------------------");
            foreach (OrderDetails list in orderList)
            {
                if (currentUser.UserID.Equals(list.UserID) && list.OrderStatus == OrderStatus.Ordered)
                {
                    flag = 1;
                    Console.WriteLine($"|{list.OrderID,-8}|{list.UserID,-8}|{list.OrderDate.ToString("dd/MM/yyyy"),-12}|{list.TotalPrice,-11}|{list.OrderStatus,-13}");
                    Console.WriteLine($"---------------------------------------------------");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"No data Found");
            }
            else
            {
                // Ask  user to enter OrderID
                Console.Write($"Enter the OrerID : ");
                string orderID = Console.ReadLine().ToUpper();
                int valid = 0;
                foreach (OrderDetails list in orderList)
                {
                    // valid OrderID.
                    if (currentUser.UserID.Equals(list.UserID) && list.OrderStatus == OrderStatus.Ordered && orderID.Equals(list.OrderID))
                    {
                        //  if valid change the orderStatus to Cancelled and Add total price to wallet.
                        valid = 1;
                        list.OrderStatus = OrderStatus.Cancelled;
                        currentUser.WalletBalance += list.TotalPrice;
                        foreach (CartItem item in cartList)
                        {
                            if (item.OrderID.Equals(list.OrderID))
                            {
                                foreach (FoodDetails fList in foodList)
                                {
                                    if (fList.FoodID.Equals(item.FoodID))
                                    {
                                        fList.AvailableQuantity += item.OrderQuantity;
                                    }
                                }
                            }
                        }
                    }
                }
                if (valid == 0)
                {
                    Console.WriteLine($"Invalid OrderID.");

                }
                else
                {
                    Console.WriteLine($"Order Cancel Successfully.");

                }
            }
        }
        // Order History
        /// <summary>
        /// Display the OrderHistory
        /// </summary>
        public static void OrderHistory()
        {
            // show the order History of  orderHistory
            Console.WriteLine();
            int flag = 0;
            Console.WriteLine($"|{"OrderID",-8}|{"UserID",-8}|{"Order Date",-12}|{"TotalPrice",-11}|{"Order Status",-13}");
            Console.WriteLine($"---------------------------------------------------");
            foreach (OrderDetails list in orderList)
            {
                if (currentUser.UserID.Equals(list.UserID))
                {
                    flag = 1;
                    Console.WriteLine($"|{list.OrderID,-8}|{list.UserID,-8}|{list.OrderDate.ToString("dd/MM/yyyy"),-12}|{list.TotalPrice,-11}|{list.OrderStatus,-13}");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"No data Found");

            }
            Console.WriteLine($"---------------------------------------------------");



        }
        //Wallet Recharge
        /// <summary>
        /// Recharge Wallet using Wallet recharge
        /// </summary>
        public static void WalletRecharge()
        {
            // ask the user to enter amount greater than 100.
            Console.Write($"Enter the Amount to Rechagre Minimum Recharge 100rs : ");
            double amount = 0;
            bool valid = false;
            while (!valid)
            {
                valid = double.TryParse(Console.ReadLine(), out amount);
                if (amount >= 100 && valid == true)
                {
                    valid = true;
                }
                else
                {
                    Console.Write($"Minimum Balance 100rs. Enter Amount more than or  Equal to 100 : ");
                    valid=false;
                }
            }
            // add amount to wallet Balance
            bool recharge = currentUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successfully. Wallet Balance : {currentUser.WalletBalance}");
        }
        // Add Default Value
        /// <summary>
        /// Add Default value using this mehtod.
        /// </summary>
        public static void AddDefaultValue()
        {
            // Create a object for UserDetails
            UserDetails userOne = new UserDetails("Ravichandran", "Ettapparajan", Gender.Male, 8857777575, "ravi@gmai.com", "WS101", 400);
            UserDetails userTwo = new UserDetails("Baskaran", "Sethurajan", Gender.Male, 9577747744, "baskaran@gmail.com", "WS105", 500);
            // UserDetails are Store in UserList
            userList.Add(userOne);
            userList.Add(userTwo);
            // Create a object for OrderDetails
            OrderDetails orderOne = new OrderDetails("SF1001", new DateTime(2022, 6, 15), 70, OrderStatus.Ordered);
            OrderDetails orderTwo = new OrderDetails("SF1002", new DateTime(2022, 6, 15), 100, OrderStatus.Ordered);
            // OrderDetails are Store in OrderList
            orderList.Add(orderOne);
            orderList.Add(orderTwo);
            // Create a object for CartItems
            CartItem cart1 = new CartItem("OID1001", "FID101", 20, 1);
            CartItem cart2 = new CartItem("OID1001", "FID103", 10, 1);
            CartItem cart3 = new CartItem("OID1001", "FID105", 40, 1);
            CartItem cart4 = new CartItem("OID1002", "FID103", 10, 1);
            CartItem cart5 = new CartItem("OID1002", "FID104", 50, 1);
            CartItem cart6 = new CartItem("OID1002", "FID105", 40, 1);
            // CartItems are Store in cartList
            cartList.Add(cart1);
            cartList.Add(cart2);
            cartList.Add(cart3);
            cartList.Add(cart4);
            cartList.Add(cart5);
            cartList.Add(cart6);
            // Create a object for FoodDetails
            FoodDetails foodDetails = new FoodDetails("Coffee", 20, 100);
            FoodDetails foodDetails1 = new FoodDetails("Tea", 15, 100);
            FoodDetails foodDetails2 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails foodDetails3 = new FoodDetails("Juice", 50, 100);
            FoodDetails foodDetails4 = new FoodDetails("Puff", 40, 100);
            FoodDetails foodDetails5 = new FoodDetails("Milk", 10, 100);
            FoodDetails foodDetails6 = new FoodDetails("Popcorn", 20, 20);
            //foode details are stored in foodlist
            foodList.AddRange(new CustomList<FoodDetails> { foodDetails, foodDetails1, foodDetails2, foodDetails3, foodDetails4, foodDetails5, foodDetails6 });
        }
    }

}