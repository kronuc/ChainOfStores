using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    class BookingServiceWithoutDB : IBookingService
    {
        public void DeleteBooking(int bookingID)
        {
            throw new NotImplementedException();
        }

        public void EditBooking(BookingView editedBooking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookingView> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookingView> GetAllBookingsInStore(int storeID)
        {
            throw new NotImplementedException();
        }

        public BookingView GetBookingByID(int bookingID)
        {
            throw new NotImplementedException();
        }

        public void MakeBooking(int productID, int storeId, DateTime dataOfBooking)
        {
            throw new NotImplementedException();
        }
        private void InitialiseData()
        { }
    }
}
