using ChainOfStores.Data.Entities;
using ChainOfStores.Data.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.Repositories.Realisation.EFRealisation
{
    class EFStoreRepository : IRepository<Store>
    {
        private AppDBContext _DBContext;

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
