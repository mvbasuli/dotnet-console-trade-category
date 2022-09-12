using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategory.Domain.Model;

namespace TradeCategory.Application.Interface
{
    public interface IInputOutputService
    {
        string Input();

        int InputInt();

        DateTime InputDate();

        Trade InputTrade();

        void Output(string text);
    }
}
