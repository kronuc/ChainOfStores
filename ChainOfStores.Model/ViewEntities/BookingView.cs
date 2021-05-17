using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    public class BookingView
    {
        private static int nextId;

        public BookingView()
        {
            nextId++;
            this.Id = nextId;
        }
        static BookingView()
        {
            nextId = 0;
        }
        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public int ProductID { get; set; }
    }
}
