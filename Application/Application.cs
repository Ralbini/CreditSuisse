using Credit_Suisse.Domain;
using Credit_Suisse.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Credit_Suisse.Application
{
    class Application
    {
        public List<Category> LoadCategories()
        {
            List<Category> listCategory = new List<Category>();
           
            Category categoryEXPIRED = new Category();
            categoryEXPIRED.Name = "EXPIRED";          
            categoryEXPIRED.RuleType = RuleType.DateExpired;
            categoryEXPIRED.DaysExpire = 30;
            listCategory.Add(categoryEXPIRED);

            Category categoryHIGHRISK = new Category();
            categoryHIGHRISK.Name = "HIGHRISK";
            categoryHIGHRISK.ClientSector = ClientSector.Private;
            categoryHIGHRISK.RuleType = RuleType.ValueRisk;
            categoryHIGHRISK.ValueGreate = 100000;
            listCategory.Add(categoryHIGHRISK);

            Category categoryMEDIUMRISK = new Category();
            categoryMEDIUMRISK.Name = "MEDIUMRISK";
            categoryMEDIUMRISK.ClientSector = ClientSector.Public;
            categoryMEDIUMRISK.RuleType = RuleType.ValueRisk;
            categoryMEDIUMRISK.ValueGreate = 100000;
            listCategory.Add(categoryMEDIUMRISK);

            Category categoryPEP = new Category();
            categoryPEP.Name = "PEP";
            listCategory.Add(categoryPEP);

            return listCategory;
        }

        public void DataInput()
        {
            List<Category> listCategory = LoadCategories();

            DateTime dateReference = DateTime.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            Int16 NumberTrade = Convert.ToInt16(Console.ReadLine());

            List<ITrade> listTrade = new List<ITrade>();
            int count = 0;
            while (count < NumberTrade)
            {
                string[] Line = Console.ReadLine().Split(" ");

                Trade trade = new Trade();
                trade.Value = Convert.ToDouble(Line[0].ToString());
                if (Line[1].ToString().ToUpper() == ClientSector.Private.ToString().ToUpper())
                    trade.ClientSector = ClientSector.Private;
                else if (Line[1].ToString().ToUpper() == ClientSector.Public.ToString().ToUpper())

                    trade.ClientSector = ClientSector.Public;

                trade.NextPaymentDate = DateTime.Parse(Line[2].ToString(), new CultureInfo("en-US"));

                listTrade.Add(trade);

                count += 1;
            }
            CalculateRisk calculate = new CalculateRisk();
            calculate.Execute(listTrade, listCategory, dateReference);

            Console.ReadLine();
        }
    }
}
