using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; set; }
        IProductTypeRepository ProductTypeRepository { get; set; }
        IStoreRepository StoreRepository { get; set; }
        IBookingRepository BookingRepository { get; set; }
        void Save();
        void Dispose();
    }
}
