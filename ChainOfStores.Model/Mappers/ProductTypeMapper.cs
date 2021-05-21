using ChainOfStores.EFData.Entities;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Mappers
{
    public static class ProductTypeMapper
    {
        public static ProductType ToDataEntity(ProductTypeView viewEntity)
        {
            ProductType dataEntity = new ProductType();
            dataEntity.Id = viewEntity.Id;
            dataEntity.Name = viewEntity.Name;
            dataEntity.PriceRecomendation = viewEntity.PriceRecomendation;
            dataEntity.ExpirationDate = viewEntity.ExpirationDate;
            return dataEntity;
        }

        public static ProductTypeView ToViewEntity(ProductType dataEntity)
        {
            ProductTypeView viewEntity = new ProductTypeView();
            viewEntity.Id = dataEntity.Id;
            viewEntity.Name = dataEntity.Name;
            viewEntity.ExpirationDate = dataEntity.ExpirationDate;
            viewEntity.PriceRecomendation = dataEntity.PriceRecomendation;
            return viewEntity;
        }
    }
}
