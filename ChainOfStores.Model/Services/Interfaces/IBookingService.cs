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
         public void MakeBooking(Guid productID, Guid storeId, DateTime dataOfBooking);
        public IEnumerable<BookingView> GetAllBookings();
        public IEnumerable<BookingView> GetAllBookingsInStore(Guid storeID);
        public void DeleteBookin(Guid bookingID);
        public BookingView GetBookingByID(Guid bookingID);
    }
}
