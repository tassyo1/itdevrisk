using ItDevRisk.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItDevRisk.Domain.Interfaces
{
    interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
        ECategory Category { get; }        
    }
}
