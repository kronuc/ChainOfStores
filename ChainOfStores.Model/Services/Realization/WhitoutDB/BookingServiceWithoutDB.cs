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
        private List<BookingView> _bookings;

        public BookingServiceWithoutDB()
        {
            _bookings = new List<BookingView>();

        }

        public void DeleteBooking(int bookingID)
        {
            _bookings.Remove(_bookings.Where(booking => booking.Id == bookingID).FirstOrDefault());
        }

        public IEnumerable<BookingView> GetAllBookings()
        {
            return _bookings.ToList();
        }

        public BookingView GetBookingByID(int bookingID)
        {
            return _bookings.Where(booking => booking.Id == bookingID).FirstOrDefault();
        }

        public void MakeBooking(BookingView booking)
        {
            _bookings.Add(new BookingView() 
            { 
                Id = BookingView.nextId,
                ProductID = booking.ProductID, 
                DataOfBooking = booking.DataOfBooking,
                ClientName = booking.ClientName
            });
            BookingView.nextId++;
        }
        public bool DoesProductAvailable(int productId)
        {
            return !_bookings.Where(booking => booking.ProductID == productId).Any();
        }
    }
}
