using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ItDevRisk.Domain.Mapper
{
   public static class TradeFromViewModel
    {
        public static Trade ToTrade(this TradeViewModel viewModel)
        {
            DateTime.TryParse(viewModel.ReferenceDate,
                out DateTime referenceDate);

             var tradeStringList = new List<string>();                
             tradeStringList.AddRange(viewModel.TradeString.Split(' ').ToList());

            double.TryParse(tradeStringList[0], out double convertedValue);

            var cultureInfo = new CultureInfo("en-US");
            var nextPaymentDate = DateTime.Parse(tradeStringList[2], cultureInfo);

            return new Trade(convertedValue, tradeStringList[1],
                    referenceDate, nextPaymentDate);
        }
    }
}
