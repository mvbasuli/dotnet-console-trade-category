using Microsoft.Extensions.DependencyInjection;
using TradeCategory.Application.Services;
using TradeCategory.Application.Interface;
using TradeCategory.Domain.Factories;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.InfraStructure
{
    public static class DependencyInjectorModule
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICategoryFactory, CategoryFactory>();
            services.AddTransient<IConsoleService, ConsoleService>();
            services.AddTransient<IIOService, IOService>();
            services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}