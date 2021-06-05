using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.UnitOfWork.Interfaces;
using ChainOfStores.EFData.UnitOfWork.Realisation.EFRealisation;
using ChainOfStores.Model.Mappers;
using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WithDataLayer
{
    public class StoreServiceDL : IStoreService
    {
        private IUnitOfWork _unitOfWork;
        public StoreServiceDL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //InitialiseData();
        }

        public IEnumerable<StoreView> GetAllStores()
        {
            return _unitOfWork.StoreRepository.GetAll().Select(obj => StoreMapper.ToViewEntity(obj));
        }

        public StoreView GetStoreByID(int storeID)
        {
            return StoreMapper.ToViewEntity(_unitOfWork.StoreRepository.GetById(storeID));
        }

        private void InitialiseData()
        {
            _unitOfWork.StoreRepository.Create(new Store() { Address = "address 1", City = "city 1", ContactNumber = 700000001, Country = "country 1", Name = "name 1" });
            _unitOfWork.StoreRepository.Create(new Store() { Address = "address 2", City = "city 2", ContactNumber = 700000002, Country = "country 2", Name = "name 2" });
            _unitOfWork.StoreRepository.Create(new Store() { Address = "address 3", City = "city 3", ContactNumber = 700000003, Country = "country 3", Name = "name 3" });
            _unitOfWork.StoreRepository.Create(new Store() { Address = "address 4", City = "city 4", ContactNumber = 700000004, Country = "country 4", Name = "name 4" });
            _unitOfWork.StoreRepository.Create(new Store() { Address = "address 5", City = "city 5", ContactNumber = 700000005, Country = "country 5", Name = "name 5" });
            _unitOfWork.Save();
        }
    }
}
