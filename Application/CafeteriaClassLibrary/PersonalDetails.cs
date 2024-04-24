using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    // Enum
    /// <summary>
    /// Gender enum Datatype used to store a fixed Value.
    /// </summary>
    public enum Gender{
        Male,Female,Transgender
    }
    /// <summary>
    /// PersonDetails class used to create a instance of user <see cref="PersonDetails"/>
    /// </summary>
    public class PersonalDetails
    {
       // Property
       /// <summary>
       /// Name property is used to store name
       /// </summary>
       /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// FatherName property is used to store FatherName
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Gender property is used to Store Gender
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile property is used to store mobile
        /// </summary>
        /// <value></value>
        public long Mobile { get; set; }
        /// <summary>
        /// MailID property used to store mailID.
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        // Constructor
        /// <summary>
        /// PersonDetails constructor used to initialize default values to its Properties. <see cref="PersonDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="mailID"></param>
        public PersonalDetails(string name,string fatherName,Gender gender,long mobile,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=mailID;
        }
        
    }
}