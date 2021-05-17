using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public class BookingServiceWithoutDB : IBookingService
    {
        public static List<BookingView> Bookings;

        public BookingServiceWithoutDB()
        {
        }
        static BookingServiceWithoutDB()
        {
            Bookings = new List<BookingView>();
            InitialiseData();
        }

        public void DeleteBooking(int bookingID)
        {
            Bookings.Remove(Bookings.Where(booking => booking.Id == bookingID).First());
        }

        public IEnumerable<BookingView> GetAllBookings()
        {
            return Bookings.ToList();
        }

        public BookingView GetBookingByID(int bookingID)
        {
            return Bookings.Where(booking => booking.Id == bookingID).FirstOrDefault();
        }

        public void MakeBooking(int productID, DateTime dataOfBooking)
        {
            Bookings.Add(new BookingView() 
            { 
                ProductID = productID, 
                DataOfBooking = dataOfBooking, 
            });
        }
        private static void InitialiseData()
        { }
    }
}
