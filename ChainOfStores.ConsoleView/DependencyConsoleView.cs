using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.ConsoleView
{
    static class DependencyConsoleView
    {
        static IServiceCollection SetConsoleViewDependencies(this IServiceCollection services)
        {
            services.AddScoped<BookingConsolePage>();
            services.AddScoped<StoreConsolePage>();
            services.AddScoped<ProductConsolePage>();
            services.AddScoped<ProductTypeConsolePage>();
            services.AddScoped<SelectedItems>();
            return services;
        }
    }
}
