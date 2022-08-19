using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItDevRisk.Domain.Specifications
{
    public class ExpiredTradeSpecification : ITradeSpecification
    {
        public bool isSatisfiedBy(Trade trade)
        {
            return (trade.ReferenceDate - trade.NextPaymentDate).TotalDays > 30;                      
        }
    }
}
