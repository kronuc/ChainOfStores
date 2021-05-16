using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    class BookingView
    {
        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public DateTime DataOfBookingEnd { get; set; }
        public int StoreID { get; set; }
        public int ProductID { get; set; }
    }
}
