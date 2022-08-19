using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItDevRisk.Aplication.Services
{
    public class PrinterService  
    {       
        public void Print(IList<Trade> trades)
        {
            foreach (var trade in trades)
            {
                Console.WriteLine(trade.Category.ToString());
            }            
        }
    }
}
