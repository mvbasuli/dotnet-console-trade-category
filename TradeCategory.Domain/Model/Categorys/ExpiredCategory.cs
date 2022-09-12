using System;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.Domain.Model.Categorys
{
    public class ExpiredCategory : ICategory
    {
        private const string _name = "EXPIRED";

        public bool isCategoryOfTrade(Trade trade, DateTime? referenceDate)
        {
            if (referenceDate == null)
            {
                throw new Exception("Date reference cannot be null or empety");
            }
            return ((DateTime)referenceDate).AddDays(-30) > trade.NextPaymentDate;
        }

        
        public string Name
        {
            get { return _name; }
        }
    }
}
