using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
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
                ShowListOfbookings();
            }
            else if (command == "2")
            {
                MakeBooking();
            }
            else if (command == "3")
            {
                DeleteBooking();
            }
            else if (command == "4")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - show list of booking");
            Console.WriteLine("2 - make booking");
            Console.WriteLine("3 - delete booking");
            Console.WriteLine("4 - back to main menu");
        }
        private void DeleteBooking()
        {
            Console.Write("\nwrite booking id>> ");
            string bookingIdStr = Console.ReadLine();
            int bookingId;
            if (!int.TryParse(bookingIdStr, out bookingId))
            {
                Console.WriteLine("\nWrong Id");
            }
            else if (_bookingService.GetBookingByID(bookingId) == null)
            {
                Console.WriteLine("booking doesn`t exist");
            }
            else
            {
                _bookingService.DeleteBooking(bookingId);
            }
        }
        
        private void MakeBooking()
        {
            if (!_productService.DoesProductAvailable(_selectedItems.SelectedProduct.Id))
            {
                Console.WriteLine("product doesn`t available, choose another one");
            }
            else
            {
                _bookingService.MakeBooking(_selectedItems.SelectedProduct.Id, DateTime.Now);
            }
        }

        private void ShowListOfbookings()
        {
            Console.WriteLine("id    product id    date of booking");
            foreach(BookingView booking in _bookingService.GetAllBookings())
            {
                Console.WriteLine($"{booking.Id, -5} {booking.ProductID, -13} {booking.DataOfBooking.ToShortDateString()}");
            }
        }
    }
}
