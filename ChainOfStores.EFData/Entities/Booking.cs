using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Entities
{
    public class Booking
    {
        private static int nextId;

        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
