using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<ProductView> GetAllProducts();
        public ProductView GetProductByID(int productID);
        public IEnumerable<ProductView> GetAllProductsWithSelectedProductType(int productTypeID);
        public IEnumerable<ProductView> GetAllProductsInStore(int storeID);
        public IEnumerable<ProductView> GetAllProductsWithSelectedProductTypeAndStore(int productTypeID, int storeId);
        public bool DoesProductAvailable(int productId);
    }
}
