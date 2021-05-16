using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    interface IProductTypeService
    {
        public IEnumerable<ProductTypeView> GetAllProductTypes();
        public ProductTypeView GetTypeOfThisProduct(Guid productID);
        public ProductTypeView GetProductTypeByID(Guid productTypeId);
        public IEnumerable<ProductTypeView> GetAllProductTypesInStore(Guid storeID);
        public void CreateProductType(ProductTypeView productType);
        public void EditProductType(ProductTypeView editedProductType);
        public void DeleteProductType(Guid productTypeID);
        public IEnumerable<ProductTypeView> GetProductTypeByName(string name);
    }
}
