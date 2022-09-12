using System;
using TradeCategory.Domain.Factories;
using TradeCategory.Domain.Model;

namespace TradeCategory.Domain.Interfaces
{
    public interface ICategoryFactory
    {
        ICategory CreateCategory(Trade trade, DateTime referenceDate);
    }
}
