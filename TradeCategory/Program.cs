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


            categoryService.CategorizeTrades();


            //var categoryFactory = serviceProvider.GetService<ICategoryFactory>();

            //Trade trade = new Trade(1000000.3434, "Public", DateTime.Now);
            //ICategory category = categoryFactory.CreateCategory(trade, DateTime.Now.AddDays(50));


            //string path = @"c:\temp\MyTest.txt";

            //// This text is added only once to the file.
            //if (!File.Exists(path))
            //{
            //    // Create a file to write to.
            //    string createText = "A categoria é: " + category.Name + Environment.NewLine;
            //    File.WriteAllText(path, createText, Encoding.UTF8);
            //}

            //// This text is always added, making the file longer over time
            //// if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText, Encoding.UTF8);

            //// Open the file to read from.
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);



            //Console.WriteLine("A categoria é:" + category.Name);
        }

        //private static void ConfigureServices(ServiceCollection serviceCollection)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
