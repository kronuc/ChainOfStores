using ChainOfStores.Model.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WhitoutDB
{
    public static class DependenciesModelWithoutDB
    {
        public static IServiceCollection SetModelWithoutDBDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBookingService, BookingServiceWithoutDB>();
            services.AddScoped<IStoreService, StoreServiceWithoutDB>();
            services.AddScoped<IProductService, ProductServiceWithoutDB>();
            services.AddScoped<IProductTypeService, ProductTypeServiceWithoutDB>();
            return services;
        }
    }
}
