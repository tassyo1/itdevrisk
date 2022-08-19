using ItDevRisk.Domain.Enums;
using ItDevRisk.Domain.Interfaces;
using ItDevRisk.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItDevRisk.Domain.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }

        public string ClientSector { get; private set; }

        public DateTime ReferenceDate { get; private set; }

        public DateTime NextPaymentDate { get; private set; }

        public ECategory Category { get; private set; }

        public Trade(double value,
            string clientSector,
            DateTime referenceDate,
            DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
            ReferenceDate = referenceDate;
        }
       
        public void CategorizeExpired()
        {
            Category = ECategory.EXPIRED;
        }

        public void CategorizeHighrisk()
        {
            Category = ECategory.HIGHRISK;
        }

        public void CategorizeMediumrisk()
        {
            Category = ECategory.MEDIUMRISK;
        }
    }
}
