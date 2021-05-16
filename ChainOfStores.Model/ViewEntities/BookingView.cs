using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    public class BookingView
    {
        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public int ProductID { get; set; }
    }
}
