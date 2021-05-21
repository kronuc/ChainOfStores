using ChainOfStores.EFCData.Entities;
using ChainOfStores.EFCData.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFCData.Repositories.Realisation.EFRealisation
{
    class EFStoreRepository : IRepository<Store>
    {
        private AppDBContext _DBContext;

        public EFStoreRepository(AppDBContext dBContext)
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
            _DBContext.Stores.Update(item); 
        }
    }
}
