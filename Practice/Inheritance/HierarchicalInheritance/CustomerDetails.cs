using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails: PersonalDetails
    {
        // Field
        private static int s_customerID=1000;
        //Property
        public string CustomerID { get;  } // Read Only
        public double Balance { get; set; }
        // Constructor
        public CustomerDetails(double balance,string userID,string name,string fatherName,Gender gender,string phoneNumber):base(userID,name,fatherName,gender,phoneNumber)
        {
            // Auto Increamentation
            s_customerID++;
            // Assigning value to property
            CustomerID="CID"+s_customerID;
            Balance=balance;
        }
        
        
        
    }
}