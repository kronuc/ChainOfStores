using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Entities
{
    public class Product : BaseEntity<int>
    {
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int Price { get; set; }
        public DateTime DateOfProducing { get; set; }
    }
}
