using System;
using TradeCategory.Domain.Model;

namespace TradeCategory.Domain.Interfaces
{
    public interface ITrade
    {
        Trade CreateTrade(
            double value,
            string clientSector,
            DateTime nextPaymentDate);
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}
