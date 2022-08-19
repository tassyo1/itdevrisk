using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.Mapper;
using ItDevRisk.Domain.Specifications;
using ItDevRisk.Domain.ViewModels;
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
            var viewModel = new TradeViewModel();            
            viewModel.ReferenceDate = Console.ReadLine().ToString();

            var tradeCount = Convert.ToInt32(Console.ReadLine());                       

            var tradeList = new List<Trade>();

            for (int i = 1; i <= tradeCount; i++)
            {                
                viewModel.TradeString = Console.ReadLine().ToString();

                var trade = viewModel.ToTrade();

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
