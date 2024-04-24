using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// Travel Details class is used to create a instance for userTravel <see cref="TravelDetails"/>
    /// </summary>
    public class TravelDetails
    {
        /*Properties:
            a.	TravelId (Auto Generated -TID2001)
            b.	Card Number
            c.	FromLocation
            d.	ToLocation
            e.	Date
            f.	Travel Cost
        */
        //Field
        /// <summary>
        /// Static field travelID is used to autoincreament the TravelID
        /// </summary>
        private static int s_travelID=2000;

        //property
        /// <summary>
        /// TravelID is used to store the travelID
        /// </summary>
        /// <value></value>
        public string TravelID { get; set; }
        /// <summary>
        /// CardNumber is used to store the CardNumber
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// From location property is used to store the FromLocation
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        /// To Location property is used to store the Tolocation
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// Date property is used to store the Date of travel by user
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }
        /// <summary>
        /// Travel is used to store the fair price of fromlocation to toLocation
        /// </summary>
        /// <value></value>
        public int TravelCost { get; set; }
        //constructor
        /// <summary>
        /// TravelDetails Constructor is used to assihgn default value of the property <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="date"></param>
        /// <param name="travelCost"></param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, int travelCost)
        {
            // Auto increamentation
            s_travelID++;
            //Assigning Value to the Property
            TravelID ="TID"+s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        /// <summary>
        /// TravelDetails Constructor used to assign the value the property  it comes form csv file
        /// </summary>
        /// <param name="travelDetails"></param>
        public TravelDetails(string travelDetails)
        {
            string[] value=travelDetails.Split(",");
            s_travelID=int.Parse(value[0].Remove(0,3));
            TravelID =value[0];
            CardNumber = value[1];
            FromLocation = value[2];
            ToLocation = value[3];
            Date = DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
            TravelCost =int.Parse(value[5]);
        }


        
        
        
        
        
        
        
        
        
    }
}