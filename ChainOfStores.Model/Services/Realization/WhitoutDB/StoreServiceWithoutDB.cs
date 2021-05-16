using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public class StoreServiceWithoutDB : IStoreService
    {
        public static List<StoreView> Stores;
        public static List<ProductTypeInStoreView> ProductTypesInStores;

        public StoreServiceWithoutDB()
        {
        }

        static StoreServiceWithoutDB()
        {
            Stores = new List<StoreView>();
            ProductTypesInStores = new List<ProductTypeInStoreView>();
            InitialiseData();
        }
        
        public IEnumerable<StoreView> GetAllStores()
        {
            return Stores.ToList();
        }

        public IEnumerable<StoreView> GetAllStoresThatConteainThisTypeOfProduct(int typeOfProductID)
        {
            List<int> StoresId = ProductTypesInStores
                .Where(productTypesInStore => productTypesInStore.ProductTypeId == typeOfProductID)
                .Select(productTypeInStore => productTypeInStore.Id)
                .ToList();
            return Stores.Where(store => StoresId.Contains(store.Id));
        }

        public StoreView GetStoreByID(int storeID)
        {
            return Stores.Where(store => store.Id == storeID).First();
        }

        private static void InitialiseData()
        {
            Stores.Add(new StoreView() { Id = 1, Address = "address 1", City = "city 1", ContactNumber = 700000001, Country = "country 1", Name = "name 1" });
            Stores.Add(new StoreView() { Id = 2, Address = "address 2", City = "city 2", ContactNumber = 700000002, Country = "country 2", Name = "name 2" });
            Stores.Add(new StoreView() { Id = 3, Address = "address 3", City = "city 3", ContactNumber = 700000003, Country = "country 3", Name = "name 3" });
            Stores.Add(new StoreView() { Id = 4, Address = "address 4", City = "city 4", ContactNumber = 700000004, Country = "country 4", Name = "name 4" });
            Stores.Add(new StoreView() { Id = 5, Address = "address 5", City = "city 5", ContactNumber = 700000005, Country = "country 5", Name = "name 5" });

            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 1, ProductTypeId = 1, StoreId = 1 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 2, ProductTypeId = 2, StoreId = 1 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 3, ProductTypeId = 3, StoreId = 1 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 4, ProductTypeId = 2, StoreId = 2 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 5, ProductTypeId = 3, StoreId = 2 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 6, ProductTypeId = 4, StoreId = 2 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 7, ProductTypeId = 3, StoreId = 3 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 8, ProductTypeId = 4, StoreId = 3 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 9, ProductTypeId = 5, StoreId = 3 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 10, ProductTypeId = 1, StoreId = 4 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 11, ProductTypeId = 3, StoreId = 4 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 12, ProductTypeId = 5, StoreId = 4 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 13, ProductTypeId = 2, StoreId = 5 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 14, ProductTypeId = 4, StoreId = 5 });
            ProductTypesInStores.Add(new ProductTypeInStoreView() { Id = 15, ProductTypeId = 1, StoreId = 5 });
        }
    }
}
