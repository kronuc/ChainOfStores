using ChainOfStores.EFCData.Entities;
using ChainOfStores.EFCData.Repositories.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFCData.Repositories.Realisation.EFRealisation
{
    class EFProductRepository : IRepository<Product>
    {
        private AppDBContext _DBContext;

        public EFProductRepository(AppDBContext dBContext)
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
            _DBContext.Products.Update(item);
        }
    }
}
