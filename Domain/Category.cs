using System;
using System.Collections.Generic;
using System.Text;

namespace Credit_Suisse.Domain
{
    class Category
    {
        private string name { get; set; }

        private ClientSector clientSector;
	
		private RuleType ruleType;

        private double valueGreate;

		private Int32 daysExpire;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
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

		public RuleType RuleType
		{
			get
			{
				return ruleType;
			}
			set
			{
				ruleType = value;
			}
		}

		public double ValueGreate
		{
			get
			{
				return valueGreate;
			}
			set
			{
				valueGreate = value;
			}
		}
		public Int32 DaysExpire
		{
			get
			{
				return daysExpire;
			}
			set
			{
				daysExpire = value;
			}
		}
		
	}
}
