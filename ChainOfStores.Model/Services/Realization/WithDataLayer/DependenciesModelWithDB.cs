using ChainOfStores.Model.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WithDataLayer
{
    public static class DependenciesModelWithDB
    {
        public static IServiceCollection SetModelWithDBDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStoreService, StoreServiceDL>();
            services.AddScoped<IProductService, ProductServiceDL>();
            services.AddScoped<IProductTypeService, ProductTypeServiceDL>();
            services.AddScoped<IBookingService, BookingServiceDL>();
            return services;
        }
    }
}
