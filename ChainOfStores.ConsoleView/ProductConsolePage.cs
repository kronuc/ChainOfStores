using ChainOfStores.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class ProductConsolePage
    {
        private IBookingService _bookingService;
        private IStoreService _storeService;
        private IProductService _productService;
        private IProductTypeService _productTypeService;
        private SelectedItems _selectedItems;
        public ProductConsolePage(IBookingService bookingService, IStoreService storeService, IProductService productService, IProductTypeService productTypeService, SelectedItems selectedItems)
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
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nchoosing product \n");
                if (_selectedItems.SelectedProductType != null)
                    Console.WriteLine($"\nselected product type id {_selectedItems.SelectedProductType.Id,-4}");
                if (_selectedItems.SelectedProduct != null)
                    Console.WriteLine($"\nselected product type id {_selectedItems.SelectedProduct.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"selected store id {_selectedItems.SelectedStore.Id,-4}\n");
                WriteListOfCommand();
                Console.Write("\n>>");
                string command = Console.ReadLine();
                backToMenu = ProccessCommand(command);
            }
        }
        private bool ProccessCommand(string command)
        {
            bool backToMenu = false;
            if (command == "1")
            {
            }
            else if (command == "2")
            {
            }
            else if (command == "3")
            {
            }
            else if (command == "5")
            {
                backToMenu = true;
            }
            return backToMenu;
        }
        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - show all products");
            Console.WriteLine("2 - show products with selected type");
            Console.WriteLine("3 - show products in selected store");
            Console.WriteLine("4 - show products with selected type in selected shop");
            Console.WriteLine("5 - choose product");
            Console.WriteLine("6 - back to main menu");
        }
    }
}
