﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.ViewEntities
{
    class ProductTypeView
    {
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
