using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Data.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public int ExpirationDate { get; set; }
        public string Name { get; set; }
        public float PriceRecomendation { get; set; }
    }
}
