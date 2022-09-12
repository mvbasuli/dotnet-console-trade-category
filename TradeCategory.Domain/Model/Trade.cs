using System;
using TradeCategory.Domain.Interfaces;

namespace TradeCategory.Domain.Model
{
    public class Trade : ITrade
    {
        public Trade() { }

        public Trade(
            double value,
            string clientSector,
            DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        public Trade CreateTrade(
            double value,
            string clientSector,
            DateTime nextPaymentDate)
        {
            return new Trade(
            value,
            clientSector,
            nextPaymentDate);
        }

        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }


    }
}
