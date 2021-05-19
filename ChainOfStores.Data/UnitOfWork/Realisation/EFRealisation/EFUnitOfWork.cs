using ChainOfStores.Data.Entities;
using ChainOfStores.Data.Repositories.Inerfaces;
using ChainOfStores.Data.Repositories.Realisation.EFRealisation;
using ChainOfStores.Data.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.UnitOfWork.Realisation.EFRealisation
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IRepository<Product> ProductRepository { get; set; }
        public IRepository<ProductType> ProductTypeRepository { get; set; }
        public IRepository<Store> StoreRepository { get; set; }
        public IRepository<Booking> BookingRepository { get; set; }

        private AppDBContext _dBContest;

        public EFUnitOfWork()
        {
            _dBContest = new AppDBContext();
            ProductRepository = new EFProductRepository(_dBContest);
            ProductTypeRepository = new EFProductTypeRepository(_dBContest);
            StoreRepository = new EFStoreRepository(_dBContest);
            BookingRepository = new EFBookingRepository(_dBContest);
            
        }
        ~EFUnitOfWork()
        {
            _dBContest.Dispose();
        }

        public void Dispose()
        {
            _dBContest.Dispose();
        }

        public void Save()
        {
            _dBContest.SaveChanges();
        }
    }
}
