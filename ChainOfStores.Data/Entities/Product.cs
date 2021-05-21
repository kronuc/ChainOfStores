using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFCData.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int Price { get; set; }
        public DateTime DateOfProducing { get; set; }
    }
}
