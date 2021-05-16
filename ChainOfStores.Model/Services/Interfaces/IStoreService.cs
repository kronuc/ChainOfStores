using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    public interface IStoreService
    {
        public IEnumerable<StoreView> GetAllStores();
        public StoreView GetStoreByID(int storeID);
        public IEnumerable<StoreView> GetAllStoresThatConteainThisTypeOfProduct(int typeOfProductID);
    }
}
