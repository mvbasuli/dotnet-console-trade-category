using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Text;
using System;
using TradeCategory.InfraStructure;
using TradeCategory.Domain.Model;
using TradeCategory.Domain.Factories;
using TradeCategory.Domain.Interfaces;
using TradeCategory.Application.Interface;

namespace TradeCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceCollection = new ServiceCollection();
            serviceCollection.ConfigureServices();
            var serviceProvider  = serviceCollection.BuildServiceProvider();

            var categoryService = serviceProvider.GetService<ICategoryService>();

            if (categoryService != null)
                categoryService.CategorizeTrades();
        }
    }
}
