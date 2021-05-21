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
    class EFStoreRepository : IStoreRepository
    {
        private EFAppDBContext _DBContext;

        public EFStoreRepository(EFAppDBContext dBContext)
        {
            _DBContext = dBContext;
        }

        public void Create(Store item)
        {
            _DBContext.Stores.Add(item);
        }

        public void Delete(Store item)
        {
            _DBContext.Stores.Remove(item);
        }

        public IEnumerable<Store> GetAll()
        {
            return _DBContext.Stores.AsEnumerable();
        }

        public Store GetById(int id)
        {
            return _DBContext.Stores.First(store => store.Id == id);
        }

        public void Update(Store item)
        {
            _DBContext.Entry(item).State = EntityState.Modified; 
        }
    }
}
