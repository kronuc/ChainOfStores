using ChainOfStores.EFData.Entities;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Mappers
{
    class StoreMapper
    {
        public static Store ToDataEntity(StoreView viewEntity)
        {
            Store dataEntity = new Store();
            dataEntity.Id = viewEntity.Id;
            dataEntity.ContactNumber = viewEntity.ContactNumber;
            dataEntity.Name = viewEntity.Name;
            dataEntity.City = viewEntity.City;
            dataEntity.Country = viewEntity.Country;
            dataEntity.Address = dataEntity.Address;
            return dataEntity;
        }

        public static StoreView ToViewEntity(Store dataEntity)
        {
            StoreView viewEntity = new StoreView();
            viewEntity.Id = dataEntity.Id;
            viewEntity.Name = dataEntity.Name;
            viewEntity.City = dataEntity.City;
            viewEntity.Country = dataEntity.Country;
            viewEntity.ContactNumber = dataEntity.ContactNumber;
            viewEntity.Address = dataEntity.Address;
            return viewEntity;
        }
    }
}
