using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// Medicine Details class used to create a instance for medicineDetails <see cref="MedicineDetails"/>
    /// </summary>
    public class MedicineDetails
    {
        
        // field
        /// <summary>
        /// static field s_medicineID used to autoIncrementation of the medicineID
        /// </summary>
        private static int s_medicineID=100;
        // Property
        /// <summary>
        /// MedicineID property used to store MedicineID
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// MedicineName property used to store MedicineName
        /// </summary>
        /// <value></value>
        public string MedicineName { get; set; }
        /// <summary>
        /// AvailableCount property used to store AvailableCount
        /// </summary>
        /// <value></value>
        public int AvailableCount { get; set; }
        /// <summary>
        /// Price property used to store Price
        /// </summary>
        /// <value></value>
        public double Price { get; set; }
        /// <summary>
        /// DateOfExpiry property used to store DateOfExpiry
        /// </summary>
        /// <value></value>
        public DateTime DateOfExpiry { get; set; }
        // constructor
        /// <summary>
        /// MedicineDetails Constructor used to assign Default values to property
        /// </summary>
        /// <param name="medicineName"></param>
        /// <param name="availableCount"></param>
        /// <param name="price"></param>
        /// <param name="dateOfExpiry"></param>
        public MedicineDetails(string medicineName, int availableCount, double price, DateTime dateOfExpiry)
        {
            // Auto increamentation
            s_medicineID++;
            // Assigning value to property
            MedicineID="MD"+s_medicineID;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        /// <summary>
        /// MedicineDetails Constructor used to assign Default values to property
        /// </summary>
        /// <param name="medicine"></param>
        public MedicineDetails(string medicine)
        {
            string[] value=medicine.Split(",");
            // Assigning value to property
            s_medicineID=int.Parse(value[0].Remove(0,2));
            MedicineID=value[0];
            MedicineName = value[1];
            AvailableCount = int.Parse(value[2]);
            Price = int.Parse(value[3]);
            DateOfExpiry = DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
        }
        
        
        
        
        
        
    }
}