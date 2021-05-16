using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    interface IStoreService
    {
        public IEnumerable<StoreView> GetAllStores();
        public StoreView GetStoreByID(Guid storeID);
        public void CreateStore(StoreView newStore);
        public void DeleteStore(Guid storeID);
        public void EditStore(StoreView editedStore);
        public IEnumerable<StoreView> GetAllStoresThatConteainThisTypeOfProduct(Guid typeOfProductID);
    }
}
