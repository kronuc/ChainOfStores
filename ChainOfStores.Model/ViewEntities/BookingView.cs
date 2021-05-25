using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    public class BookingView
    {
        public static int nextId;

        public BookingView()
        {
        }
        static BookingView()
        {
            nextId = 0;
        }
        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public int ProductID { get; set; }
        public string ClientName { get; set; }
    }
}
