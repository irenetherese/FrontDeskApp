using FrontDeskApp;
using FrontDeskApp.Common.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Repositories.EfCore;
using FrontDeskApp.Services;
using FrontDeskApp.Services.Default;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FrontDeskAppServiceCollectionExtensions
    {
        public static IServiceCollection AddFrontDeskAppServices(this IServiceCollection services, IConfiguration configuration, Assembly containingAssembly)
        {
            services.Configure<FrontDeskAppDbContextOptions>(configuration);
            services.AddDbContext<FrontDeskAppDbContext>((serviceProvider, options) =>
            {
                var config = serviceProvider.GetRequiredService<IOptions<FrontDeskAppDbContextOptions>>();
                options.UseSqlite(config.Value.ConnectionString, sqliteOptions =>
                {
                    sqliteOptions.MigrationsAssembly(containingAssembly.FullName);
                });
            });

            services.AddScoped<ICustomerRepository, EfCoreCustomerRepository>();
            services.AddScoped<IFacilityRepository, EfCoreFacilityRepository>();
            services.AddScoped<IRecordRepository, EfCoreRecordRepository>();
            services.AddScoped<IFacilityStorageInfoRepository, EfCoreFacilityStorageInfoRepository>();

            services.AddScoped<ICustomerService, DefaultCustomerService>();
            services.AddScoped<IFacilityService, DefaultFacilityService>();
            services.AddScoped<IRecordService, DefaultRecordService>();

            return services;
        }
    }
}
