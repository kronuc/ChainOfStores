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
    class EFProductRepository : IRepository<Product>
    {
        private EFAppDBContext _DBContext;

        public EFProductRepository(EFAppDBContext dBContext)
        {
            _DBContext = dBContext;
        }

        public void Create(Product item)
        {
            _DBContext.Products.Add(item);
        }

        public void Delete(Product item)
        {
            _DBContext.Products.Remove(item);
        }

        public IEnumerable<Product> GetAll()
        {
            return _DBContext.Products.AsEnumerable();
        }

        public Product GetById(int id)
        {
            return _DBContext.Products.First(product => product.Id == id);
        }

        public void Update(Product item)
        {
            _DBContext.Entry(item).State = EntityState.Modified;
        }
    }
}
