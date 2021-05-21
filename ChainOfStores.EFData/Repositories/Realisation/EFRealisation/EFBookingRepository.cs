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
    class EFBookingRepository : IRepository<Booking>
    {
        private EFAppDBContext _DBContext;

        public EFBookingRepository(EFAppDBContext dBContest)
        {
            _DBContext = dBContest;
        }

        public void Create(Booking item)
        {
            _DBContext.Bookings.Add(item);
        }

        public void Delete(Booking item)
        {
            _DBContext.Bookings.Remove(item);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _DBContext.Bookings.AsEnumerable();
        }

        public Booking GetById(int id)
        {
            return _DBContext.Bookings.FirstOrDefault(booking => booking.Id == id);
        }

        public void Update(Booking item)
        {
            _DBContext.Entry(item).State = EntityState.Modified;
        }
    }
}
