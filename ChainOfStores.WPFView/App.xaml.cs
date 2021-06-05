using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ChainOfStores.EFData;
using ChainOfStores.Model.Services.Realization.WhitoutDB;
using ChainOfStores.Model.Services.Realization.WithDataLayer;

namespace Cha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.SetEFDataDependencies();
            services.SetModelWithDBDependencies();
            //services.SetModelWithoutDBDependencies();
            services.AddSingleton<MainWindowViewModel>();
            services.AddScoped<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)

        {
            
            MainWindow mainWindow = serviceProvider.GetService<MainWindow>(); 
            mainWindow.Show();
        }
    }
}
