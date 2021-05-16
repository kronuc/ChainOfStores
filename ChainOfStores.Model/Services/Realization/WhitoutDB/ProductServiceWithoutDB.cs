using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    class ProductServiceWithoutDB : IProductService
    {
        public IEnumerable<ProductView> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductView> GetAllProductsInStore(int storeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductView> GetAllProductsWithThisProductType(int productTypeID)
        {
            throw new NotImplementedException();
        }

        public ProductView GetProductByID(int productID)
        {
            throw new NotImplementedException();
        }
        private void InitialiseData()
        { }
    }
}
