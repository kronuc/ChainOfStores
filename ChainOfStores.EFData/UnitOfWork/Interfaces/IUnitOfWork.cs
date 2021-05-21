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
        IRepository<Product> ProductRepository { get; set; }
        IRepository<ProductType> ProductTypeRepository { get; set; }
        IRepository<Store> StoreRepository { get; set; }
        IRepository<Booking> BookingRepository { get; set; }
        void Save();
        void Dispose();
    }
}
