using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// PersonalDetails class used to create a instance <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        
        // Property
        /// <summary>
        /// UserName property used to store userName.
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// PhoneNumber Property used to store phoneNumber
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }
        //  Constructor 
        /// <summary>
        /// PersonalDetails Constructor used to assign default value of the property <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string userName, long phoneNumber)
        {
            // Assigning value to property
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
        public PersonalDetails(){}
            
            
            
    }
}