using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public class ProductTypeServiceWithoutDB : IProductTypeService
    {
        static List<ProductTypeView> ProductTypes;

        public ProductTypeServiceWithoutDB()
        {
        }

        static ProductTypeServiceWithoutDB()
        {
            ProductTypes = new List<ProductTypeView>();
            InitialiseData();
        }

        public IEnumerable<ProductTypeView> GetAllProductTypes()
        {
            return ProductTypes.ToList();
        }

        public IEnumerable<ProductTypeView> GetAllProductTypesInStore(int storeID)
        {
            List<int> typesId = StoreServiceWithoutDB.ProductTypesInStores
                .Where(typeInStore => typeInStore.StoreId == storeID)
                .Select(typeInStore => typeInStore.ProductTypeId)
                .ToList();
            return ProductTypes.Where(type => typesId.Contains(type.Id));
        }

        public ProductTypeView GetProductTypeByID(int productTypeId)
        {
            return ProductTypes.Where(type => type.Id == productTypeId).First();
        }

        public ProductTypeView GetTypeOfThisProduct(int productID)
        {
            ProductView product = ProductServiceWithoutDB.Products.Where(product => product.Id == productID).First();
            return ProductTypes.Where(type => type.Id == product.Id).First();
        }
        private static void InitialiseData()
        {
            ProductTypes.Add(new ProductTypeView() { Id = 1, Name = "product type 1", Price = 15.23f, ExpirationDate = 14 });
            ProductTypes.Add(new ProductTypeView() { Id = 2, Name = "product type 2", Price = 16.0f, ExpirationDate = 140 });
            ProductTypes.Add(new ProductTypeView() { Id = 3, Name = "product type 3", Price = 900.2f, ExpirationDate = 2 });
            ProductTypes.Add(new ProductTypeView() { Id = 4, Name = "product type 4", Price = 120.6f, ExpirationDate = 10 });
            ProductTypes.Add(new ProductTypeView() { Id = 5, Name = "product type 5", Price = 0.23f, ExpirationDate = 1000 });
        }
    }
}
