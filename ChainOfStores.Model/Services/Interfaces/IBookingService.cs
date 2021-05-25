using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    
    public interface IBookingService
    {
        public void MakeBooking(BookingView booking);
        public IEnumerable<BookingView> GetAllBookings();
        public void DeleteBooking(int bookingID);
        public BookingView GetBookingByID(int bookingID);
        public bool DoesProductAvailable(int productId);
    }
}
