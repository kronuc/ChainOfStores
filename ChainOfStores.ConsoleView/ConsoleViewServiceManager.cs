using ChainOfStores.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    public class ConsoleViewServiceManager
    {
        public IBookingService BookingService { get; private set; }
        public IStoreService StoreService { get; private set; }
        public IProductService ProductService { get; private set; }
        public IProductTypeService ProductTypeService { get; private set; }

        public ConsoleViewServiceManager(IBookingService bookingService, IStoreService storeService, IProductService productService, IProductTypeService productTypeService)
        {
            BookingService = bookingService;
            StoreService = storeService;
            ProductService = productService;
            ProductTypeService = productTypeService;
        }
    }
}
