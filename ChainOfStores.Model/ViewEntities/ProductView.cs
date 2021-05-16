using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    class ProductView
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int ProductTypeId { get; set; }
        public int StoreID { get; set; }
        public DateTime DateOfProducing { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
