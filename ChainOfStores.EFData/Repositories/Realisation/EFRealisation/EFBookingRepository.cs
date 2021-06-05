using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.Repositories.Inerfaces;
using ChainOfStores.EFData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Repositories.Realisation.EFRealisation
{
    class EFBookingRepository : EFGenericRepository<Booking, int>, IBookingRepository
    {
        public EFBookingRepository(EFAppDBContext dBContest) : base(dBContest)
        {
        }

    }
}
