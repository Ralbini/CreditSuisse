using Credit_Suisse.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Credit_Suisse.Service
{
    class CalculateRisk
    {
        public CalculateRisk()
        { 
        
        }

        public void Execute(List<ITrade> listTrade, List<Category> listCategory, DateTime dateReference)
        {
            foreach (var Trade in listTrade)
            {
                foreach (var category in listCategory)
                {
                    if (category.RuleType == RuleType.DateExpired)
                    {
                        if (Trade.NextPaymentDate < dateReference.AddDays(category.DaysExpire))
                        {
                            Console.WriteLine(category.Name);
                            break;
                        }
                    }

                    if (category.RuleType == RuleType.ValueRisk)
                    {

                        if ((Trade.ClientSector == category.ClientSector) && (Trade.ClientSector == ClientSector.Public) &&
                           (Trade.Value > category.ValueGreate))
                        {
                            Console.WriteLine(category.Name);
                            break;
                        }
                        else if ((Trade.ClientSector == category.ClientSector) && (Trade.ClientSector == ClientSector.Private) &&
                        (Trade.Value > category.ValueGreate))
                        {
                            Console.WriteLine(category.Name);
                            break;
                        }
                    }
                }
            }

        }
    }
}
