using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    interface IProductService
    {
        public IEnumerable<ProductView> GetAllProducts();
        public ProductView GetProductByID(Guid productID);
        public IEnumerable<ProductView> GetAllProductsWithThisProductType(Guid productTypeID);
        public void CreateProduct(ProductView newProduct);
        public void EditProductGuid(ProductView editedProduct);
        public void DeleteProduct(Guid productID);
        public IEnumerable<ProductView> GetAllProductsInStore(Guid storeID);
    }
}
