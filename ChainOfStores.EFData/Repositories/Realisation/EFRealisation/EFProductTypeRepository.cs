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
    class EFProductTypeRepository : IProductTypeRepository
    {
        private EFAppDBContext _DBContext;

        public EFProductTypeRepository(EFAppDBContext dBContext)
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
            _DBContext.Entry(item).State = EntityState.Modified;
        }
    }
}
