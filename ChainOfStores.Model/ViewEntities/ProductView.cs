using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    public class ProductView
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int StoreId { get; set; }
        public int Price { get; set; }
        public DateTime DateOfProducing { get; set; }
    }
}
