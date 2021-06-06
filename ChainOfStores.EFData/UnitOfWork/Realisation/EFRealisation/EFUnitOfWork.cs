using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.Repositories.Inerfaces;
using ChainOfStores.EFData.Repositories.Realisation.EFRealisation;
using ChainOfStores.EFData.UnitOfWork.Interfaces;
using ChainOfStores.EFData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.UnitOfWork.Realisation.EFRealisation
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; set; }
        public IProductTypeRepository ProductTypeRepository { get; set; }
        public IStoreRepository StoreRepository { get; set; }
        public IBookingRepository BookingRepository { get; set; }
        public IBookingDurationRepository BookingDurationRepository { get; set; }

        private EFAppDBContext _dBContest;

        public EFUnitOfWork(IProductRepository productRepository, IProductTypeRepository productTypeRepository, IStoreRepository storeRepository, IBookingRepository bookingRepository, IBookingDurationRepository bookingDurationRepository, EFAppDBContext dBContest)
        {
            ProductRepository = productRepository;
            ProductTypeRepository = productTypeRepository;
            StoreRepository = storeRepository;
            BookingRepository = bookingRepository;
            BookingDurationRepository = bookingDurationRepository;
            _dBContest = dBContest;
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
