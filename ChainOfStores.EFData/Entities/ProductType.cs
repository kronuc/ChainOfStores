using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData.Entities
{
    public class ProductType : BaseEntity<int>
    {
        public int ExpirationDate { get; set; }
        public string Name { get; set; }
        public float PriceRecomendation { get; set; }
        public List<Product> Products { get; set; }
    }
}
