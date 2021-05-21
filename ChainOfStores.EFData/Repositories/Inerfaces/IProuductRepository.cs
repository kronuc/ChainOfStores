using ChainOfStores.EFData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Repositories.Inerfaces
{
    public interface IProuductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProudctsByStore(int storeId);

        IEnumerable<Product> GetProudctsByType(int typeId);
        IEnumerable<Product> GetProudctsByStoreAndType(int typeId, int storeId);

    }
}
