using Credit_Suisse.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Credit_Suisse.Service
{
    interface ITrade
    {
        double Value { get; }
        ClientSector ClientSector { get; }
        DateTime NextPaymentDate { get;  }
    }
}
