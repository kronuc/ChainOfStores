using ChainOfStores.EFData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Repositories.Inerfaces
{
    public interface IProductTypeRepository : IRepository<ProductType, int>
    {
    }
}
