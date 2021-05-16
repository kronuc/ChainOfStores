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
        public ProductView GetProductByID(int productID);
        public IEnumerable<ProductView> GetAllProductsWithThisProductType(int productTypeID);
        //public void CreateProduct(ProductView newProduct);
        //public void EditProductint(ProductView editedProduct);
        //public void DeleteProduct(int productID);
        public IEnumerable<ProductView> GetAllProductsInStore(int storeID);
    }
}
