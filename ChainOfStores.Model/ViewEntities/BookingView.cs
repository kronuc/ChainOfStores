using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    class BookingView
    {
        public Guid Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public DateTime DataOfBookingEnd { get; set; }
        public Guid StoreID { get; set; }
        public Guid ProductID { get; set; }
    }
}
