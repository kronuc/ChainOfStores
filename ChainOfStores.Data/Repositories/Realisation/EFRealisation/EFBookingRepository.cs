using ChainOfStores.Data.Entities;
using ChainOfStores.Data.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.Repositories.Realisation.EFRealisation
{
    class EFBookingRepository : IRepository<Booking>
    {
        private AppDBContext _DBContest;

        public EFBookingRepository(AppDBContext dBContest)
        {
            _DBContest = dBContest;
        }

        public void Create(Booking item)
        {
            _DBContest.Bookings.Add(item);
        }

        public void Delete(Booking item)
        {
            _DBContest.Bookings.Remove(item);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _DBContest.Bookings.AsEnumerable();
        }

        public Booking GetById(int id)
        {
            return _DBContest.Bookings.FirstOrDefault(booking => booking.Id == id);
        }

        public void Update(Booking item)
        {
            _DBContest.Bookings.Update(item);
        }
    }
}
