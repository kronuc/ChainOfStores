using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    class ProductTypeConsolePage
    {
        private IProductTypeService _productTypeService;
        private SelectedItems _selectedItems;

        public ProductTypeConsolePage(IProductTypeService productTypeService, SelectedItems selectedItems)
        {
            _productTypeService = productTypeService;
            _selectedItems = selectedItems;
        }


        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nchoosing product type\n");
                if (_selectedItems.SelectedProductType != null)
                    Console.WriteLine($"\nselected product type id {_selectedItems.SelectedProductType.Id, -4}");
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
            Console.WriteLine("1 - show all product types");
            Console.WriteLine("2 - show product types in selected store");
            Console.WriteLine("3 - choose product type");
            Console.WriteLine("4 - back to main menu");
        }

        private bool ProccessCommand(string command)
        {
            bool backToMenu = false;
            if (command == "1")
            {
                ShowAllProductTypes();
            }
            else if (command == "2")
            {
                ShowAllProductTypesInStore();
            }
            else if (command == "3")
            {
                ChooseProductType();
            }
            else if (command == "4")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void ChooseProductType()
        {
            Console.Write("\nwrite product type id>> ");
            string productTypeIdStr = Console.ReadLine();
            int productTypeId;
            if (int.TryParse(productTypeIdStr, out productTypeId))
            {
                _selectedItems.SelectedProductType = _productTypeService.GetProductTypeByID(productTypeId);
            }
            else
            {
                Console.WriteLine("\nWrong Id");
            }

        }

        private void ShowAllProductTypesInStore()
        {
            if (_selectedItems.SelectedStore != null)
            {
                List<ProductTypeView> productTypesInStore = _productTypeService.GetAllProductTypesInStore(_selectedItems.SelectedStore.Id).ToList();
                WriteListOfProductTypes(productTypesInStore);
            }
            else 
            {
                Console.WriteLine("You didn`t choose store");
            }
        }

        private void ShowAllProductTypes()
        {
            List<ProductTypeView> productTypes = _productTypeService.GetAllProductTypes().ToList();
            WriteListOfProductTypes(productTypes);
        }

        private void WriteListOfProductTypes(List<ProductTypeView> productTypes)
        {
            Console.WriteLine("     product type name   price");
            foreach (ProductTypeView productType in productTypes)
            {
                Console.WriteLine($"{productType.Id,5}{productType.Name,-20}{productType.Price.ToString()}");
            }
        }
    }
}
