using ItDevRisk.Domain.Entities;
using ItDevRisk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItDevRisk.Domain.Specifications
{
    public interface ITradeSpecification
    {
        bool isSatisfiedBy(Trade trade);
    }
}
