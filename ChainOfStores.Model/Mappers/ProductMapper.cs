using ChainOfStores.Data.Entities;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Mappers
{
    public static class ProductMapper
    {
        public static Product ToDataEntity(ProductView viewEntity)
        {
            Product dataEntity = new Product();
            dataEntity.Id = viewEntity.Id;
            dataEntity.Price = viewEntity.Price;
            dataEntity.ProductTypeId = viewEntity.Price;
            dataEntity.StoreId = viewEntity.StoreId;
            dataEntity.DateOfProducing = viewEntity.DateOfProducing;
            return dataEntity;
        }

        public static ProductView ToViewEntity(Product dataEntity)
        {
            ProductView viewEntity = new ProductView();
            viewEntity.Id = dataEntity.Id;
            viewEntity.Price = dataEntity.Price;
            viewEntity.ProductTypeId = dataEntity.ProductTypeId;
            viewEntity.StoreId = dataEntity.StoreId;
            viewEntity.DateOfProducing = dataEntity.DateOfProducing;
            return viewEntity;
        }
    }
}
