using ItDevRisk.Aplication.Services;
using ItDevRisk.Domain.Services;
using System;
using System.Linq;

namespace ItDevRisk.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {            
            var printer = new PrinterService();
            var tradeService = new TradeService();
            
            printer.Print(tradeService.GetTrades());

            Console.ReadKey();
        }
    }
}
