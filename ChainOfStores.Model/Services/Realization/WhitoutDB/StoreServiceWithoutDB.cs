using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    class StoreServiceWithoutDB : IStoreService
    {
        static List<StoreView> Stores;
        static List<ProductTypeInStoreView> productTypesInStores;

        public StoreServiceWithoutDB()
        {
            InitialiseData();
        }

       
        public IEnumerable<StoreView> GetAllStores()
        {
            return Stores.ToList();
        }

        public IEnumerable<StoreView> GetAllStoresThatConteainThisTypeOfProduct(int typeOfProductID)
        {
            List<int> StoresId = productTypesInStores
                .Where(productTypesInStore => productTypesInStore.ProductTypeId == typeOfProductID)
                .Select(productTypeInStore => productTypeInStore.Id)
                .ToList();
            IEnumerable<StoreView> stores = Stores
                .Where(store => StoresId.Contains(store.Id))
                .ToList();
            return stores;
        }

        public StoreView GetStoreByID(int storeID)
        {
            return Stores.Where(store => store.Id == storeID).First();
        }

        private void InitialiseData()
        {
            
        }
    }
}
