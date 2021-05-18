using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.Services.Realization.WhitoutDB;
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
            IStoreService storeService = new StoreServiceWithoutDB();
            IProductService productService = new ProductServiceWithoutDB();
            IProductTypeService productTypeService = new ProductTypeServiceWithoutDB();
            IBookingService bookingService = new BookingServiceWithoutDB();
            DataContext = new MainWindowViewModel(productTypeService,storeService,bookingService,productService);
        }

        private void cbShowProductsInSelectedStore_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
