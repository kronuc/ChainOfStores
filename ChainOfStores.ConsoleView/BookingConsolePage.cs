using ChainOfStores.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class BookingConsolePage
    {
        private IBookingService _bookingService;
        private IStoreService _storeService;
        private IProductService _productService;
        private IProductTypeService _productTypeService;
        private SelectedItems _selectedItems;

        public BookingConsolePage(IBookingService bookingService, IStoreService storeService, IProductService productService, IProductTypeService productTypeService, SelectedItems selectedItems)
        {
            _bookingService = bookingService;
            _storeService = storeService;
            _productService = productService;
            _productTypeService = productTypeService;
            _selectedItems = selectedItems;
        }


        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            { }
        }

        private void WriteListOfCommand()
        {
        }
    }
}
