using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Repositories.Realisation.EFRealisation
{
    public class EFBookingDurationRepository : EFGenericRepository<BookingDuration, int>, IBookingDurationRepository
    {
        public EFBookingDurationRepository(EFAppDBContext dbContext) : base(dbContext)
        {
        }
    }
}
