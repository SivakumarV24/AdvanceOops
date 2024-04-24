using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    // Enum
    /// <summary>
    /// Datatype Gender used to store the Gender Values
    /// </summary>
    public enum Gender{
        Select,Male,Female,Transgender
    }
    /// <summary>
    /// PersonDetails used to store the personalDetails
    /// </summary>
    public class PersonalDetails
    {
        // property
        /// <summary>
        /// Name Property used to store Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// FatherName Property used to store FatherName
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Gender Property used to store Gender
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile Property used to store Mobile
        /// </summary>
        /// <value></value>
        public string Mobile { get; set; }
        /// <summary>
        /// DOB Property used to store DOB
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// MailID Property used to store MailID
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// Location Property used to store Location
        /// </summary>
        /// <value></value>
        public string Location { get; set; }  
        // constructor
        /// <summary>
        /// PersonalDetails constructor used to Assign the value to the Property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dOB"></param>
        /// <param name="mailID"></param>
        /// <param name="location"></param>
        public PersonalDetails(string name, string fatherName, Gender gender, string mobile, DateTime dOB, string mailID, string location)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dOB;
            MailID = mailID;
            Location = location;
        }     
        public PersonalDetails(){}
    }
}