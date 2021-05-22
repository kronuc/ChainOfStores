using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class ProductConsolePage
    {
        private IProductService _productService;
        private SelectedItems _selectedItems;
        private IBookingService _bookingService;
        public ProductConsolePage(IProductService productService, IBookingService bookingService SelectedItems selectedItems)
        {
            _productService = productService;
            _selectedItems = selectedItems;
            _bookingService = bookingService;
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
                ShowAllProducts();
            }
            else if (command == "2")
            {
                ShowProductsWithSelectedType();
            }
            else if (command == "3")
            {
                ShowProductsInSelectedStore();
            }
            else if (command == "4")
            {
                ShowProductsWithSelectedTypeInSelectedStore();
            }
            else if (command == "5")
            {
                ChooseProduct();
            }
            else if (command == "6")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void ChooseProduct()
        {
            Console.Write("\nwrite product id>> ");
            string productIdStr = Console.ReadLine();
            int productId;
            if (!int.TryParse(productIdStr, out productId))
            {
                Console.WriteLine("\nWrong Id");
            }
            else if (!_bookingService.DoesProductAvailable(productId))
            {
                Console.WriteLine("product doesn`t available");
            }
            else
            {
                _selectedItems.SelectedProduct = _productService.GetProductByID(productId);
            }

        }

        private void ShowAllProducts()
        {
            List<ProductView> products =  _productService.GetAllProducts().ToList();
            WriteListOfProducts(products);
        }

        private void ShowProductsWithSelectedType()
        {
            if (_selectedItems.SelectedProductType == null)
            {
                Console.WriteLine("\n you didn`t choose product type");
            }
            else
            {
                List<ProductView> products = _productService.GetAllProductsWithSelectedProductType(_selectedItems.SelectedProductType.Id).ToList();
                WriteListOfProducts(products);
            }
        }

        private void ShowProductsWithSelectedTypeInSelectedStore()
        {
            if (_selectedItems.SelectedProductType == null)
            {
                Console.WriteLine("\n you didn`t choose product type");
            }
            else if (_selectedItems.SelectedStore == null)
            {
                Console.WriteLine("\n you didn`t choose store");
            }
            else
            {
                List<ProductView> products = _productService
                       .GetAllProductsWithSelectedProductTypeAndStore(_selectedItems.SelectedProductType.Id, _selectedItems.SelectedStore.Id)
                       .ToList();
                WriteListOfProducts(products);
            }
        }

        private void ShowProductsInSelectedStore()
        {
            if (_selectedItems.SelectedStore != null)
            {
                List<ProductView> products = _productService.GetAllProductsInStore(_selectedItems.SelectedStore.Id).ToList();
                WriteListOfProducts(products);
            }
            else
            {
                Console.WriteLine("\n you didn`t choose store");
            }
        }

        private void WriteListOfProducts(List<ProductView> products)
        {
            Console.WriteLine("id       type id    store id   date of producing");
            foreach (ProductView product in products)
            {
                Console.WriteLine($"{product.Id,-8} {product.ProductTypeId,-10} {product.StoreId, -10} {product.DateOfProducing}");
            }
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - show all products");
            Console.WriteLine("2 - show products with selected type");
            Console.WriteLine("3 - show products in selected store");
            Console.WriteLine("4 - show products with selected type in selected store");
            Console.WriteLine("5 - choose product");
            Console.WriteLine("6 - back to main menu");
        }
    }
}
