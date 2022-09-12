using System;
using TradeCategory.Domain.Extensions;
using TradeCategory.Application.Interface;
using TradeCategory.Domain.Interfaces;
using TradeCategory.Domain.Model;

namespace TradeCategory.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryFactory _categoryFactory;
        private readonly IConsoleService _consoleService;
        private readonly IIOService _iOService;

        public CategoryService(
            ICategoryFactory categoryFactory,
            IConsoleService consoleService,
            IIOService iOService

            )
        {
            _categoryFactory = categoryFactory;
            _consoleService = consoleService;
            _iOService = iOService;
        }

        public void CategorizeTrades()
        {
            try
            {
                _consoleService.Output("Categorize trades in a Bank`s portifolio");

                _consoleService.Output("Input reference Date");
                DateTime referenceDate = _consoleService.InputDate();

                _consoleService.Output("Input number of trades");
                int numberOfTrades = _consoleService.InputInt();

                _consoleService.Output("Input trades");

                string[] listCategory = new string[numberOfTrades];
                for (int i = 0; i < numberOfTrades; i++)
                {
                    ICategory category = 
                        _categoryFactory.CreateCategory(_consoleService.InputTrade(), referenceDate);
                    listCategory[i] = category.Name;
                }
                _consoleService.Output("Output:");
                for (int i = 0; i < numberOfTrades; i++)
                {
                    _consoleService.Output(listCategory[i]);
                }
            }
            catch (Exception ex)
            {
                _consoleService.Output("Error Message: " + ex.Message);
            }
        }



    }
}
