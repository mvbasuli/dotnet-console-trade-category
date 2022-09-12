using System;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.Domain.Model.Categorys
{
    public class WithoutCategory: ICategory
    {
        private const string _name = "WITHOUTCATEGORY";

        public bool isCategoryOfTrade(Trade trade, DateTime? referenceDate = null) {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
