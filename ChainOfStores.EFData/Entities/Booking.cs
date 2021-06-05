using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Entities
{
    public class Booking : BaseEntity<int>
    {
        private static int nextId;

        public DateTime DataOfBooking { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public string ClientName { get; set; }
    }
}
