using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.DataTransferObjects
{
    class ProductDTO
    {
        public Guid Id { get; set; }
        public float Price { get; set; }
        public Guid ProductTypeId { get; set; }
        public Guid StoreID { get; set; }
        public DateTime DateOfProducing { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
