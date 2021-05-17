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
        public static List<ProductView> Products;

        public ProductServiceWithoutDB()
        {
        }
        static ProductServiceWithoutDB()
        {
            Products = new List<ProductView>();
            InitialiseData();
        }

        public IEnumerable<ProductView> GetAllProducts()
        {
            return Products.ToList();
        }

        public IEnumerable<ProductView> GetAllProductsInStore(int storeID)
        {
            return Products.Where(product => product.StoreID == storeID);
        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductType(int productTypeID)
        {
            return Products.Where(product => product.ProductTypeId == productTypeID);
        }

        public ProductView GetProductByID(int productID)
        {
            return Products.Where(product => product.Id == productID).First();
        }

        public bool DoesProductAvailable(int productId)
        {
            return !BookingServiceWithoutDB.Bookings.Where(booking => booking.ProductID == productId).Any();
        }

        public IEnumerable<ProductView> GetAllProductsWithSelectedProductTypeAndStore(int productTypeID, int storeId)
        {
            return Products.Where(product => product.StoreID == storeId).Where(product => product.ProductTypeId == productTypeID);
        }

        private static void InitialiseData()
        {
            Products.Add(new ProductView() { Id = 1, ProductTypeId = 1, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 2, ProductTypeId = 1, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 3, ProductTypeId = 1, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 4, ProductTypeId = 2, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 5, ProductTypeId = 2, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 6, ProductTypeId = 2, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 7, ProductTypeId = 3, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 8, ProductTypeId = 3, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 9, ProductTypeId = 3, StoreID = 1, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 10, ProductTypeId = 2, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 11, ProductTypeId = 2, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 12, ProductTypeId = 2, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 13, ProductTypeId = 3, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 14, ProductTypeId = 3, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 15, ProductTypeId = 3, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 16, ProductTypeId = 4, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 17, ProductTypeId = 4, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 18, ProductTypeId = 4, StoreID = 2, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 19, ProductTypeId = 3, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 20, ProductTypeId = 3, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 21, ProductTypeId = 3, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 22, ProductTypeId = 4, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 23, ProductTypeId = 4, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 24, ProductTypeId = 4, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 25, ProductTypeId = 5, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 26, ProductTypeId = 5, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 27, ProductTypeId = 5, StoreID = 3, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 28, ProductTypeId = 1, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 29, ProductTypeId = 1, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 30, ProductTypeId = 1, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 31, ProductTypeId = 3, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 32, ProductTypeId = 3, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 33, ProductTypeId = 3, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 34, ProductTypeId = 5, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 35, ProductTypeId = 5, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 36, ProductTypeId = 5, StoreID = 4, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 37, ProductTypeId = 2, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 38, ProductTypeId = 2, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 39, ProductTypeId = 2, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 40, ProductTypeId = 4, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 41, ProductTypeId = 4, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 42, ProductTypeId = 4, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 43, ProductTypeId = 1, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 44, ProductTypeId = 1, StoreID = 5, DateOfProducing = new DateTime()});
            Products.Add(new ProductView() { Id = 45, ProductTypeId = 1, StoreID = 5, DateOfProducing = new DateTime()});
        }

    }
}
