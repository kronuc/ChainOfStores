using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    
    interface IBookingService
    {
         public void MakeBooking(int productID, int storeId, DateTime dataOfBooking);
        public IEnumerable<BookingView> GetAllBookings();
        public IEnumerable<BookingView> GetAllBookingsInStore(int storeID);
        public void DeleteBooking(int bookingID);
        public BookingView GetBookingByID(int bookingID);
        public void EditBooking(BookingView editedBooking);
    }
}
