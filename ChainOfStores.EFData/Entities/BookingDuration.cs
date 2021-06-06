using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Entities
{
    public class BookingDuration : BaseEntity<int>
    {
        public int AmountOfDays { get; set; }
    }
}
