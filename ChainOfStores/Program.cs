using ChainOfStores.ConsoleView;
using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.Services.Realization.WhitoutDB;
using System;

namespace ChainOfStores
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookingService bookingService = new BookingServiceWithoutDB();
            IProductTypeService productTypeService = new ProductTypeServiceWithoutDB();
            IProductService productService = new ProductServiceWithoutDB();
            IStoreService storeService = new StoreServiceWithoutDB();
            MainMenuConsolePage mainMenuPage = new MainMenuConsolePage(bookingService, storeService, productService, productTypeService);
            mainMenuPage.Run();
        }
    }
}