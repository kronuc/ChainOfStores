using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    class ProductTypeServiceWithoutDB : IProductTypeService
    {
        static List<ProductTypeView> productTypes;
        
        public IEnumerable<ProductTypeView> GetAllProductTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductTypeView> GetAllProductTypesInStore(int storeID)
        {
            throw new NotImplementedException();
        }

        public ProductTypeView GetProductTypeByID(int productTypeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductTypeView> GetProductTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public ProductTypeView GetTypeOfThisProduct(int productID)
        {
            throw new NotImplementedException();
        }
        private void InitialiseData()
        { }
    }
}
