using Credit_Suisse.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Credit_Suisse.Domain
{
    class Trade : ITrade
    {
        private double value {get ; set; }
        private ClientSector clientSector { get; set; }
        private DateTime nextPaymentDate { get; set; }

        public double Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }


        public ClientSector ClientSector
        {
            get
            {
                return clientSector;
            }
            set
            {
                clientSector = value;
            }
        }

        public DateTime NextPaymentDate
        {
            get
            {
                return nextPaymentDate;
            }
            set
            {
                nextPaymentDate = value;
            }
        }
    }
}
