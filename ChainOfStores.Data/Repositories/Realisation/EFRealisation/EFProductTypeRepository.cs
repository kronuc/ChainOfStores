using ChainOfStores.Data.Entities;
using ChainOfStores.Data.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.Repositories.Realisation.EFRealisation
{
    class EFProductTypeRepository : IRepository<ProductType>
    {
        private AppDBContext _DBContext;

        public EFProductTypeRepository(AppDBContext dBContext)
        {
            _DBContext = dBContext;
        }

        public void Create(ProductType item)
        {
            _DBContext.ProductTypes.Add(item);
        }

        public void Delete(ProductType item)
        {
            _DBContext.ProductTypes.Remove(item);
        }

        public IEnumerable<ProductType> GetAll()
        {
            return _DBContext.ProductTypes.AsEnumerable();
        }

        public ProductType GetById(int id)
        {
            return _DBContext.ProductTypes.First(type => type.Id == id);
        }

        public void Update(ProductType item)
        {
            _DBContext.ProductTypes.Update(item);
        }
    }
}
