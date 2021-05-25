﻿using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.Services.Realization.WhitoutDB;
using ChainOfStores.Model.Services.Realization.WithDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IProductTypeService productTypeService = new ProductTypeServiceDL();
            IStoreService storeService = new StoreServiceDL();
            IProductService productService = new ProductServiceDL();
            IBookingService bookingService = new BookingServiceDL();
            DataContext = new MainWindowViewModel(productTypeService,storeService,bookingService,productService);
        }

    }
}
