using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// PersonDetails Class used to create a instance for user <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        // property
        /// <summary>
        /// Name property used to store Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Age Property used to Store age.
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// City Property used to Store City
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// Phone Number Property used to Store PhonenUmber
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }
        // constructor
        /// <summary>
        /// PersonalDetails Constructor used to assign a default value to the property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string name, int age, string city, string phoneNumber)
        {
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phoneNumber;
        }
        public PersonalDetails(){}
    }
}