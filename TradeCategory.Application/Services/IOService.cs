using System;
using TradeCategory.Application.Interface;
using TradeCategory.Domain.Extensions;
using TradeCategory.Domain.Model;

namespace TradeCategory.Application.Services
{
    public class IOService : IIOService
    {
        public IOService() { }

        public string Input()
        {
            return Console.ReadLine();
        }

        public int InputInt()
        {
            return Console.ReadLine().InputToInt();
        }

        public DateTime InputDate()
        {
            return Console.ReadLine().InputToDate();
        }
        public Trade InputTrade()
        {
            return Console.ReadLine().InputToTrade();
        }

        public void Output(string text)
        {
            Console.WriteLine(text);
        }
    }
}
