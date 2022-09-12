using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategory.Domain.Factories;
using TradeCategory.Domain.Interfaces;
using TradeCategory.Domain.Model;
using TradeCategory.Domain.Model.Categorys;

namespace TradeCategory.Domain.Factories
{
    public class CategoryFactory : ICategoryFactory
    {
        public CategoryFactory() { }

        public ICategory CreateCategory(Trade trade, DateTime referenceDate)
        {
            ICategory category;
            category = new ExpiredCategory();
            if (category.isCategoryOfTrade(trade, referenceDate))
                return category;

            category = new HighRiskCategory();
            if (category.isCategoryOfTrade(trade))
                return category;

            category = new MediumRiskCategory();
            if (category.isCategoryOfTrade(trade))
                return category;

            return new WithoutCategory();
        }
    }
}
