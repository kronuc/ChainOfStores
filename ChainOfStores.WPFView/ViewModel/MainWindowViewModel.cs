using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cha
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private IProductTypeService _productTypeService;
        private IStoreService _storeService;
        private IBookingService _bookingService;
        private IProductService _productService;

        private ObservableCollection<StoreView> _stores;
        private ObservableCollection<ProductTypeView> _productTypes;
        private ObservableCollection<ProductView> _products;
        private ObservableCollection<BookingView> _bookings;
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private StoreView _selectedStore;
        public StoreView SelectedStore 
        { 
            get => _selectedStore;
            set
            {
                _selectedStore = value;
                OnPropertyChanged(nameof(SelectedStore));
            }
        }

        private ProductView _selectedProduct;
        public ProductView SelectedProduct 
        { 
            get => _selectedProduct;
            set 
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            } 
        }
       
        private ProductTypeView _selectedProductType;
        public ProductTypeView SelectedProductType 
        {
            get => _selectedProductType; 
            set 
            { 
                _selectedProductType = value; 
                OnPropertyChanged(nameof(SelectedProductType)); 
            } 
        }
        public BookingView SelectedBooking { get; set; }

        public ObservableCollection<StoreView> Stores
        {
            get
            {
                return _stores ??= new ObservableCollection<StoreView>(_storeService.GetAllStores().ToList());
            }
            set
            {
                _stores = value;
                OnPropertyChanged(nameof(Stores));
            }
        }
        public ObservableCollection<ProductTypeView> ProductTypes 
        {
            get 
            {
                return _productTypes ??= new ObservableCollection<ProductTypeView>(_productTypeService.GetAllProductTypes());
            }
            set
            {
                _productTypes = value;
                OnPropertyChanged(nameof(ProductTypes));
            }
        }

        public ObservableCollection<ProductView> Products 
        {
            get
            {
                return _products ??= new ObservableCollection<ProductView>(_productService.GetAllProducts().ToList());
            }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }
        
        public ObservableCollection<BookingView> Bookings 
        { 
            get 
            {
                return _bookings ??= new ObservableCollection<BookingView>(_bookingService.GetAllBookings().ToList());
            }
            set
            {
                _bookings = value;
                OnPropertyChanged(nameof(Bookings));
            }
        }

        private string _messege;
        public string Messege 
        { 
            get => _messege ??= ""; 
            set 
            {
                _messege = value;
                OnPropertyChanged(nameof(Messege));
            } 
        }

        private bool _filterProductsByStore = false;
        private bool _filterProductsByType = false;

        private RelayCommand _selectedItemChanged;
        public RelayCommand SelectedItemChanged
        {
            get => _selectedItemChanged ??= new RelayCommand(obj => 
            {
                ReloadProductList();
            });
        }

        private RelayCommand _filterProductsByStore_checked;
        public RelayCommand FilterProductsByStore_Checked
        {
            get => _filterProductsByStore_checked ??= new RelayCommand(obj =>
            {
                _filterProductsByStore = true;
                ReloadProductList();
            });
        }
        
        private RelayCommand _filterProductsByStore_Unchecked;
        public RelayCommand FilterProductsByStore_Unchecked
        {
            get => _filterProductsByStore_Unchecked ??= 
                new RelayCommand(obj => 
                { 
                    _filterProductsByStore = false; 
                    ReloadProductList(); 
                });
        }

        private RelayCommand _filterProductsByType_checked;
        public RelayCommand FilterProductsByType_Checked
        {
            get => _filterProductsByType_checked ??= new RelayCommand(obj =>
            {
                _filterProductsByType = true;
                ReloadProductList();
            });
        }
        
        private RelayCommand _filterProductsByType_Unchecked;
        public RelayCommand FilterProductsByType_Unchecked
        {
            get => _filterProductsByType_Unchecked ??=
                new RelayCommand(obj =>
                {
                    _filterProductsByType = false;
                    ReloadProductList();
                });
        }

        private RelayCommand _makeBooking;
        public RelayCommand MakeBooking
        {
            get => _makeBooking ??= new RelayCommand(obj =>
            {
                if (SelectedProduct == null)
                {
                    Messege = "fail: you did`n choose product";
                }
                else if (!_bookingService.DoesProductAvailable(SelectedProduct.Id))
                {
                    Messege = "fail: product already booked";
                }
                else
                {
                    _bookingService.MakeBooking(SelectedProduct.Id, DateTime.Now);
                    Messege = "succsess";
                    Bookings = new ObservableCollection<BookingView>(_bookingService.GetAllBookings());
                }
            });
        }

        private RelayCommand _deleteBooking;
        public RelayCommand DeleteBooking
        {
            get => _deleteBooking ??= new RelayCommand(obj =>
            {
                if (SelectedBooking == null)
                {
                    Messege = "fail: you didn`t choose booking for deletiing";
                }
                else 
                {
                    _bookingService.DeleteBooking(SelectedBooking.Id);
                    Bookings = new ObservableCollection<BookingView>(_bookingService.GetAllBookings());
                    Messege = "succsess";
                }
            });
        }


        private string _textFor_tbFindByName;
        public string TextFor_tbFindByName 
        { 
            get => _textFor_tbFindByName;
            set
            {
                _textFor_tbFindByName = value;
                OnPropertyChanged(nameof(TextFor_tbFindByName));
            } 
        }

        private RelayCommand _filterTypesByName;
        public RelayCommand FilterTypesByName 
        {
            get => _filterTypesByName ??= new RelayCommand(obj =>
            {
                ProductTypes = new ObservableCollection<ProductTypeView>(_productTypeService.FindByName(TextFor_tbFindByName));
            });
        }


        private void ReloadProductList()
        {
            if (_filterProductsByType & _filterProductsByStore && SelectedProductType != null && SelectedStore != null)
            {
                Products = new ObservableCollection<ProductView>(
                    _productService
                    .GetAllProductsWithSelectedProductTypeAndStore(
                        SelectedProductType.Id,
                        SelectedStore.Id
                        )
                    );
            }
            else if (_filterProductsByType && SelectedProductType != null)
            {
                Products = new ObservableCollection<ProductView>(
                    _productService.
                    GetAllProductsWithSelectedProductType(
                        SelectedProductType.Id
                        )
                    );
            }
            else if (_filterProductsByStore && SelectedStore != null)
            {
                Products = new ObservableCollection<ProductView>(
                       _productService
                       .GetAllProductsInStore(
                           SelectedStore.Id
                           )
                       );
            }
            else
            {
                Products = new ObservableCollection<ProductView>(
                    _productService.GetAllProducts()
                    );
            }
        }

        public MainWindowViewModel(IProductTypeService productTypeService, IStoreService storeService, IBookingService bookingService, IProductService productService)
        {
            _productTypeService = productTypeService;
            _storeService = storeService;
            _bookingService = bookingService;
            _productService = productService;
        }
        
        
    }
}
