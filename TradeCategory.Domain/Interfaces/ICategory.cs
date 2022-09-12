using System;
using TradeCategory.Domain.Model;

namespace TradeCategory.Domain.Interfaces
{
    public interface ICategory
    {
        bool isCategoryOfTrade(Trade trade, DateTime? referenceDate = null);

        string Name { get; }
    }
}
