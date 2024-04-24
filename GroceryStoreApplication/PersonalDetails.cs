using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
     // Enum
     /// <summary>
     /// enum Gender DataType  used to  store the Gender
     /// </summary>
    public enum Gender{
        Male,Female,Transgender
    }
    /// <summary>
    /// PersonalDetails is used to Stroe the PersonalDetils of Customer
    /// </summary>
    public class PersonalDetails
    { 
        // property
        /// <summary>
        /// Name property used to Store the Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// FatherName property used to Store the FatherName
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Gender property used to Store the Gender
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile property used to Store the Mobile
        /// </summary>
        /// <value></value>
        public string Mobile { get; set; }
        /// <summary>
        /// DOB property used to Store the DOB
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// MailID property used to Store the MailID
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }  
        // constructor
        /// <summary>
        /// PersonalDetails used to assign the Default value to the property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dOB"></param>
        /// <param name="mailID"></param>
        public PersonalDetails(string name, string fatherName, Gender gender, string mobile, DateTime dOB, string mailID)
        {
            //Assign value to the property
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dOB;
            MailID = mailID;
        }
        public PersonalDetails(){}
    }
}