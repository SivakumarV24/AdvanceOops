using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class FileHandling
    {
        //Create Folder and File
        public static void Create()
        {
            //Creating Folder
            if(!Directory.Exists("MovieTicketBooking"))
            {
                Directory.CreateDirectory("MovieTicketBooking");
            }
            //Creating UserDetails File
            if(!File.Exists("MovieTicketBooking/userDetails.csv"))
            {
                File.Create("MovieTicketBooking/userDetails.csv").Close();
            }
            //Creating MovieDetailsFile
            if(!File.Exists("MovieTicketBooking/movieDetails.csv"))
            {
                File.Create("MovieTicketBooking/movieDetails.csv").Close();
            }
            //Creating ThratreDetailsFile
            if(!File.Exists("MovieTicketBooking/theatreDetails.csv"))
            {
                File.Create("MovieTicketBooking/theatreDetails.csv").Close();
            }
            //Creating Screening Details File
            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                File.Create("MovieTicketBooking/ScreeningDetails.csv").Close();
            }
            //Creating for Booking Details
            if(!File.Exists("MovieTicketBooking/bookingDetails.csv"))
            {
                File.Create("MovieTicketBooking/bookingDetails.csv").Close();
            }
        }
        // WriteToCsv Method
        public static void WriteToCsv()
        {
            //Write to UserDetails
            string[] userDetails=new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                userDetails[i]=Program.userDetailsList[i].UserID+","+Program.userDetailsList[i].Name+","+Program.userDetailsList[i].Age+","+Program.userDetailsList[i].PhoneNumber+","+Program.userDetailsList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/userDetails.csv",userDetails);
            
            // Write to MovieDetils
            string[] moviDetails=new string[Program.movieDetailsList.Count];
            for(int i=0;i<Program.movieDetailsList.Count;i++)
            {
                moviDetails[i]=Program.movieDetailsList[i].MovieID+","+Program.movieDetailsList[i].MovieName+","+Program.movieDetailsList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/movieDetails.csv",moviDetails);

            //Write to TheatreDetails
            string[] theatreDetails=new string[Program.theatreDetailsList.Count];
            for(int i=0;i<Program.theatreDetailsList.Count;i++)
            {
                theatreDetails[i]=Program.theatreDetailsList[i].TheatreID+","+Program.theatreDetailsList[i].TheatreName+","+Program.theatreDetailsList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/theatreDetails.csv",theatreDetails);
            //Write to screeningDetails
            string[] screeningDetails=new string[Program.screeningDetailsList.Count];
            for(int i=0;i<Program.screeningDetailsList.Count;i++)
            {
                screeningDetails[i]=Program.screeningDetailsList[i].MovieID+","+Program.screeningDetailsList[i].TheatreID+","+Program.screeningDetailsList[i].NoOfSeats+","+Program.screeningDetailsList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screeningDetails);

            //Write to Bookingdetails
            string[] bookingDetails=new string[Program.bookingDetailsList.Count];
            for(int i=0;i<Program.bookingDetailsList.Count;i++)
            {
                bookingDetails[i]=Program.bookingDetailsList[i].BookingID+","+Program.bookingDetailsList[i].UserID+","+Program.bookingDetailsList[i].MovieID+","+Program.bookingDetailsList[i].TheatreID+","+Program.bookingDetailsList[i].SeatCount+","+Program.bookingDetailsList[i].TotalAmount+","+Program.bookingDetailsList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/bookingDetails.csv",bookingDetails);
            
        }
        //ReadFromCsv
        public static void ReadFromCsv()
        {
            // UserDetails
            string[] userDetails=File.ReadAllLines("MovieTicketBooking/userDetails.csv");
            for(int i=userDetails.Length-1;i>=0;i--)
            {
                UserDetails user=new UserDetails(userDetails[i]);
                Program.userDetailsList.Add(user);
            }

            //Movie Details
            string[] movieDetails=File.ReadAllLines("MovieTicketBooking/movieDetails.csv");
            for(int i=movieDetails.Length-1;i>=0;i--)
            {
                MovieDetails movie=new MovieDetails(movieDetails[i]);
                Program.movieDetailsList.Add(movie);
            }

            //theatreDetails
            string[] theatreDetails=File.ReadAllLines("MovieTicketBooking/theatreDetails.csv");
            for(int i=theatreDetails.Length-1;i>=0;i--)
            {
                TheatreDetails theatre=new TheatreDetails(theatreDetails[i]);
                Program.theatreDetailsList.Add(theatre);
            }

            //ScreeningDetails
            string[] screeningDetails=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            for(int i=screeningDetails.Length-1;i>=0;i--)
            {
                ScreeningDetails screening=new ScreeningDetails(screeningDetails[i]);
                Program.screeningDetailsList.Add(screening);
            }
            
            //BookingDetails
            string[] bookingDetails=File.ReadAllLines("MovieTicketBooking/bookingDetails.csv");
            for(int i=bookingDetails.Length-1;i>=0;i--)
            {
                BookingDetails booking=new BookingDetails(bookingDetails[i]);
                Program.bookingDetailsList.Add(booking);
            }    
        }
    }
}