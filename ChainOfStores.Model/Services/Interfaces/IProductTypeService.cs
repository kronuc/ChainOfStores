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
        public ProductTypeView GetTypeOfThisProduct(int productID);
        public ProductTypeView GetProductTypeByID(int productTypeId);
        public IEnumerable<ProductTypeView> GetAllProductTypesInStore(int storeID);
        public IEnumerable<ProductTypeView> GetProductTypeByName(string name);
    }
}
