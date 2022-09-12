using System;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.Domain.Model.Categorys
{
    public class HighRiskCategory : ICategory
    {
        private const string _name = "HIGHRISK";

        public bool isCategoryOfTrade(Trade trade, DateTime? referenceDate = null)
        {
            return trade.ClientSector == "Private" && trade.Value > 1000000;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
