﻿using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class StoreConsolePage
    {
        private IBookingService _bookingService;
        private IStoreService _storeService;
        private IProductService _productService;
        private IProductTypeService _productTypeService;
        private SelectedItems _selectedItems;
        public StoreConsolePage(IBookingService bookingService, IStoreService storeService, IProductService productService, IProductTypeService productTypeService, SelectedItems selectedItems)
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
                Console.WriteLine("\nchoosing store\n");
                if (_selectedItems.SelectedProductType != null)
                    Console.WriteLine($"\nselected product type id {_selectedItems.SelectedProductType.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"selected store id {_selectedItems.SelectedStore.Id,-4}\n");
                WriteListOfCommand();
                Console.Write("\n>>");
                string command = Console.ReadLine();
                backToMenu = ProccessCommand(command);
            }
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - show all stores");
            Console.WriteLine("2 - show stores with selected type of product");
            Console.WriteLine("3 - choose store");
            Console.WriteLine("4 - back to main menu");
        }

        private bool ProccessCommand(string command)
        {
            bool backToMenu = false;
            if (command == "1")
            {
                ShowAllStores();
            }
            else if (command == "2")
            {
                ShowStoresWithSelectedTypeOfProduct();
            }
            else if (command == "3")
            {
                ChooseStore();
            }
            else if (command == "4")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void ShowStoresWithSelectedTypeOfProduct()
        {
            if (_selectedItems.SelectedProductType != null)
            {
                List<StoreView> stores =  _storeService.GetAllStoresThatConteainThisTypeOfProduct(_selectedItems.SelectedProductType.Id).ToList();
                WriteListOfStores(stores);
            }
        }

        private void ChooseStore()
        {
            Console.Write("\nwrite store id>> ");
            string storeIdStr = Console.ReadLine();
            int storeId;
            if (int.TryParse(storeIdStr, out storeId))
            {
                _selectedItems.SelectedStore = _storeService.GetStoreByID(storeId);
            }
            else
            {
                Console.WriteLine("\nWrong Id");
            }

        }

        private void ShowAllStores()
        {
            List<StoreView> stores = _storeService.GetAllStores().ToList();
            WriteListOfStores(stores);
        }
        private void WriteListOfStores(List<StoreView> stores)
        {
            Console.WriteLine("     name            city        country        address                      ");
            foreach (StoreView store in stores)
            {
                Console.WriteLine($"{store.Id, -4} {store.Name, -15} {store.City, -11} {store.Country, -14} {store.Address}");
            }
        }
    }
}
