using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.Repositories.Inerfaces;
using ChainOfStores.EFData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Repositories.Realisation.EFRealisation
{
    class EFProductRepository : EFGenericRepository<Product>, IProuductRepository
    {
        
        public EFProductRepository(EFAppDBContext dBContext) : base(dBContext)
        {
        }

        public IEnumerable<Product> GetProudctsByStore(int storeId)
        {
            return _entities.Where(product => product.StoreId == storeId);
        }

        public IEnumerable<Product> GetProudctsByStoreAndType(int typeId, int storeId)
        {
            return _entities.Where(product => product.ProductTypeId == typeId && product.StoreId == storeId);
        }

        public IEnumerable<Product> GetProudctsByType(int typeId)
        {
            return _entities.Where(product => product.ProductTypeId == typeId);
        }

    }
}
