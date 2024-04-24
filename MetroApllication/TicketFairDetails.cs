using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// TicketFairDetails class used to create a instance of ticket <see cref="TicketFairDetails"/>
    /// </summary>
    public class TicketFairDetails
    {
        /*Properties:
        •	TicketID (Auto Generated – MR3001)
        •	FromLocation
        •	ToLocation
        •	TicketPrice
        */
        // Field
        /// <summary>
        /// Static field ticketID is used to autoincreament the TicketID
        /// </summary>
        private static int s_ticketId=3000;

        //property
        /// <summary>
        /// Ticket is used to store TicketID
        /// </summary>
        /// <value></value>
        public string TicketID { get; } // Read Only
        /// <summary>
        /// From location is used to store fromLocation
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        /// To location is used to store To Location
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// TicketPrice is used to store the ticket price 
        /// </summary>
        /// <value></value>
        public int TicketPrice { get; set; }
        //Constructor
        /// <summary>
        /// TicketFairDetails constructor used to assign the default value to the property
        /// </summary>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="ticketPrice"></param>
        public TicketFairDetails( string fromLocation, string toLocation, int ticketPrice)
        {
            //Auto increamentation
            s_ticketId++;
            // Assigning value to the property
            TicketID="MR"+s_ticketId;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        } 
        /// <summary>
        /// TicketFairDetails constructor used to assign the value to the property that is come from csv File.
        /// </summary>
        /// <param name="ticketFairDetails"></param>
        public TicketFairDetails( string ticketFairDetails)
        {
            string[] value=ticketFairDetails.Split(",");
            s_ticketId=int.Parse(value[0].Remove(0,2));
            TicketID=value[0];
            FromLocation = value[1];
            ToLocation = value[2];
            TicketPrice = int.Parse(value[3]);
        } 
    }
}