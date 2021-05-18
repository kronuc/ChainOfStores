using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Interfaces
{
    public interface IProductTypeService
    {
        public IEnumerable<ProductTypeView> GetAllProductTypes();
        public ProductTypeView GetProductTypeByID(int productTypeId);

        public IEnumerable<ProductTypeView> FindByName(string name);
    }
}
