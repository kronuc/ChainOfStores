using ChainOfStores.Data.Entities;
using ChainOfStores.Data.Repositories.Inerfaces;
using ChainOfStores.Data.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.UnitOfWork.Realisation.EFRealisation
{
    class EFUnitOfWork : IUnitOfWork
    {
        public IRepository<Product> ProductRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<ProductType> ProductTypeRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Store> StoreRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Booking> BookingRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private AppDBContext _dBContest;

        public EFUnitOfWork()
        {
            _dBContest = new AppDBContext();
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
