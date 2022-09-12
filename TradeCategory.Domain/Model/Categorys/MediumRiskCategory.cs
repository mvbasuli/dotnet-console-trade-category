using System;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.Domain.Model.Categorys
{
    public class MediumRiskCategory : ICategory
    {
        private const string _name = "MEDIUMRISK";

        public bool isCategoryOfTrade(Trade trade, DateTime? referenceDate = null)
        {
            return trade.ClientSector == "Public" && trade.Value > 1000000;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
