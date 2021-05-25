using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public class ProductServiceWithoutDB : IProductService
    {
        private List<ProductView> _products;

        public ProductServiceWithoutDB()
        {
            _products = new List<ProductView>();
            //InitialiseData();
        }

        public IEnumerable<ProductView> GetAllProducts()
        {
            return _products.ToList();
        }

        public IEnumerable<ProductView> GetAllProductsInStore(int storeID)
        {
            return _products.Where(product => product.StoreId == storeID);
        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductType(int productTypeID)
        {
            return _products.Where(product => product.ProductTypeId == productTypeID);
        }

        public ProductView GetProductByID(int productID)
        {
            return _products.Where(product => product.Id == productID).FirstOrDefault();
        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductTypeAndStore(int productTypeID, int storeId)
        {
            return _products.Where(product => product.StoreId == storeId).Where(product => product.ProductTypeId == productTypeID);
        }

        private void InitialiseData()
        {
            _products.Add(new ProductView() { Id = 1, Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 2, Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 3, Price = 15, ProductTypeId = 1, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 4, Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 5, Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 6, Price = 15, ProductTypeId = 2, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 7, Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 8, Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 9, Price = 15, ProductTypeId = 3, StoreId = 1, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 10, Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 11, Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 12, Price = 15, ProductTypeId = 2, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 13, Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 14, Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 15, Price = 15, ProductTypeId = 3, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 16, Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 17, Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 18, Price = 15, ProductTypeId = 4, StoreId = 2, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 19, Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 20, Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 21, Price = 15, ProductTypeId = 3, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 22, Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 23, Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 24, Price = 15, ProductTypeId = 4, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 25, Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 26, Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 27, Price = 15, ProductTypeId = 5, StoreId = 3, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 28, Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 29, Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 30, Price = 15, ProductTypeId = 1, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 31, Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 32, Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 33, Price = 15, ProductTypeId = 3, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 34, Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 35, Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 36, Price = 15, ProductTypeId = 5, StoreId = 4, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 37, Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 38, Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 39, Price = 15, ProductTypeId = 2, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 40, Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 41, Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 42, Price = 15, ProductTypeId = 4, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 43, Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 44, Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
            _products.Add(new ProductView() { Id = 45, Price = 15, ProductTypeId = 1, StoreId = 5, DateOfProducing = new DateTime()});
        }

    }
}
