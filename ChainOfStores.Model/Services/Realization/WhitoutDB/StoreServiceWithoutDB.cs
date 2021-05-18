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
        private List<StoreView> _stores;
        
        public StoreServiceWithoutDB()
        {
            _stores = new List<StoreView>();
            InitialiseData();

        }

        public IEnumerable<StoreView> GetAllStores()
        {
            return _stores.ToList();
        }

        public StoreView GetStoreByID(int storeID)
        {
            return _stores.Where(store => store.Id == storeID).First();
        }

        private void InitialiseData()
        {
            _stores.Add(new StoreView() { Id = 1, Address = "address 1", City = "city 1", ContactNumber = 700000001, Country = "country 1", Name = "name 1" });
            _stores.Add(new StoreView() { Id = 2, Address = "address 2", City = "city 2", ContactNumber = 700000002, Country = "country 2", Name = "name 2" });
            _stores.Add(new StoreView() { Id = 3, Address = "address 3", City = "city 3", ContactNumber = 700000003, Country = "country 3", Name = "name 3" });
            _stores.Add(new StoreView() { Id = 4, Address = "address 4", City = "city 4", ContactNumber = 700000004, Country = "country 4", Name = "name 4" });
            _stores.Add(new StoreView() { Id = 5, Address = "address 5", City = "city 5", ContactNumber = 700000005, Country = "country 5", Name = "name 5" });
        }
    }
}
