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
        public IEnumerable<ProductView> GetAllProductsWithThisProductType(int productTypeID);
        public IEnumerable<ProductView> GetAllProductsInStore(int storeID);
    }
}
