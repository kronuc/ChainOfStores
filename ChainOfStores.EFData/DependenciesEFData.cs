using ChainOfStores.EFData.Repositories.Inerfaces;
using ChainOfStores.EFData.Repositories.Realisation.EFRealisation;
using ChainOfStores.EFData.UnitOfWork.Interfaces;
using ChainOfStores.EFData.UnitOfWork.Realisation.EFRealisation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData
{
    public static class DependenciesEFData
    {
        public static IServiceCollection SetEFDataDependencies(this IServiceCollection services)
        {
            services.AddScoped<EFAppDBContext>();
            services.AddScoped<IStoreRepository, EFStoreRepository>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<IProductTypeRepository, EFProductTypeRepository>();
            services.AddScoped<IBookingRepository, EFBookingRepository>();
            services.AddScoped<IBookingDurationRepository, EFBookingDurationRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();
            return services;
        }
    }
}
