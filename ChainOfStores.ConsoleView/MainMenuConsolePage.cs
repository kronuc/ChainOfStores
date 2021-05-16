using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    public class MainMenuConsolePage
    {
        private IBookingService _bookingService;
        private IStoreService _storeService;
        private IProductService _productService;
        private IProductTypeService _productTypeService;

        private ProductTypeConsolePage _productTypePage;
        private StoreConsolePage _storePage;
        
        private SelectedItems _selectedItems;

        public MainMenuConsolePage(IBookingService bookingService, IStoreService storeService, IProductService productService, IProductTypeService productTypeService)
        {
            _bookingService = bookingService;
            _storeService = storeService;
            _productService = productService;
            _productTypeService = productTypeService;
            _selectedItems = new SelectedItems();
            _storePage = new StoreConsolePage(bookingService, storeService, productService, productTypeService, _selectedItems);
            _productTypePage = new ProductTypeConsolePage(productTypeService, _selectedItems);

        }

        public void Run()
        {
            bool continueRunning = true;
            while (continueRunning)
            {

                Console.Write("\n------------------------------------------------------------------------------------------\n");
                Console.WriteLine("main menu\n");
                if (_selectedItems.SelectedProductType != null)
                    Console.WriteLine($"\nselected product type id {_selectedItems.SelectedProductType.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"selected store id {_selectedItems.SelectedStore.Id,-4}\n");
                WriteListOfCommand();
                
                Console.Write("\n>>");
                string command = Console.ReadLine();

                continueRunning = ProcessCommand(command);
                
            }
        }

        public void WriteErrorMeesage(string error)
        {
            Console.WriteLine(error);
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - go to choosing product type");
            Console.WriteLine("2 - go to choosing store");
            Console.WriteLine("3 - go to choosing product");
            Console.WriteLine("4 - go to making booking");
            Console.WriteLine("5 - close program");
        }

        private bool ProcessCommand(string command)
        {
            bool continueRunning = true;
            if (command == "1")
            {
                _productTypePage.Run();
            }
            else if (command == "2")
            {
                _storePage.Run();
            }
            else if (command == "3")
            {

            }
            else if (command == "4")
            {

            }
            else if (command == "5")
            {
                continueRunning = false;
            }
            else
            {
                Console.WriteLine("wrong command");
            }
            return continueRunning;
        }
    }
}
