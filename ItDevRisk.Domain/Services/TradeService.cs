using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ItDevRisk.Domain.Services
{
    public class TradeService
    {
        public List<Trade> GetTrades()
        {
            DateTime.TryParse(Console.ReadLine().ToString(),
                out DateTime referenceDate);
            var tradeCount = Convert.ToInt32(Console.ReadLine());
            var tradeStringList = new List<string>();

            var tradeList = new List<Trade>();

            for (int i = 1; i <= tradeCount; i++)
            {
                tradeStringList.Clear();
                tradeStringList.AddRange(Console.ReadLine().ToString().Split(' ').ToList());

                double.TryParse(tradeStringList[0], out double convertedValue);

                var cultureInfo = new CultureInfo("en-US");
                var nextPaymentDate = DateTime.Parse(tradeStringList[2], cultureInfo);

                var trade = new Trade(convertedValue, tradeStringList[1],
                    referenceDate, nextPaymentDate);

                Categorize(trade);

                tradeList.Add(trade);
            }
            return tradeList;
        }

        private void Categorize(Trade trade)
        {
            if (new ExpiredTradeSpecification().isSatisfiedBy(trade))
            {
                trade.CategorizeExpired();
                return;
            }

            if (new HighRiskSpecification().isSatisfiedBy(trade))
            {
                trade.CategorizeHighrisk();
                return;
            }

            if (new MediumRiskSpecification().isSatisfiedBy(trade))
            {
                trade.CategorizeMediumrisk();
                return;
            }
        }
    }
}
