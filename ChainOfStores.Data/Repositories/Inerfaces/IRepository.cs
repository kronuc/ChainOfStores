using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.Repositories.Inerfaces
{
    public interface IRepository<T>
    {
        void Create(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Delete(T item);
        void Update(T item);
    }
}
