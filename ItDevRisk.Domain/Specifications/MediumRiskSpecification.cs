using ItDevRisk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItDevRisk.Domain.Specifications
{
    public class MediumRiskSpecification : ITradeSpecification
    {
        public bool isSatisfiedBy(Trade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Public"; 
        }
    }
}
