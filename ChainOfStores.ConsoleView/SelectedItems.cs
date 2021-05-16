using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class SelectedItems
    {
        public StoreView SelectedStore { get; set; }
        public ProductView SelectedProduct { get; set; }
        public ProductTypeView SelectedProductType { get; set; }
    }
}
